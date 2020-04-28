using Electricity.DAL.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Electricity.DAL.Core.Seeder
{
    public static class Seeder
    {
        public static void Seed(this ModelBuilder builder) {

            SeedOrganizations( builder );

           // SeedConsumptionObjects( builder );

           // SeedDeliveryPoints( builder );

            //SeedDeliveryPointMeters( builder );
        }


        private static void SeedOrganizations( this ModelBuilder builder )
        {
            var org1 = new Organization
            {
                Id = 1,
                Name = "Test",
                Address = "Moscow"
            };

            builder.Entity<Organization>().HasData( org1 );



            var org2 = new Organization
            {
                Id = 2,
                Name = "Test",
                Address = "Moscow"
            };

            builder.Entity<Organization>().HasData( org2 );

            var org3 = new Organization
            {
                Id = 3,
                Name = "Test",
                Address = "Moscow"
            };

            builder.Entity<Organization>().HasData( org3 );

            var childOrg1 = new ChildOrganization()
            {
                Id = 1,
                Name = "Child1",
                Address = "Moscow",
                ParentId = org1.Id
            };

            var childOrg2 = new ChildOrganization()
            {
                Id = 2,
                Name = "Child1",
                Address = "Moscow",
                ParentId = org1.Id
            };

            var childOrg3 = new ChildOrganization()
            {
                Id = 3,
                Name = "Child1",
                Address = "Moscow",
                ParentId = org2.Id
            };

            var childOrg4 = new ChildOrganization()
            {
                Id = 4,
                Name = "Child1",
                Address = "Moscow",
                ParentId = org3.Id
            };

            builder.Entity<ChildOrganization>().HasData( childOrg1, childOrg2, childOrg3, childOrg4 );

            var co1 = new ConsumptionObject()
            {
                Id = 1,
                Address = "Empty address",
                Name = "Объект потребления 1",
                OrganizationId = 1
            };
            var co2 = new ConsumptionObject()
            {
                Id = 2,
                Address = "Empty address",
                Name = "Объект потребления 1",
                OrganizationId = 1
            };

            var co3 = new ConsumptionObject()
            {
                Id = 3,
                Address = "Empty address",
                Name = "Объект потребления 1",
                OrganizationId = 1
            };

            var co4 = new ConsumptionObject()
            {
                Id = 4,
                Address = "Empty address",
                Name = "Объект потребления 1",
                OrganizationId = 1
            };

            var co5 = new ConsumptionObject()
            {
                Id = 5,
                Address = "Empty address",
                Name = "Объект потребления 1",
                OrganizationId = 1
            };

            builder.Entity<ConsumptionObject>().HasData( co1, co2, co3, co4, co5 );

            var dp1 = new DeliveryPoint()
            {
                Id = 1,
                ConsumptionObjectId = 1,
                MaxPower = 100,
                Name = "Точка поставки электроэнергии 1 "
            };
            var dp2 = new DeliveryPoint()
            {
                Id = 2,
                ConsumptionObjectId = 2,
                MaxPower = 100,
                Name = "Точка поставки электроэнергии 1 "
            };
            var dp3 = new DeliveryPoint()
            {
                Id = 3,
                ConsumptionObjectId = 3,
                MaxPower = 100,
                Name = "Точка поставки электроэнергии 1 "
            };
            var dp4 = new DeliveryPoint()
            {
                Id = 4,
                ConsumptionObjectId = 4,
                MaxPower = 100,
                Name = "Точка поставки электроэнергии 1 "
            };
            var dp5 = new DeliveryPoint()
            {
                Id = 5,
                ConsumptionObjectId = 4,
                MaxPower = 100,
                Name = "Точка поставки электроэнергии 1 "
            };

            builder.Entity<DeliveryPoint>().HasData( dp1, dp2, dp3, dp4, dp5 );


            var dpm1 = new DeliveryPointMeter()
            {
                Id = 1,
                DeliveryPointId = 1
            };

            var dpm2 = new DeliveryPointMeter()
            {
                Id = 2,
                DeliveryPointId = 2
            };
            var dpm3 = new DeliveryPointMeter()
            {
                Id = 3,
                DeliveryPointId = 3
            };
            var dpm4 = new DeliveryPointMeter()
            {
                Id = 4,
                DeliveryPointId = 4
            };
            var dpm5 = new DeliveryPointMeter()
            {
                Id = 5,
                DeliveryPointId = 5
            };

            builder.Entity<DeliveryPointMeter>().HasData( dpm1, dpm2, dpm3, dpm4, dpm5 );

            var em1 = new ElectricityMeter()
            {
                Id = 1,
                ElectricityPointId = 1,
                Number = "KakoitoNomer",
                Type = Enums.ElectricityMeterType.One,
                ValidationDate = DateTime.Parse( "02.02.2012" )
            };
            var em2 = new ElectricityMeter()
            {
                Id = 2,
                ElectricityPointId = 2,
                Number = "KakoitoNomer",
                Type = Enums.ElectricityMeterType.One,
                ValidationDate = DateTime.Parse( "02.02.2017" )
            };

            builder.Entity<ElectricityMeter>().HasData( em1,em2 );

            var et1 = new ElectricityTransformator()
            {
                Id = 1,
                ElectricityPointId = 1,
                KTT = 12312,
                Type = Enums.ElectricityTransformatorType.One,
                Number = "123123123",
                ValidationDate = DateTime.Parse( "02.02.2012" )
            };
            var et2 = new ElectricityTransformator()
            {
                Id = 2,
                ElectricityPointId = 2,
                KTT = 12312,
                Type = Enums.ElectricityTransformatorType.One,
                Number = "123123123",
                ValidationDate = DateTime.Parse( "02.02.2017" )
            };

            builder.Entity<ElectricityTransformator>().HasData( et1,et2 );

            var vt1 = new VoltageTransformator()
            {
                Id = 1,
                ElectricityPointId = 1,
                KTN = 123123,
                Number = "123123",
                Type = Enums.VoltageTransformatorType.One,
                ValidationDate = DateTime.Parse( "02.02.2012" )
            };

            var vt2 = new VoltageTransformator()
            {
                Id = 2,
                ElectricityPointId = 2,
                KTN = 123123,
                Number = "123123",
                Type = Enums.VoltageTransformatorType.One,
                ValidationDate = DateTime.Parse( "02.02.2017" )
            };

            builder.Entity<VoltageTransformator>().HasData( vt1,vt2 );

            var ep1 = new ElectricityPoint()
            {
                Id = 1,
                Name = "Hello I'm point",
                ObjectId = 1,
                ElectricityMeterId = 1,
                ElectricityTransformatorId = 1,
                VoltageTransformatorId = 1
            };

            var ep2 = new ElectricityPoint()
            {
                Id = 2,
                Name = "Hello I'm point",
                ObjectId = 1,
                ElectricityMeterId = 2,
                ElectricityTransformatorId =2 ,
                VoltageTransformatorId =2 
            };

            builder.Entity<ElectricityPoint>().HasData( ep1, ep2 );

        }

        private static void SeedConsumptionObjects(this ModelBuilder builder )
        {
            var co1 = new ConsumptionObject() {
                Id = 1,
                Address= "Empty address",
                Name = "Объект потребления 1",
                OrganizationId = 1
            };
            var co2 = new ConsumptionObject()
            {
                Id = 2,
                Address = "Empty address",
                Name = "Объект потребления 1",
                OrganizationId = 1
            };

            var co3 = new ConsumptionObject()
            {
                Id = 3,
                Address = "Empty address",
                Name = "Объект потребления 1",
                OrganizationId = 1
            };

            var co4 = new ConsumptionObject()
            {
                Id = 4,
                Address = "Empty address",
                Name = "Объект потребления 1",
                OrganizationId = 1
            };

            var co5 = new ConsumptionObject()
            {
                Id = 5,
                Address = "Empty address",
                Name = "Объект потребления 1",
                OrganizationId = 1
            };

            builder.Entity<ConsumptionObject>().HasData( co1,co2,co3,co4,co5 );

        }

        private static void SeedDeliveryPoints(this ModelBuilder builder )
        {
            var dp1 = new DeliveryPoint()
            {
                Id = 1,
                ConsumptionObjectId = 1,
                MaxPower = 100,
                Name = "Точка поставки электроэнергии 1 "
            };
            var dp2 = new DeliveryPoint()
            {
                Id = 2,
                ConsumptionObjectId = 2,
                MaxPower = 100,
                Name = "Точка поставки электроэнергии 1 "
            };
            var dp3 = new DeliveryPoint()
            {
                Id = 3,
                ConsumptionObjectId = 3,
                MaxPower = 100,
                Name = "Точка поставки электроэнергии 1 "
            };
            var dp4 = new DeliveryPoint()
            {
                Id = 4,
                ConsumptionObjectId = 4,
                MaxPower = 100,
                Name = "Точка поставки электроэнергии 1 "
            };
            var dp5 = new DeliveryPoint()
            {
                Id = 5,
                ConsumptionObjectId = 4,
                MaxPower = 100,
                Name = "Точка поставки электроэнергии 1 "
            };

            builder.Entity<DeliveryPoint>().HasData( dp1, dp2, dp3, dp4, dp5 );
        }

        private static void SeedDeliveryPointMeters( this ModelBuilder builder )
        {
            var dpm1 = new DeliveryPointMeter()
            {
                Id = 1,
                DeliveryPointId = 1
            };

            var dpm2 = new DeliveryPointMeter()
            {
                Id = 2,
                DeliveryPointId = 2
            };
            var dpm3 = new DeliveryPointMeter()
            {
                Id = 3,
                DeliveryPointId = 3
            };
            var dpm4 = new DeliveryPointMeter()
            {
                Id = 4,
                DeliveryPointId = 4
            };
            var dpm5 = new DeliveryPointMeter()
            {
                Id = 5,
                DeliveryPointId = 5
            };

            builder.Entity<DeliveryPointMeter>().HasData( dpm1, dpm2, dpm3, dpm4, dpm5 );
        }
    }
}
