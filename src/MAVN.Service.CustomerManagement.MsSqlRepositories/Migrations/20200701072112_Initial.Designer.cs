﻿// <auto-generated />
using System;
using MAVN.Service.CustomerManagement.MsSqlRepositories.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace MAVN.Service.CustomerManagement.MsSqlRepositories.Migrations
{
    [DbContext(typeof(CmContext))]
    [Migration("20200701072112_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("customer_management")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("MAVN.Service.CustomerManagement.MsSqlRepositories.Entities.CustomerFlagsEntity", b =>
                {
                    b.Property<string>("CustomerId")
                        .HasColumnName("customer_id")
                        .HasColumnType("text");

                    b.Property<bool>("IsBlocked")
                        .HasColumnName("is_blocked")
                        .HasColumnType("boolean");

                    b.HasKey("CustomerId");

                    b.ToTable("customer_flags");
                });

            modelBuilder.Entity("MAVN.Service.CustomerManagement.MsSqlRepositories.Entities.CustomerRegistrationReferralDataEntity", b =>
                {
                    b.Property<string>("CustomerId")
                        .HasColumnName("customer_id")
                        .HasColumnType("text");

                    b.Property<string>("ReferralCode")
                        .IsRequired()
                        .HasColumnName("referral_code")
                        .HasColumnType("text");

                    b.HasKey("CustomerId");

                    b.ToTable("customers_registration_referral_data");
                });

            modelBuilder.Entity("MAVN.Service.CustomerManagement.MsSqlRepositories.Entities.EmailVerificationCodeEntity", b =>
                {
                    b.Property<string>("CustomerId")
                        .HasColumnName("customer_id")
                        .HasColumnType("text");

                    b.Property<DateTime>("ExpireDate")
                        .HasColumnName("expire_date")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsVerified")
                        .HasColumnName("is_verified")
                        .HasColumnType("boolean");

                    b.Property<string>("VerificationCode")
                        .IsRequired()
                        .HasColumnName("code")
                        .HasColumnType("text");

                    b.HasKey("CustomerId");

                    b.HasIndex("VerificationCode")
                        .IsUnique();

                    b.ToTable("email_verification_codes");
                });

            modelBuilder.Entity("MAVN.Service.CustomerManagement.MsSqlRepositories.Entities.PhoneVerificationCodeEntity", b =>
                {
                    b.Property<string>("CustomerId")
                        .HasColumnName("customer_id")
                        .HasColumnType("text");

                    b.Property<DateTime>("ExpireDate")
                        .HasColumnName("expire_date")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("VerificationCode")
                        .IsRequired()
                        .HasColumnName("code")
                        .HasColumnType("text");

                    b.HasKey("CustomerId");

                    b.HasIndex("CustomerId", "VerificationCode")
                        .IsUnique();

                    b.ToTable("phone_verification_codes");
                });
#pragma warning restore 612, 618
        }
    }
}
