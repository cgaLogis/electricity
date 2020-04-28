using Electricity.CORE.Services;
using Electricity.DTO.Dtos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Electricity.WebService.Controllers
{
    [Route( "api/[controller]" )]
    [ApiController]
    public class DataController : ControllerBase
    {
        private IDataService _dataService;

        public DataController( IDataService dataService )
        {
            _dataService = dataService;
        }


        /// <summary>
        /// Выбрать все расчетные приборы учета в 2018 году.
        /// </summary>
        /// <returns></returns>
        [HttpGet, Route( "GetDeliveryPointMeters" )]
        public async Task<List<DeliveryPointMeterDto>> GetDeliveryPointMeters()
        {
            var items = await _dataService.GetAllDeliveryPointMeters2018();

            return items;
        }

        /// <summary>
        /// По указанному объекту потребления выбрать все счетчики с закончившимся
        ///сроком поверке.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet, Route( "GetMetersWhereFaultValidationDate" )]
        public async Task<List<ElectricityMeterDto>> GetMetersWhereFaultValidationDate(int id)
        {
            var items = await _dataService.GetAllElectricityMeter( id );

            return items;
        }

        /// <summary>
        /// По указанному объекту потребления выбрать все трансформаторы тока с закончившимся сроком поверке.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet, Route( "GetElectricityTransformators" )]
        public async Task<List<ElectricityTransformatorDto>> GetElectricityTransformators(int id )
        {
            var items = await _dataService.GetAllElectricityTransformators( id );

            return items;
        }

        /// <summary>
        /// По указанному объекту потребления выбрать все трансформаторы напряжения с закончившимся сроком поверке.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet, Route( "GetVoltageTransformators" )]
        public async Task<List<VoltageTransformatorDto>> GetVoltageTransformators( int id )
        {
            var items = await _dataService.GetAllVoltageTransformators( id );

            return items;
        }

        [HttpPost]
        public async Task<ElectricityPointDto> Post(ElectricityPointDto model)
        {
            var res = _dataService.AddElectricityPoint(model);
            return model;
        }

    }
}
