﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WaterLog_Backend.Models;

namespace WaterLog_Backend.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20190208123451_migration7")]
    partial class migration7
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WaterLog_Backend.Models.LocationSegmentsEntry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("LocationId");

                    b.Property<int>("SegmentId");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.HasIndex("SegmentId");

                    b.ToTable("LocationSegments");
                });

            modelBuilder.Entity("WaterLog_Backend.Models.LocationsEntry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Lat");

                    b.Property<double>("Long");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("WaterLog_Backend.Models.MonitorsEntry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Lat");

                    b.Property<double>("Long");

                    b.Property<double>("Max_flow");

                    b.Property<string>("Status");

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.ToTable("Monitors");
                });

            modelBuilder.Entity("WaterLog_Backend.Models.ReadingsEntry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MonitorsId");

                    b.Property<DateTime>("TimesStamp");

                    b.Property<double>("Value");

                    b.HasKey("Id");

                    b.ToTable("Readings");
                });

            modelBuilder.Entity("WaterLog_Backend.Models.SegmentEventsEntry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EventType");

                    b.Property<double>("FlowIn");

                    b.Property<double>("FlowOut");

                    b.Property<int>("SegmentsId");

                    b.Property<DateTime>("TimeStamp");

                    b.HasKey("Id");

                    b.ToTable("SegmentEvents");
                });

            modelBuilder.Entity("WaterLog_Backend.Models.SegmentLeaksEntry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("LatestTimeStamp");

                    b.Property<DateTime>("OriginalTimeStamp");

                    b.Property<string>("ResolvedStatus");

                    b.Property<int>("SegmentsId");

                    b.Property<string>("Severity");

                    b.HasKey("Id");

                    b.ToTable("SegmentLeaks");
                });

            modelBuilder.Entity("WaterLog_Backend.Models.SegmentsEntry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("SenseIDIn");

                    b.Property<int>("SenseIDOut");

                    b.HasKey("Id");

                    b.ToTable("Segments");
                });

            modelBuilder.Entity("WaterLog_Backend.Models.LocationSegmentsEntry", b =>
                {
                    b.HasOne("WaterLog_Backend.Models.LocationsEntry", "LocationsEntry")
                        .WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WaterLog_Backend.Models.SegmentsEntry", "segmentsEntry")
                        .WithMany()
                        .HasForeignKey("SegmentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
