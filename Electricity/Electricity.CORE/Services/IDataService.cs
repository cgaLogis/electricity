using Electricity.DTO.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Electricity.CORE.Services
{
    public interface IDataService
    {

        /// <summary>
        /// Добавить точку измрения с указанием счетчика трансформатора тока и трансформатора напряжения
        /// </summary>
        /// <returns></returns>
        Task<ElectricityPointDto> AddElectricityPoint(ElectricityPointDto model);

        /// <summary>
        /// выбрать все расчетные приборы учета в 2018 году
        /// </summary>
        /// <returns></returns>
        Task<List<DeliveryPointMeterDto>> GetAllDeliveryPointMeters2018();


        /// <summary>
        /// По указанному объекту потребления выбрать все счетчики с закончившимся
        /// сроком поверке.
        /// </summary>
        /// <returns></returns>
        Task<List<ElectricityMeterDto>> GetAllElectricityMeter( int consumptionObjectId);

        /// <summary>
        /// По указанному объекту потребления выбрать все трансформаторы напряжения с закончившимся сроком поверке.
        /// </summary>
        /// <param name="consumptionObjectId"></param>
        /// <returns></returns>
        Task<List<VoltageTransformatorDto>> GetAllVoltageTransformators( int consumptionObjectId );

        /// <summary>
        /// По указанному объекту потребления выбрать все трансформаторы тока с закончившимся сроком поверке.
        /// </summary>
        /// <param name="consumptionObjectId"></param>
        /// <returns></returns>
        Task<List<ElectricityTransformatorDto>> GetAllElectricityTransformators( int consumptionObjectId );
    }
}
