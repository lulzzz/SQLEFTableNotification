﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SQLEFTableNotification.Entity.Context;
using System;

namespace SQLEFTableNotification.Entity.Migrations
{
    [DbContext(typeof(SQLEFTableNotificationContext))]
    [Migration("20180708205028_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-rtm-30799")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SQLEFTableNotification.Entity.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created");

                    b.Property<string>("Description")
                        .HasMaxLength(255);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsTrial");

                    b.Property<DateTime>("Modified");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<DateTime>("SetActive");

                    b.Property<byte[]>("RowVersion")
                    .IsConcurrencyToken()
                    .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("SQLEFTableNotification.Entity.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccountId");

                    b.Property<DateTime>("Created");

                    b.Property<string>("Description")
                        .HasMaxLength(255);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsAdminRole");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<DateTime>("Modified");

                    b.Property<string>("Password")
                        .HasMaxLength(50);

                    b.Property<string>("Roles")
                        .HasMaxLength(255);

                    b.Property<byte[]>("RowVersion")
                    .IsConcurrencyToken()
                    .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("UserName")
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("SQLEFTableNotification.Entity.User", b =>
                {
                    b.HasOne("SQLEFTableNotification.Entity.Account", "Account")
                        .WithMany("Users")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
