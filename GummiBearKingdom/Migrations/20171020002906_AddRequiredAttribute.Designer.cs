﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using GummiBearKingdom.Models;

namespace GummiBearKingdom.Migrations
{
    [DbContext(typeof(GummiBearKingdomContext))]
    [Migration("20171020002906_AddRequiredAttribute")]
    partial class AddRequiredAttribute
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2");

            modelBuilder.Entity("GummiBearKingdom.Models.Country", b =>
                {
                    b.Property<int>("CountryId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("CountryId");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("GummiBearKingdom.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Cost")
                        .IsRequired();

                    b.Property<int>("CountryId");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("ProductId");

                    b.HasIndex("CountryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("GummiBearKingdom.Models.Product", b =>
                {
                    b.HasOne("GummiBearKingdom.Models.Country", "Country")
                        .WithMany("Products")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
