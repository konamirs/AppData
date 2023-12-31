﻿// <auto-generated />
using System;
using AppData.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AppData.Migrations
{
    [DbContext(typeof(ShopDBContext))]
    [Migration("20230807145157_number86")]
    partial class number86
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AppData.Models.Address", b =>
                {
                    b.Property<Guid>("AddressID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Commune")
                        .HasColumnType("nvarchar(200)");

                    b.Property<Guid>("CumstomerID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("District")
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Province")
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("AddressID");

                    b.HasIndex("CumstomerID");

                    b.ToTable("Address", (string)null);
                });

            modelBuilder.Entity("AppData.Models.Bill", b =>
                {
                    b.Property<Guid>("BillID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("BillCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("CancelDate")
                        .HasColumnType("Datetime");

                    b.Property<Guid>("CouponID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("Datetime");

                    b.Property<Guid>("CustomerID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DeliveryDate")
                        .HasColumnType("Datetime");

                    b.Property<Guid>("EmployeeID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)");

                    b.Property<decimal>("ShippingCosts")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime>("SuccessDate")
                        .HasColumnType("Datetime");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("VoucherID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("BillID");

                    b.HasIndex("CouponID");

                    b.HasIndex("CustomerID");

                    b.HasIndex("EmployeeID");

                    b.HasIndex("VoucherID");

                    b.ToTable("Bill", (string)null);
                });

            modelBuilder.Entity("AppData.Models.BillDetails", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BillID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<Guid>("ShoesDetailsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("BillID");

                    b.HasIndex("ShoesDetailsId");

                    b.ToTable("BillDetails", (string)null);
                });

            modelBuilder.Entity("AppData.Models.Cart", b =>
                {
                    b.Property<Guid>("CumstomerID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(300)");

                    b.HasKey("CumstomerID");

                    b.ToTable("Cart", (string)null);
                });

            modelBuilder.Entity("AppData.Models.CartDetails", b =>
                {
                    b.Property<Guid>("CartDetailsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CumstomerID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<Guid>("ShoesDetailsId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("CartDetailsId");

                    b.HasIndex("CumstomerID");

                    b.HasIndex("ShoesDetailsId");

                    b.ToTable("CartDetails", (string)null);
                });

            modelBuilder.Entity("AppData.Models.Color", b =>
                {
                    b.Property<Guid>("ColorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("ColorID");

                    b.ToTable("Color", (string)null);
                });

            modelBuilder.Entity("AppData.Models.Coupon", b =>
                {
                    b.Property<Guid>("CouponID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CouponCode")
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("CouponValue")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("Datetime");

                    b.Property<int>("MaxUsage")
                        .HasColumnType("int");

                    b.Property<int>("RemainingUsage")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("CouponID");

                    b.ToTable("Coupon", (string)null);
                });

            modelBuilder.Entity("AppData.Models.Customer", b =>
                {
                    b.Property<Guid>("CumstomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ResetPassword")
                        .HasColumnType("nvarchar(60)");

                    b.Property<int>("Sex")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("CumstomerID");

                    b.ToTable("Customer", (string)null);
                });

            modelBuilder.Entity("AppData.Models.Employee", b =>
                {
                    b.Property<Guid>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ResetPassword")
                        .HasColumnType("nvarchar(60)");

                    b.Property<Guid>("RoleID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Sex")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("EmployeeID");

                    b.HasIndex("RoleID");

                    b.ToTable("Employee", (string)null);
                });

            modelBuilder.Entity("AppData.Models.Image", b =>
                {
                    b.Property<Guid>("ImageID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Image1")
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Image2")
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Image3")
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Image4")
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(100)");

                    b.Property<Guid?>("ShoesDetailsID")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("ImageID");

                    b.HasIndex("ShoesDetailsID");

                    b.ToTable("Image", (string)null);
                });

            modelBuilder.Entity("AppData.Models.Product", b =>
                {
                    b.Property<string>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("ProductID");

                    b.ToTable("Product", (string)null);
                });

            modelBuilder.Entity("AppData.Models.Role", b =>
                {
                    b.Property<Guid>("RoleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("RoleName")
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("RoleID");

                    b.ToTable("Role", (string)null);
                });

            modelBuilder.Entity("AppData.Models.ShoesDetails", b =>
                {
                    b.Property<Guid>("ShoesDetailsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AvailableQuantity")
                        .HasColumnType("int");

                    b.Property<Guid?>("ColorID")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("Datetime");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(1000)");

                    b.Property<decimal>("ImportPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ProductID")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<Guid?>("SizeID")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("SoleID")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<Guid?>("StyleID")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("SupplierID")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ShoesDetailsId");

                    b.HasIndex("ColorID");

                    b.HasIndex("ProductID");

                    b.HasIndex("SizeID");

                    b.HasIndex("SoleID");

                    b.HasIndex("StyleID");

                    b.HasIndex("SupplierID");

                    b.ToTable("ShoesDetails", (string)null);
                });

            modelBuilder.Entity("AppData.Models.Size", b =>
                {
                    b.Property<Guid>("SizeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("SizeID");

                    b.ToTable("Size", (string)null);
                });

            modelBuilder.Entity("AppData.Models.Sole", b =>
                {
                    b.Property<Guid>("SoleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Fabric")
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Height")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("SoleID");

                    b.ToTable("Sole", (string)null);
                });

            modelBuilder.Entity("AppData.Models.Style", b =>
                {
                    b.Property<Guid>("StyleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("StyleID");

                    b.ToTable("Style", (string)null);
                });

            modelBuilder.Entity("AppData.Models.Supplier", b =>
                {
                    b.Property<Guid>("SupplierID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("SupplierID");

                    b.ToTable("Supplier", (string)null);
                });

            modelBuilder.Entity("AppData.Models.Voucher", b =>
                {
                    b.Property<Guid>("VoucherID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("Datetime");

                    b.Property<int>("MaxUsage")
                        .HasColumnType("int");

                    b.Property<int>("RemainingUsage")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("VoucherCode")
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("VoucherValue")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("VoucherID");

                    b.ToTable("Voucher", (string)null);
                });

            modelBuilder.Entity("AppData.Models.Address", b =>
                {
                    b.HasOne("AppData.Models.Customer", "Customer")
                        .WithMany("Addresses")
                        .HasForeignKey("CumstomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("AppData.Models.Bill", b =>
                {
                    b.HasOne("AppData.Models.Coupon", "Coupon")
                        .WithMany("Bills")
                        .HasForeignKey("CouponID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AppData.Models.Customer", "Customer")
                        .WithMany("Bills")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AppData.Models.Employee", "Employee")
                        .WithMany("Bills")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AppData.Models.Voucher", "Voucher")
                        .WithMany("Bills")
                        .HasForeignKey("VoucherID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Coupon");

                    b.Navigation("Customer");

                    b.Navigation("Employee");

                    b.Navigation("Voucher");
                });

            modelBuilder.Entity("AppData.Models.BillDetails", b =>
                {
                    b.HasOne("AppData.Models.Bill", "Bill")
                        .WithMany("BillDetails")
                        .HasForeignKey("BillID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AppData.Models.ShoesDetails", "ShoesDetails")
                        .WithMany("BillDetails")
                        .HasForeignKey("ShoesDetailsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bill");

                    b.Navigation("ShoesDetails");
                });

            modelBuilder.Entity("AppData.Models.Cart", b =>
                {
                    b.HasOne("AppData.Models.Customer", "Customer")
                        .WithOne("Cart")
                        .HasForeignKey("AppData.Models.Cart", "CumstomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("AppData.Models.CartDetails", b =>
                {
                    b.HasOne("AppData.Models.Cart", "Cart")
                        .WithMany("CartDetails")
                        .HasForeignKey("CumstomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AppData.Models.ShoesDetails", "ShoesDetails")
                        .WithMany("CartDetails")
                        .HasForeignKey("ShoesDetailsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cart");

                    b.Navigation("ShoesDetails");
                });

            modelBuilder.Entity("AppData.Models.Employee", b =>
                {
                    b.HasOne("AppData.Models.Role", "Role")
                        .WithMany("Employees")
                        .HasForeignKey("RoleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("AppData.Models.Image", b =>
                {
                    b.HasOne("AppData.Models.ShoesDetails", "ShoesDetails")
                        .WithMany("Images")
                        .HasForeignKey("ShoesDetailsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ShoesDetails");
                });

            modelBuilder.Entity("AppData.Models.ShoesDetails", b =>
                {
                    b.HasOne("AppData.Models.Color", "Color")
                        .WithMany("ShoesDetails")
                        .HasForeignKey("ColorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AppData.Models.Product", "Product")
                        .WithMany("ShoesDetails")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AppData.Models.Size", "Size")
                        .WithMany("ShoesDetails")
                        .HasForeignKey("SizeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AppData.Models.Sole", "Sole")
                        .WithMany("ShoesDetails")
                        .HasForeignKey("SoleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AppData.Models.Style", "Style")
                        .WithMany("ShoesDetails")
                        .HasForeignKey("StyleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AppData.Models.Supplier", "Supplier")
                        .WithMany("ShoesDetails")
                        .HasForeignKey("SupplierID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Color");

                    b.Navigation("Product");

                    b.Navigation("Size");

                    b.Navigation("Sole");

                    b.Navigation("Style");

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("AppData.Models.Bill", b =>
                {
                    b.Navigation("BillDetails");
                });

            modelBuilder.Entity("AppData.Models.Cart", b =>
                {
                    b.Navigation("CartDetails");
                });

            modelBuilder.Entity("AppData.Models.Color", b =>
                {
                    b.Navigation("ShoesDetails");
                });

            modelBuilder.Entity("AppData.Models.Coupon", b =>
                {
                    b.Navigation("Bills");
                });

            modelBuilder.Entity("AppData.Models.Customer", b =>
                {
                    b.Navigation("Addresses");

                    b.Navigation("Bills");

                    b.Navigation("Cart")
                        .IsRequired();
                });

            modelBuilder.Entity("AppData.Models.Employee", b =>
                {
                    b.Navigation("Bills");
                });

            modelBuilder.Entity("AppData.Models.Product", b =>
                {
                    b.Navigation("ShoesDetails");
                });

            modelBuilder.Entity("AppData.Models.Role", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("AppData.Models.ShoesDetails", b =>
                {
                    b.Navigation("BillDetails");

                    b.Navigation("CartDetails");

                    b.Navigation("Images");
                });

            modelBuilder.Entity("AppData.Models.Size", b =>
                {
                    b.Navigation("ShoesDetails");
                });

            modelBuilder.Entity("AppData.Models.Sole", b =>
                {
                    b.Navigation("ShoesDetails");
                });

            modelBuilder.Entity("AppData.Models.Style", b =>
                {
                    b.Navigation("ShoesDetails");
                });

            modelBuilder.Entity("AppData.Models.Supplier", b =>
                {
                    b.Navigation("ShoesDetails");
                });

            modelBuilder.Entity("AppData.Models.Voucher", b =>
                {
                    b.Navigation("Bills");
                });
#pragma warning restore 612, 618
        }
    }
}
