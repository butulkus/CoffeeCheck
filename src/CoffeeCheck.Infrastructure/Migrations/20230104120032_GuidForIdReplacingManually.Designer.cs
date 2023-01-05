﻿// <auto-generated />
using System;
using CoffeeCheck.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CoffeeCheck.Infrastructure.Migrations
{
    [DbContext(typeof(CoffeeCheckContext))]
    [Migration("20230104120032_GuidForIdReplacingManually")]
    partial class GuidForIdReplacingManually
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("CoffeeCheck.Domain.Restaurant.Entities.CandyRatingEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasDefaultValueSql("gen_random_uuid()");

                    b.Property<decimal>("CandyRating")
                        .HasColumnType("numeric(4,2)");

                    b.Property<int>("CandyVotesQuantity")
                        .HasColumnType("integer");

                    b.Property<string>("ClientChoice")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("RestaurantId")
                        .HasColumnType("uuid");

                    b.Property<string>("Restaurant_Choice")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RestaurantId")
                        .IsUnique();

                    b.ToTable("CandyRating");
                });

            modelBuilder.Entity("CoffeeCheck.Domain.Restaurant.Entities.CityEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("City");
                });

            modelBuilder.Entity("CoffeeCheck.Domain.Restaurant.Entities.CoffeeRatingEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasDefaultValueSql("gen_random_uuid()");

                    b.Property<string>("ClientChoice")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("CoffeeRating")
                        .HasColumnType("numeric(4,2)");

                    b.Property<int>("CoffeeVotesQuantity")
                        .HasColumnType("integer");

                    b.Property<Guid>("RestaurantId")
                        .HasColumnType("uuid");

                    b.Property<string>("Restaurant_Choice")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RestaurantId")
                        .IsUnique();

                    b.ToTable("CoffeeRating");
                });

            modelBuilder.Entity("CoffeeCheck.Domain.Restaurant.Entities.FoodRatingEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasDefaultValueSql("gen_random_uuid()");

                    b.Property<string>("ClientChoice")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("FoodRating")
                        .HasColumnType("numeric(4,2)");

                    b.Property<int>("FoodVotesQuantity")
                        .HasColumnType("integer");

                    b.Property<Guid>("RestaurantId")
                        .HasColumnType("uuid");

                    b.Property<string>("Restaurant_Choice")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RestaurantId")
                        .IsUnique();

                    b.ToTable("FoodRating");
                });

            modelBuilder.Entity("CoffeeCheck.Domain.Restaurant.Entities.MainPictureEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasDefaultValueSql("gen_random_uuid()");

                    b.Property<string>("Format")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<byte[]>("Picture")
                        .IsRequired()
                        .HasColumnType("bytea");

                    b.Property<Guid>("RestaurantId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("RestaurantId")
                        .IsUnique();

                    b.ToTable("MainPicture");
                });

            modelBuilder.Entity("CoffeeCheck.Domain.Restaurant.Entities.OverallRatingEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasDefaultValueSql("gen_random_uuid()");

                    b.Property<decimal>("OverallRating")
                        .HasColumnType("numeric(4,2)");

                    b.Property<Guid>("RestaurantId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("RestaurantId")
                        .IsUnique();

                    b.ToTable("OverallRating");
                });

            modelBuilder.Entity("CoffeeCheck.Domain.Restaurant.Entities.RestaurantEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasDefaultValueSql("gen_random_uuid()");

                    b.Property<int>("CityId")
                        .HasColumnType("integer");

                    b.Property<string>("RestaurantName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("YandexLatitude")
                        .HasColumnType("numeric(38,17)");

                    b.Property<decimal>("YandexLongitude")
                        .HasColumnType("numeric(38,17)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Restaurant");
                });

            modelBuilder.Entity("CoffeeCheck.Domain.Restaurant.Entities.RestaurantPictureEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasDefaultValueSql("gen_random_uuid()");

                    b.Property<string>("Format")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<byte[]>("Picture")
                        .IsRequired()
                        .HasColumnType("bytea");

                    b.Property<Guid>("RestaurantId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("RestaurantId");

                    b.ToTable("RestaurantPicture");
                });

            modelBuilder.Entity("CoffeeCheck.Domain.Restaurant.Entities.CandyRatingEntity", b =>
                {
                    b.HasOne("CoffeeCheck.Domain.Restaurant.Entities.RestaurantEntity", "Restaurant")
                        .WithOne("CandyRating")
                        .HasForeignKey("CoffeeCheck.Domain.Restaurant.Entities.CandyRatingEntity", "RestaurantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Restaurant");
                });

            modelBuilder.Entity("CoffeeCheck.Domain.Restaurant.Entities.CoffeeRatingEntity", b =>
                {
                    b.HasOne("CoffeeCheck.Domain.Restaurant.Entities.RestaurantEntity", "Restaurant")
                        .WithOne("CoffeeRating")
                        .HasForeignKey("CoffeeCheck.Domain.Restaurant.Entities.CoffeeRatingEntity", "RestaurantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Restaurant");
                });

            modelBuilder.Entity("CoffeeCheck.Domain.Restaurant.Entities.FoodRatingEntity", b =>
                {
                    b.HasOne("CoffeeCheck.Domain.Restaurant.Entities.RestaurantEntity", "Restaurant")
                        .WithOne("FoodRating")
                        .HasForeignKey("CoffeeCheck.Domain.Restaurant.Entities.FoodRatingEntity", "RestaurantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Restaurant");
                });

            modelBuilder.Entity("CoffeeCheck.Domain.Restaurant.Entities.MainPictureEntity", b =>
                {
                    b.HasOne("CoffeeCheck.Domain.Restaurant.Entities.RestaurantEntity", "Restaurant")
                        .WithOne("MainPicture")
                        .HasForeignKey("CoffeeCheck.Domain.Restaurant.Entities.MainPictureEntity", "RestaurantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Restaurant");
                });

            modelBuilder.Entity("CoffeeCheck.Domain.Restaurant.Entities.OverallRatingEntity", b =>
                {
                    b.HasOne("CoffeeCheck.Domain.Restaurant.Entities.RestaurantEntity", "Restaurant")
                        .WithOne("OverallRating")
                        .HasForeignKey("CoffeeCheck.Domain.Restaurant.Entities.OverallRatingEntity", "RestaurantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Restaurant");
                });

            modelBuilder.Entity("CoffeeCheck.Domain.Restaurant.Entities.RestaurantEntity", b =>
                {
                    b.HasOne("CoffeeCheck.Domain.Restaurant.Entities.CityEntity", "City")
                        .WithMany("Restaurants")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("CoffeeCheck.Domain.Restaurant.Entities.RestaurantPictureEntity", b =>
                {
                    b.HasOne("CoffeeCheck.Domain.Restaurant.Entities.RestaurantEntity", "Restaurant")
                        .WithMany("RestaurantPicture")
                        .HasForeignKey("RestaurantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Restaurant");
                });

            modelBuilder.Entity("CoffeeCheck.Domain.Restaurant.Entities.CityEntity", b =>
                {
                    b.Navigation("Restaurants");
                });

            modelBuilder.Entity("CoffeeCheck.Domain.Restaurant.Entities.RestaurantEntity", b =>
                {
                    b.Navigation("CandyRating")
                        .IsRequired();

                    b.Navigation("CoffeeRating")
                        .IsRequired();

                    b.Navigation("FoodRating")
                        .IsRequired();

                    b.Navigation("MainPicture")
                        .IsRequired();

                    b.Navigation("OverallRating")
                        .IsRequired();

                    b.Navigation("RestaurantPicture");
                });
#pragma warning restore 612, 618
        }
    }
}