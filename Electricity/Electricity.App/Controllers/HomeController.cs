using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Electricity.App.Models;
using System.Net.Http;
using Newtonsoft.Json;
using Electricity.DTO.Dtos;

namespace Electricity.App.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            using ( var client = new HttpClient() )
            {
                var result = await client.GetAsync( "http://localhost:8050/api/Data/GetDeliveryPointMeters" );
                ViewBag.items = await result.Content.ReadAsStringAsync();
            }
            return View();
        }

        public async Task<IActionResult> First()
        {
            var model = new FirstVm();

            using ( var client = new HttpClient() )
            {
                var result = await client.GetAsync( "http://localhost:8050/api/Data/GetMetersWhereFaultValidationDate?id=1" );
                
                var resultString = await result.Content.ReadAsStringAsync();
                
                var data = JsonConvert.DeserializeObject<List<ElectricityMeterDto>>( resultString );
                
                model.Items = data;
            }
            return View(model);
        }


        public async Task<IActionResult> Second()
        {
            var model = new SecondVm();

            using ( var client = new HttpClient() )
            {
                var result = await client.GetAsync( "http://localhost:8050/api/Data/GetElectricityTransformators?id=1" );
                
                var resultString = await result.Content.ReadAsStringAsync();

                var data = JsonConvert.DeserializeObject<List<ElectricityTransformatorDto>>( resultString );

                model.Items = data;
            }

            return View( model );
        }

        public async Task<IActionResult> Third()
        {
            var model = new ThirdVm();

            using ( var client = new HttpClient() )
            {
                var result = await client.GetAsync( "http://localhost:8050/api/Data/GetVoltageTransformators?id=1" );

                var resultString = await result.Content.ReadAsStringAsync();

                var data = JsonConvert.DeserializeObject<List<VoltageTransformatorDto>>( resultString );

                model.Items = data;
            }
            return View( model );
        }

        [ResponseCache( Duration = 0, Location = ResponseCacheLocation.None, NoStore = true )]
        public IActionResult Error()
        {
            return View( new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier } );
        }
    }
}
