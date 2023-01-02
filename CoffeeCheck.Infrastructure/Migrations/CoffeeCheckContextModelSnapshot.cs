﻿// <auto-generated />
using System;
using CoffeeCheck.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CoffeeCheck.Infrastructure.Migrations
{
    [DbContext(typeof(CoffeeCheckContext))]
    partial class CoffeeCheckContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("CoffeeCheck.Domain.Restaurant.Entities.CandyRatingEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<double>("CandyRating")
                        .HasColumnType("double precision");

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
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClientChoice")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("CoffeeRating")
                        .HasColumnType("double precision");

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
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClientChoice")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("FoodRating")
                        .HasColumnType("double precision");

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

                    b.HasKey("Id");

                    b.ToTable("MainPicture");
                });

            modelBuilder.Entity("CoffeeCheck.Domain.Restaurant.Entities.OverallRatingEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

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

                    b.Property<Guid>("MainPictureId")
                        .HasColumnType("uuid");

                    b.Property<string>("RestaurantName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("YandexLatitude")
                        .HasColumnType("double precision");

                    b.Property<double>("YandexLongitude")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("MainPictureId")
                        .IsUnique();

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

                    b.HasOne("CoffeeCheck.Domain.Restaurant.Entities.MainPictureEntity", "MainPicture")
                        .WithOne("Restaurant")
                        .HasForeignKey("CoffeeCheck.Domain.Restaurant.Entities.RestaurantEntity", "MainPictureId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");

                    b.Navigation("MainPicture");
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

            modelBuilder.Entity("CoffeeCheck.Domain.Restaurant.Entities.MainPictureEntity", b =>
                {
                    b.Navigation("Restaurant")
                        .IsRequired();
                });

            modelBuilder.Entity("CoffeeCheck.Domain.Restaurant.Entities.RestaurantEntity", b =>
                {
                    b.Navigation("CandyRating")
                        .IsRequired();

                    b.Navigation("CoffeeRating")
                        .IsRequired();

                    b.Navigation("FoodRating")
                        .IsRequired();

                    b.Navigation("OverallRating")
                        .IsRequired();

                    b.Navigation("RestaurantPicture");
                });
#pragma warning restore 612, 618
        }
    }
}
