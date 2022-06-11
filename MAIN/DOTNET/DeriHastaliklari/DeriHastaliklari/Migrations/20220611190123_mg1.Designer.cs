﻿// <auto-generated />
using DeriHastaliklari.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DeriHastaliklari.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220611190123_mg1")]
    partial class mg1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DeriHastaliklari.Models.AddPhoto", b =>
                {
                    b.Property<int>("ImageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Additional")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cont")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Itch")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pain")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.HasKey("ImageId");

                    b.HasIndex("PatientId")
                        .IsUnique();

                    b.ToTable("AddPhoto");
                });

            modelBuilder.Entity("DeriHastaliklari.Models.Doctor", b =>
                {
                    b.Property<int>("DoctorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Password")
                        .HasColumnType("Varchar(20)");

                    b.Property<string>("Username")
                        .HasColumnType("Varchar(20)");

                    b.HasKey("DoctorID");

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("DeriHastaliklari.Models.Patient", b =>
                {
                    b.Property<int>("PatientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Allergy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Disease")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Medicine")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TcNo")
                        .HasColumnType("int");

                    b.Property<string>("bthDay")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PatientId");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("DeriHastaliklari.Models.AddPhoto", b =>
                {
                    b.HasOne("DeriHastaliklari.Models.Patient", "Patient")
                        .WithOne("AddPhoto")
                        .HasForeignKey("DeriHastaliklari.Models.AddPhoto", "PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("DeriHastaliklari.Models.Patient", b =>
                {
                    b.Navigation("AddPhoto");
                });
#pragma warning restore 612, 618
        }
    }
}
