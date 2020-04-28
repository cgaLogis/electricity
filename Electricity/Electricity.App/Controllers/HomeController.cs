using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Electricity.App.Models;
using System.Net.Http;

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
            using ( var client = new HttpClient() )
            {
                var result = await client.GetAsync( "http://localhost:8050/api/Data/GetMetersWhereFaultValidationDate?id=1" );
                ViewBag.items = await result.Content.ReadAsStringAsync();
            }
            return View();
        }


        public async Task<IActionResult> Second()
        {
            using ( var client = new HttpClient() )
            {
                var result = await client.GetAsync( "http://localhost:8050/api/Data/GetElectricityTransformators?id=1" );
                ViewBag.items = await result.Content.ReadAsStringAsync();
            }
            return View();
        }

        public async Task<IActionResult> Third()
        {
            using ( var client = new HttpClient() )
            {
                var result = await client.GetAsync( "http://localhost:8050/api/Data/GetVoltageTransformators?id=1" );
                ViewBag.items = await result.Content.ReadAsStringAsync();
            }
            return View();
        }

        [ResponseCache( Duration = 0, Location = ResponseCacheLocation.None, NoStore = true )]
        public IActionResult Error()
        {
            return View( new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier } );
        }
    }
}
