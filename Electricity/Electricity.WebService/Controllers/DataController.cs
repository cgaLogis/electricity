using AutoMapper;
using Electricity.CORE.Services;
using Electricity.DTO.Dtos;
using Electricity.WebService.Models;
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

        private IMapper _mapper;

        public DataController( IDataService dataService,IMapper mapper )
        {
            _dataService = dataService;

            _mapper = mapper;
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

        /// <summary>
        /// Добавить новую точку измерения с указанием счетчика, трансформатора тока
        ///и трансформатора напряжения.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Post( ElectricityPointModel model )
        {
            if(model == null )
            {
                return BadRequest();
            }

            if ( !ModelState.IsValid )
            {
                return BadRequest( ModelState );
            }

            var dto = _mapper.Map<ElectricityPointDto>( model );

            var res = await _dataService.AddElectricityPoint( dto );

            return Ok(res);
        }

    }
}
