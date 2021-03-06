﻿// <auto-generated />
using BankAcc.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BankAcc.API.Migrations
{
    [DbContext(typeof(APIDBContext))]
    [Migration("20200815150627_InitialDB")]
    partial class InitialDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BankAccount.API.Models.Bank", b =>
                {
                    b.Property<int>("BankID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BankName")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("BankID");

                    b.ToTable("Banks");
                });

            modelBuilder.Entity("BankAccount.API.Models.BankAccount", b =>
                {
                    b.Property<int>("BankAccountID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AccountHolder")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("AccountNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("BankID");

                    b.Property<string>("IFSC")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("BankAccountID");

                    b.ToTable("BankAccounts");
                });
#pragma warning restore 612, 618
        }
    }
}
