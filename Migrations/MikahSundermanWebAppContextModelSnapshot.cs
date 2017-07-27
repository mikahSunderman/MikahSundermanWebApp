using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using MikahSundermanWebApp.Models;

namespace MikahSundermanWebApp.Migrations
{
    [DbContext(typeof(MikahSundermanWebAppContext))]
    partial class MikahSundermanWebAppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1");

            modelBuilder.Entity("MikahSundermanWebApp.Models.Education", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("GraduationDate");

                    b.Property<string>("Location");

                    b.Property<string>("Major");

                    b.Property<string>("Minor");

                    b.Property<string>("University")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("Education");
                });

            modelBuilder.Entity("MikahSundermanWebApp.Models.FrameworkAPI", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Framework")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("FrameworkAPI");
                });

            modelBuilder.Entity("MikahSundermanWebApp.Models.ProgrammingLanguage", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Language")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("ProgrammingLanguage");
                });

            modelBuilder.Entity("MikahSundermanWebApp.Models.WorkExperience", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Employer");

                    b.Property<DateTime>("EndDate");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<DateTime>("StartDate");

                    b.HasKey("ID");

                    b.ToTable("WorkExperience");
                });
        }
    }
}
