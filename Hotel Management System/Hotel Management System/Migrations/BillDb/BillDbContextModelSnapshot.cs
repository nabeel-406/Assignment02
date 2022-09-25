﻿// <auto-generated />
using System;
using Hotel_Management_System.Data_Access_Layer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Hotel_Management_System.Migrations.BillDb
{
    [DbContext(typeof(BillDbContext))]
    partial class BillDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Hotel_Management_System.Models.Bill", b =>
                {
                    b.Property<Guid>("BillId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("Amount")
                        .HasColumnType("real");

                    b.Property<DateTime>("BillDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("GuestId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("reservationId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("BillId");

                    b.HasIndex("GuestId");

                    b.HasIndex("reservationId");

                    b.ToTable("Bills");
                });

            modelBuilder.Entity("Hotel_Management_System.Models.Guest", b =>
                {
                    b.Property<Guid>("GuestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("GuestAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("GuestAdhaarCard")
                        .HasColumnType("bigint");

                    b.Property<int>("GuestAge")
                        .HasColumnType("int");

                    b.Property<string>("GuestEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GuestName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("GuestPhoneNumber")
                        .HasColumnType("bigint");

                    b.HasKey("GuestId");

                    b.ToTable("Guest");
                });

            modelBuilder.Entity("Hotel_Management_System.Models.Room", b =>
                {
                    b.Property<Guid>("RoomId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("room_comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("room_inventory")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("room_price")
                        .HasColumnType("real");

                    b.Property<bool>("room_status")
                        .HasColumnType("bit");

                    b.HasKey("RoomId");

                    b.ToTable("Room");
                });

            modelBuilder.Entity("Hotel_Management_System.Models.Room_Reservation", b =>
                {
                    b.Property<Guid>("reservationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Checkin_Time")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Checkout_Time")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("GuestId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("GuestId1")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("GuestsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Number_of_Guests")
                        .HasColumnType("int");

                    b.Property<Guid>("RoomId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("reservationId");

                    b.HasIndex("GuestId");

                    b.HasIndex("GuestId1");

                    b.ToTable("Room_Reservation");
                });

            modelBuilder.Entity("Hotel_Management_System.Models.Bill", b =>
                {
                    b.HasOne("Hotel_Management_System.Models.Guest", "guest")
                        .WithMany()
                        .HasForeignKey("GuestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hotel_Management_System.Models.Room_Reservation", "Room_Reservation")
                        .WithMany()
                        .HasForeignKey("reservationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Room_Reservation");

                    b.Navigation("guest");
                });

            modelBuilder.Entity("Hotel_Management_System.Models.Room_Reservation", b =>
                {
                    b.HasOne("Hotel_Management_System.Models.Room", "Room")
                        .WithMany()
                        .HasForeignKey("GuestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hotel_Management_System.Models.Guest", "Guest")
                        .WithMany()
                        .HasForeignKey("GuestId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Guest");

                    b.Navigation("Room");
                });
#pragma warning restore 612, 618
        }
    }
}
