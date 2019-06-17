﻿// <auto-generated />

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microting.eFormBaseCustomerBase.Infrastructure.Data;

namespace Microting.eFormBaseCustomerBase.Infrastructure.Migrations
{
    [DbContext(typeof(CustomersPnDbAnySql))]
    [Migration("20190328184630_AddNewBaseEntity")]
    partial class AddNewBaseEntity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            string autoIdGenStrategy = "SqlServer:ValueGenerationStrategy";
            object autoIdGenStrategyValue = SqlServerValueGenerationStrategy.IdentityColumn;
            if (DbConfig.IsMySQL)
            {
                autoIdGenStrategy = "MySql:ValueGenerationStrategy";
                autoIdGenStrategyValue = MySqlValueGenerationStrategy.IdentityColumn;
            }

            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation(autoIdGenStrategy, autoIdGenStrategyValue);

            modelBuilder.Entity("Customers.Pn.Infrastructure.Data.Entities.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation(autoIdGenStrategy, autoIdGenStrategyValue);

                    b.Property<string>("CityName")
                        .HasMaxLength(250);

                    b.Property<string>("CompanyAddress")
                        .HasMaxLength(250);

                    b.Property<string>("CompanyName")
                        .HasMaxLength(250);

                    b.Property<string>("ContactPerson")
                        .HasMaxLength(250);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(250);

                    b.Property<int>("CreatedByUserId");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int>("Created_By_User_Id");

                    b.Property<DateTime?>("Created_at");

                    b.Property<string>("CustomerNo");

                    b.Property<string>("Description");

                    b.Property<string>("Email")
                        .HasMaxLength(250);

                    b.Property<string>("Phone")
                        .HasMaxLength(250);

                    b.Property<int?>("RelatedEntityId");

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<int>("UpdatedByUserId");

                    b.Property<int>("Updated_By_User_Id");

                    b.Property<DateTime?>("Updated_at");

                    b.Property<int>("Version");

                    b.Property<string>("WorkflowState")
                        .HasMaxLength(255);

                    b.Property<string>("Workflow_state")
                        .HasMaxLength(255);

                    b.Property<string>("ZipCode")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("RelatedEntityId")
                        .IsUnique()
                        .HasFilter("[RelatedEntityId] IS NOT NULL");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Customers.Pn.Infrastructure.Data.Entities.CustomerField", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation(autoIdGenStrategy, autoIdGenStrategyValue);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("CreatedByUserId");

                    b.Property<int>("FieldId");

                    b.Property<short?>("FieldStatus");

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<int>("UpdatedByUserId");

                    b.Property<int>("Version");

                    b.Property<string>("WorkflowState")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("FieldId");

                    b.ToTable("CustomerFields");
                });

            modelBuilder.Entity("Customers.Pn.Infrastructure.Data.Entities.CustomerVersion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation(autoIdGenStrategy, autoIdGenStrategyValue);

                    b.Property<string>("CityName")
                        .HasMaxLength(250);

                    b.Property<string>("CompanyAddress")
                        .HasMaxLength(250);

                    b.Property<string>("CompanyName")
                        .HasMaxLength(250);

                    b.Property<string>("ContactPerson")
                        .HasMaxLength(250);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(250);

                    b.Property<int>("CreatedByUserId");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int>("Created_By_User_Id");

                    b.Property<DateTime?>("Created_at");

                    b.Property<int>("CustomerId");

                    b.Property<string>("CustomerNo");

                    b.Property<string>("Description");

                    b.Property<string>("Email")
                        .HasMaxLength(250);

                    b.Property<string>("Phone")
                        .HasMaxLength(250);

                    b.Property<int?>("RelatedEntityId");

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<int>("UpdatedByUserId");

                    b.Property<int>("Updated_By_User_Id");

                    b.Property<DateTime?>("Updated_at");

                    b.Property<int>("Version");

                    b.Property<string>("WorkflowState")
                        .HasMaxLength(255);

                    b.Property<string>("Workflow_state")
                        .HasMaxLength(255);

                    b.Property<string>("ZipCode")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("CustomerVersions");
                });

            modelBuilder.Entity("Customers.Pn.Infrastructure.Data.Entities.Field", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation(autoIdGenStrategy, autoIdGenStrategyValue);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("CreatedByUserId");

                    b.Property<string>("Name")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<int>("UpdatedByUserId");

                    b.Property<int>("Version");

                    b.Property<string>("WorkflowState")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("Name");

                    b.ToTable("Fields");
                });

            modelBuilder.Entity("Customers.Pn.Infrastructure.Data.Entities.CustomerField", b =>
                {
                    b.HasOne("Customers.Pn.Infrastructure.Data.Entities.Field", "Field")
                        .WithMany()
                        .HasForeignKey("FieldId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
