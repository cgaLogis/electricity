﻿// <auto-generated />
using System;
using Electricity.DAL.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Electricity.DAL.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20200428122509_ElectricityPointIds")]
    partial class ElectricityPointIds
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Electricity.DAL.Entity.ChildOrganization", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("Name");

                    b.Property<int>("ParentId");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("ChildOrganizations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Moscow",
                            Name = "Child1",
                            ParentId = 1
                        },
                        new
                        {
                            Id = 2,
                            Address = "Moscow",
                            Name = "Child1",
                            ParentId = 1
                        },
                        new
                        {
                            Id = 3,
                            Address = "Moscow",
                            Name = "Child1",
                            ParentId = 2
                        },
                        new
                        {
                            Id = 4,
                            Address = "Moscow",
                            Name = "Child1",
                            ParentId = 3
                        });
                });

            modelBuilder.Entity("Electricity.DAL.Entity.ConsumptionObject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("Name");

                    b.Property<int>("OrganizationId");

                    b.HasKey("Id");

                    b.HasIndex("OrganizationId");

                    b.ToTable("ConsumptionObjects");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Empty address",
                            Name = "Объект потребления 1",
                            OrganizationId = 1
                        },
                        new
                        {
                            Id = 2,
                            Address = "Empty address",
                            Name = "Объект потребления 1",
                            OrganizationId = 1
                        },
                        new
                        {
                            Id = 3,
                            Address = "Empty address",
                            Name = "Объект потребления 1",
                            OrganizationId = 1
                        },
                        new
                        {
                            Id = 4,
                            Address = "Empty address",
                            Name = "Объект потребления 1",
                            OrganizationId = 1
                        },
                        new
                        {
                            Id = 5,
                            Address = "Empty address",
                            Name = "Объект потребления 1",
                            OrganizationId = 1
                        });
                });

            modelBuilder.Entity("Electricity.DAL.Entity.DeliveryPoint", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ConsumptionObjectId");

                    b.Property<int>("MaxPower");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("ConsumptionObjectId");

                    b.ToTable("DeliveryPoints");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ConsumptionObjectId = 1,
                            MaxPower = 100,
                            Name = "Точка поставки электроэнергии 1 "
                        },
                        new
                        {
                            Id = 2,
                            ConsumptionObjectId = 2,
                            MaxPower = 100,
                            Name = "Точка поставки электроэнергии 1 "
                        },
                        new
                        {
                            Id = 3,
                            ConsumptionObjectId = 3,
                            MaxPower = 100,
                            Name = "Точка поставки электроэнергии 1 "
                        },
                        new
                        {
                            Id = 4,
                            ConsumptionObjectId = 4,
                            MaxPower = 100,
                            Name = "Точка поставки электроэнергии 1 "
                        },
                        new
                        {
                            Id = 5,
                            ConsumptionObjectId = 4,
                            MaxPower = 100,
                            Name = "Точка поставки электроэнергии 1 "
                        });
                });

            modelBuilder.Entity("Electricity.DAL.Entity.DeliveryPointMeter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DeliveryPointId");

                    b.HasKey("Id");

                    b.HasIndex("DeliveryPointId");

                    b.ToTable("DeliveryPointMeters");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DeliveryPointId = 1
                        },
                        new
                        {
                            Id = 2,
                            DeliveryPointId = 2
                        },
                        new
                        {
                            Id = 3,
                            DeliveryPointId = 3
                        },
                        new
                        {
                            Id = 4,
                            DeliveryPointId = 4
                        },
                        new
                        {
                            Id = 5,
                            DeliveryPointId = 5
                        });
                });

            modelBuilder.Entity("Electricity.DAL.Entity.ElectricityMeter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ElectricityPointId");

                    b.Property<string>("Number");

                    b.Property<int?>("Type");

                    b.Property<DateTime?>("ValidationDate");

                    b.HasKey("Id");

                    b.HasIndex("ElectricityPointId")
                        .IsUnique()
                        .HasFilter("[ElectricityPointId] IS NOT NULL");

                    b.ToTable("ElectricityMeters");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ElectricityPointId = 1,
                            Number = "KakoitoNomer",
                            Type = 1,
                            ValidationDate = new DateTime(2012, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            ElectricityPointId = 2,
                            Number = "KakoitoNomer",
                            Type = 1,
                            ValidationDate = new DateTime(2017, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Electricity.DAL.Entity.ElectricityPoint", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ElectricityMeterId");

                    b.Property<int?>("ElectricityTransformatorId");

                    b.Property<string>("Name");

                    b.Property<int?>("ObjectId");

                    b.Property<int?>("VoltageTransformatorId");

                    b.HasKey("Id");

                    b.HasIndex("ObjectId");

                    b.ToTable("ElectricityPoints");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ElectricityMeterId = 1,
                            ElectricityTransformatorId = 1,
                            Name = "Hello I'm point",
                            VoltageTransformatorId = 1
                        },
                        new
                        {
                            Id = 2,
                            ElectricityMeterId = 2,
                            ElectricityTransformatorId = 2,
                            Name = "Hello I'm point",
                            VoltageTransformatorId = 2
                        });
                });

            modelBuilder.Entity("Electricity.DAL.Entity.ElectricityTransformator", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ElectricityPointId");

                    b.Property<int?>("KTT");

                    b.Property<string>("Number");

                    b.Property<int?>("Type");

                    b.Property<DateTime?>("ValidationDate");

                    b.HasKey("Id");

                    b.HasIndex("ElectricityPointId")
                        .IsUnique()
                        .HasFilter("[ElectricityPointId] IS NOT NULL");

                    b.ToTable("ElectricityTransformators");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ElectricityPointId = 1,
                            KTT = 12312,
                            Number = "123123123",
                            Type = 1,
                            ValidationDate = new DateTime(2012, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            ElectricityPointId = 2,
                            KTT = 12312,
                            Number = "123123123",
                            Type = 1,
                            ValidationDate = new DateTime(2017, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Electricity.DAL.Entity.Organization", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Organizations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Moscow",
                            Name = "Test"
                        },
                        new
                        {
                            Id = 2,
                            Address = "Moscow",
                            Name = "Test"
                        },
                        new
                        {
                            Id = 3,
                            Address = "Moscow",
                            Name = "Test"
                        });
                });

            modelBuilder.Entity("Electricity.DAL.Entity.VoltageTransformator", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ElectricityPointId");

                    b.Property<int?>("KTN");

                    b.Property<string>("Number");

                    b.Property<int?>("Type");

                    b.Property<DateTime?>("ValidationDate");

                    b.HasKey("Id");

                    b.HasIndex("ElectricityPointId")
                        .IsUnique()
                        .HasFilter("[ElectricityPointId] IS NOT NULL");

                    b.ToTable("VoltageTransformators");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ElectricityPointId = 1,
                            KTN = 123123,
                            Number = "123123",
                            Type = 1,
                            ValidationDate = new DateTime(2012, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            ElectricityPointId = 2,
                            KTN = 123123,
                            Number = "123123",
                            Type = 1,
                            ValidationDate = new DateTime(2017, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Electricity.DAL.Entity.ChildOrganization", b =>
                {
                    b.HasOne("Electricity.DAL.Entity.Organization", "Parent")
                        .WithMany("ChildOrganizations")
                        .HasForeignKey("ParentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Electricity.DAL.Entity.ConsumptionObject", b =>
                {
                    b.HasOne("Electricity.DAL.Entity.ChildOrganization", "Organization")
                        .WithMany("Objects")
                        .HasForeignKey("OrganizationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Electricity.DAL.Entity.DeliveryPoint", b =>
                {
                    b.HasOne("Electricity.DAL.Entity.ConsumptionObject", "ConsumptionObject")
                        .WithMany("DeliveryPoints")
                        .HasForeignKey("ConsumptionObjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Electricity.DAL.Entity.DeliveryPointMeter", b =>
                {
                    b.HasOne("Electricity.DAL.Entity.DeliveryPoint", "DeliveryPoint")
                        .WithMany("DeliveryPointMeters")
                        .HasForeignKey("DeliveryPointId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Electricity.DAL.Entity.ElectricityMeter", b =>
                {
                    b.HasOne("Electricity.DAL.Entity.ElectricityPoint", "ElectricityPoint")
                        .WithOne("ElectricityMeter")
                        .HasForeignKey("Electricity.DAL.Entity.ElectricityMeter", "ElectricityPointId");
                });

            modelBuilder.Entity("Electricity.DAL.Entity.ElectricityPoint", b =>
                {
                    b.HasOne("Electricity.DAL.Entity.ConsumptionObject", "Object")
                        .WithMany("Points")
                        .HasForeignKey("ObjectId");
                });

            modelBuilder.Entity("Electricity.DAL.Entity.ElectricityTransformator", b =>
                {
                    b.HasOne("Electricity.DAL.Entity.ElectricityPoint", "ElectricityPoint")
                        .WithOne("ElectricityTransformator")
                        .HasForeignKey("Electricity.DAL.Entity.ElectricityTransformator", "ElectricityPointId");
                });

            modelBuilder.Entity("Electricity.DAL.Entity.VoltageTransformator", b =>
                {
                    b.HasOne("Electricity.DAL.Entity.ElectricityPoint", "ElectricityPoint")
                        .WithOne("VoltageTransformator")
                        .HasForeignKey("Electricity.DAL.Entity.VoltageTransformator", "ElectricityPointId");
                });
#pragma warning restore 612, 618
        }
    }
}
