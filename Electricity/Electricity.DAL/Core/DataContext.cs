using Electricity.DAL.Core.Seeder;
using Electricity.DAL.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Electricity.DAL.Core
{
    public class DataContext : DbContext
    {
        public DataContext( DbContextOptions options ) : base( options )
        {
           // Database.SetInitializer<DataContext>( new CreateDatabaseIfNotExists<DataContext>() );
        }

        protected override void OnModelCreating( ModelBuilder modelBuilder )
        {
            modelBuilder
                .Entity<Organization>()
                .HasKey( e => e.Id );
            modelBuilder
                .Entity<Organization>()
                .HasMany( e => e.ChildOrganizations );

            modelBuilder
                .Entity<ChildOrganization>()
                .HasKey( e => e.Id );
            modelBuilder
                .Entity<ChildOrganization>()
                .HasOne( e => e.Parent )
                .WithMany(e=>e.ChildOrganizations);

            modelBuilder
                .Entity<ChildOrganization>()
                .HasMany( e => e.Objects )
                .WithOne( e => e.Organization );

            modelBuilder
                .Entity<ConsumptionObject>()
                .HasKey( e => e.Id );

            modelBuilder
               .Entity<ConsumptionObject>()
               .HasOne( e => e.Organization )
               .WithMany(e=>e.Objects)
               .HasForeignKey(e=>e.OrganizationId);

            modelBuilder
                .Entity<ConsumptionObject>()
                .HasMany( e => e.Points )
                .WithOne(e=>e.Object)
                .HasForeignKey(e=>e.ObjectId);

            modelBuilder
                .Entity<ElectricityPoint>()
                .HasKey( e => e.Id );

            //modelBuilder
            //    .Entity<ElectricityPoint>()
            //    .HasOne<ConsumptionObject>( e => e.Object );


            modelBuilder
               .Entity<ElectricityMeter>()
               .HasKey( e => e.Id );

            modelBuilder
               .Entity<VoltageTransformator>()
               .HasKey( e => e.Id );

            modelBuilder
               .Entity<ElectricityTransformator>()
               .HasKey( e => e.Id );

            //modelBuilder
            //    .Entity<ElectricityPoint>()
            //    .HasOne( e => e.ElectMeter )
            //    .WithOne(e=>e.Point)
            //    .HasForeignKey<ElectricityMeter>(e=>e.Point );

            //modelBuilder
            //    .Entity<ElectricityPoint>()
            //    .HasOne( e => e.VoltageTransformator )
            //    .WithOne( e => e.Point );

            //modelBuilder
            //    .Entity<ElectricityPoint>()
            //    .HasOne( e => e.ElectricityTransformator )
            //    .WithOne(e=>e.Point);
            //    //.WithOne( e => e.Point )
            //    //.HasForeignKey<ElectricityPoint>( e => e.Id );

            //modelBuilder
            //    .Entity<ElectricityPoint>()
            //    .HasOne( e => e.ElectMeter )
            //    .WithOne(e=>e.Point);

            modelBuilder
                .Entity<DeliveryPoint>()
                .HasKey( e => e.Id );

            modelBuilder
                .Entity<DeliveryPointMeter>()
                .HasKey( e => e.Id );

            modelBuilder
                .Entity<DeliveryPoint>()
                .HasMany( e => e.DeliveryPointMeters )
                .WithOne( e => e.DeliveryPoint )
                .HasForeignKey( e => e.DeliveryPointId );

            modelBuilder.Seed();
        }

        public IQueryable<Organization> OrganizationsNoTrack => Organizations.AsNoTracking();

        public IQueryable<ChildOrganization> ChildOrganizationsNoTrack => ChildOrganizations.AsNoTracking();

        public IQueryable<ConsumptionObject> ConsumptionObjectsNoTrack => ConsumptionObjects.AsNoTracking();
        public IQueryable<ElectricityPoint> ElectricityPointsNoTrack => ElectricityPoints.AsNoTracking();

        public IQueryable<ElectricityMeter> ElectricityMeterNoTrack => ElectricityMeters.AsNoTracking();

        public IQueryable<ElectricityTransformator> ElectricityTransformatorsNoTrack => ElectricityTransformators.AsNoTracking();

        public IQueryable<VoltageTransformator> VoltageTransformatorsNoTrack => VoltageTransformators.AsNoTracking();

        public IQueryable<DeliveryPoint> DeliveryPointsNoTrack => DeliveryPoints.AsNoTracking();

        public IQueryable<DeliveryPointMeter> DeliveryPointMetersNoTrack => DeliveryPointMeters.AsNoTracking();


        public DbSet<Organization> Organizations { get; set; }

        public DbSet<ChildOrganization> ChildOrganizations { get; set; }

        public DbSet<ConsumptionObject> ConsumptionObjects { get; set; }

        public DbSet<ElectricityPoint> ElectricityPoints { get; set; }

        public DbSet<ElectricityMeter> ElectricityMeters { get; set; }

        public DbSet<ElectricityTransformator> ElectricityTransformators { get; set; }

        public DbSet<VoltageTransformator> VoltageTransformators { get; set; }

        public DbSet<DeliveryPoint> DeliveryPoints { get; set; }

        public DbSet<DeliveryPointMeter> DeliveryPointMeters { get; set; }

        public DbSet<ElectricityPointDeliveryPointMeter> ElectricityPointDeliveryPointMeters { get; set; }

    }
}
