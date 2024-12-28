﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _0004DemoMVC.Models;

#nullable disable

namespace _0004DemoMVC.Migrations
{
    [DbContext(typeof(MyDB))]
    partial class MyDBModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("_0004DemoMVC.Models.Emp", b =>
                {
                    b.Property<int>("No")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("No");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("No"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Address");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Name");

                    b.HasKey("No");

                    b.ToTable("Emp");
                });

            modelBuilder.Entity("_0004DemoMVC.Models.Subject", b =>
                {
                    b.Property<int>("SubjectID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("SubjectID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubjectID"), 1L, 1);

                    b.Property<string>("SubjectTitle")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("SubjectTitle");

                    b.HasKey("SubjectID");

                    b.ToTable("Subject");
                });

            modelBuilder.Entity("_0004DemoMVC.Models.Trainer", b =>
                {
                    b.Property<int>("TrainerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("TrainerID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TrainerID"), 1L, 1);

                    b.Property<string>("TrainerName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("TrainerName");

                    b.HasKey("TrainerID");

                    b.ToTable("Trainer");
                });

            modelBuilder.Entity("SubjectTrainer", b =>
                {
                    b.Property<int>("SubjectsSubjectID")
                        .HasColumnType("int");

                    b.Property<int>("TrainersTrainerID")
                        .HasColumnType("int");

                    b.HasKey("SubjectsSubjectID", "TrainersTrainerID");

                    b.HasIndex("TrainersTrainerID");

                    b.ToTable("SubjectTrainer");
                });

            modelBuilder.Entity("SubjectTrainer", b =>
                {
                    b.HasOne("_0004DemoMVC.Models.Subject", null)
                        .WithMany()
                        .HasForeignKey("SubjectsSubjectID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_0004DemoMVC.Models.Trainer", null)
                        .WithMany()
                        .HasForeignKey("TrainersTrainerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
