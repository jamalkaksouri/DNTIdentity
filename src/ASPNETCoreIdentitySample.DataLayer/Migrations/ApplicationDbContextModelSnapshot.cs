﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using ASPNETCoreIdentitySample.DataLayer.Context;

namespace ASPNETCoreIdentitySample.DataLayer.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ASPNETCoreIdentitySample.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedByBrowserName")
                        .HasMaxLength(1000);

                    b.Property<string>("CreatedByIp")
                        .HasMaxLength(255);

                    b.Property<int?>("CreatedByUserId");

                    b.Property<DateTimeOffset?>("CreatedDateTime");

                    b.Property<string>("ModifiedByBrowserName")
                        .HasMaxLength(1000);

                    b.Property<string>("ModifiedByIp")
                        .HasMaxLength(255);

                    b.Property<int?>("ModifiedByUserId");

                    b.Property<DateTimeOffset?>("ModifiedDateTime");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(450);

                    b.Property<string>("Title")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("ASPNETCoreIdentitySample.Entities.Identity.AppLogItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedByBrowserName")
                        .HasMaxLength(1000);

                    b.Property<string>("CreatedByIp")
                        .HasMaxLength(255);

                    b.Property<int?>("CreatedByUserId");

                    b.Property<DateTimeOffset?>("CreatedDateTime");

                    b.Property<int>("EventId");

                    b.Property<string>("LogLevel");

                    b.Property<string>("Logger");

                    b.Property<string>("Message");

                    b.Property<string>("ModifiedByBrowserName")
                        .HasMaxLength(1000);

                    b.Property<string>("ModifiedByIp")
                        .HasMaxLength(255);

                    b.Property<int?>("ModifiedByUserId");

                    b.Property<DateTimeOffset?>("ModifiedDateTime");

                    b.Property<string>("StateJson");

                    b.Property<string>("Url");

                    b.HasKey("Id");

                    b.ToTable("AppLogItems");
                });

            modelBuilder.Entity("ASPNETCoreIdentitySample.Entities.Identity.AppSqlCache", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(449);

                    b.Property<DateTimeOffset?>("AbsoluteExpiration");

                    b.Property<DateTimeOffset>("ExpiresAtTime");

                    b.Property<long?>("SlidingExpirationInSeconds");

                    b.Property<byte[]>("Value")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("ExpiresAtTime")
                        .HasName("Index_ExpiresAtTime");

                    b.ToTable("AppSqlCache","dbo");
                });

            modelBuilder.Entity("ASPNETCoreIdentitySample.Entities.Identity.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("CreatedByBrowserName")
                        .HasMaxLength(1000);

                    b.Property<string>("CreatedByIp")
                        .HasMaxLength(255);

                    b.Property<int?>("CreatedByUserId");

                    b.Property<DateTimeOffset?>("CreatedDateTime");

                    b.Property<string>("Description");

                    b.Property<string>("ModifiedByBrowserName")
                        .HasMaxLength(1000);

                    b.Property<string>("ModifiedByIp")
                        .HasMaxLength(255);

                    b.Property<int?>("ModifiedByUserId");

                    b.Property<DateTimeOffset?>("ModifiedDateTime");

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AppRoles");
                });

            modelBuilder.Entity("ASPNETCoreIdentitySample.Entities.Identity.RoleClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("CreatedByBrowserName")
                        .HasMaxLength(1000);

                    b.Property<string>("CreatedByIp")
                        .HasMaxLength(255);

                    b.Property<int?>("CreatedByUserId");

                    b.Property<DateTimeOffset?>("CreatedDateTime");

                    b.Property<string>("ModifiedByBrowserName")
                        .HasMaxLength(1000);

                    b.Property<string>("ModifiedByIp")
                        .HasMaxLength(255);

                    b.Property<int?>("ModifiedByUserId");

                    b.Property<DateTimeOffset?>("ModifiedDateTime");

                    b.Property<int>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AppRoleClaims");
                });

            modelBuilder.Entity("ASPNETCoreIdentitySample.Entities.Identity.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<DateTimeOffset?>("BirthDate");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("CreatedByBrowserName")
                        .HasMaxLength(1000);

                    b.Property<string>("CreatedByIp")
                        .HasMaxLength(255);

                    b.Property<int?>("CreatedByUserId");

                    b.Property<DateTimeOffset?>("CreatedDateTime");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName")
                        .HasMaxLength(450);

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsEmailPublic");

                    b.Property<string>("LastName")
                        .HasMaxLength(450);

                    b.Property<DateTimeOffset?>("LastVisitDateTime");

                    b.Property<string>("Location");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("ModifiedByBrowserName")
                        .HasMaxLength(1000);

                    b.Property<string>("ModifiedByIp")
                        .HasMaxLength(255);

                    b.Property<int?>("ModifiedByUserId");

                    b.Property<DateTimeOffset?>("ModifiedDateTime");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("PhotoFileName")
                        .HasMaxLength(450);

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AppUsers");
                });

            modelBuilder.Entity("ASPNETCoreIdentitySample.Entities.Identity.UserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("CreatedByBrowserName")
                        .HasMaxLength(1000);

                    b.Property<string>("CreatedByIp")
                        .HasMaxLength(255);

                    b.Property<int?>("CreatedByUserId");

                    b.Property<DateTimeOffset?>("CreatedDateTime");

                    b.Property<string>("ModifiedByBrowserName")
                        .HasMaxLength(1000);

                    b.Property<string>("ModifiedByIp")
                        .HasMaxLength(255);

                    b.Property<int?>("ModifiedByUserId");

                    b.Property<DateTimeOffset?>("ModifiedDateTime");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AppUserClaims");
                });

            modelBuilder.Entity("ASPNETCoreIdentitySample.Entities.Identity.UserLogin", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("CreatedByBrowserName")
                        .HasMaxLength(1000);

                    b.Property<string>("CreatedByIp")
                        .HasMaxLength(255);

                    b.Property<int?>("CreatedByUserId");

                    b.Property<DateTimeOffset?>("CreatedDateTime");

                    b.Property<string>("ModifiedByBrowserName")
                        .HasMaxLength(1000);

                    b.Property<string>("ModifiedByIp")
                        .HasMaxLength(255);

                    b.Property<int?>("ModifiedByUserId");

                    b.Property<DateTimeOffset?>("ModifiedDateTime");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<int>("UserId");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AppUserLogins");
                });

            modelBuilder.Entity("ASPNETCoreIdentitySample.Entities.Identity.UserRole", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<int>("RoleId");

                    b.Property<string>("CreatedByBrowserName")
                        .HasMaxLength(1000);

                    b.Property<string>("CreatedByIp")
                        .HasMaxLength(255);

                    b.Property<int?>("CreatedByUserId");

                    b.Property<DateTimeOffset?>("CreatedDateTime");

                    b.Property<string>("ModifiedByBrowserName")
                        .HasMaxLength(1000);

                    b.Property<string>("ModifiedByIp")
                        .HasMaxLength(255);

                    b.Property<int?>("ModifiedByUserId");

                    b.Property<DateTimeOffset?>("ModifiedDateTime");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AppUserRoles");
                });

            modelBuilder.Entity("ASPNETCoreIdentitySample.Entities.Identity.UserToken", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("CreatedByBrowserName")
                        .HasMaxLength(1000);

                    b.Property<string>("CreatedByIp")
                        .HasMaxLength(255);

                    b.Property<int?>("CreatedByUserId");

                    b.Property<DateTimeOffset?>("CreatedDateTime");

                    b.Property<string>("ModifiedByBrowserName")
                        .HasMaxLength(1000);

                    b.Property<string>("ModifiedByIp")
                        .HasMaxLength(255);

                    b.Property<int?>("ModifiedByUserId");

                    b.Property<DateTimeOffset?>("ModifiedDateTime");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AppUserTokens");
                });

            modelBuilder.Entity("ASPNETCoreIdentitySample.Entities.Identity.UserUsedPassword", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedByBrowserName")
                        .HasMaxLength(1000);

                    b.Property<string>("CreatedByIp")
                        .HasMaxLength(255);

                    b.Property<int?>("CreatedByUserId");

                    b.Property<DateTimeOffset?>("CreatedDateTime");

                    b.Property<string>("HashedPassword")
                        .IsRequired()
                        .HasMaxLength(450);

                    b.Property<string>("ModifiedByBrowserName")
                        .HasMaxLength(1000);

                    b.Property<string>("ModifiedByIp")
                        .HasMaxLength(255);

                    b.Property<int?>("ModifiedByUserId");

                    b.Property<DateTimeOffset?>("ModifiedDateTime");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AppUserUsedPasswords");
                });

            modelBuilder.Entity("ASPNETCoreIdentitySample.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CategoryId");

                    b.Property<string>("CreatedByBrowserName")
                        .HasMaxLength(1000);

                    b.Property<string>("CreatedByIp")
                        .HasMaxLength(255);

                    b.Property<int?>("CreatedByUserId");

                    b.Property<DateTimeOffset?>("CreatedDateTime");

                    b.Property<string>("ModifiedByBrowserName")
                        .HasMaxLength(1000);

                    b.Property<string>("ModifiedByIp")
                        .HasMaxLength(255);

                    b.Property<int?>("ModifiedByUserId");

                    b.Property<DateTimeOffset?>("ModifiedDateTime");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(450);

                    b.Property<decimal>("Price");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("ASPNETCoreIdentitySample.Entities.Identity.RoleClaim", b =>
                {
                    b.HasOne("ASPNETCoreIdentitySample.Entities.Identity.Role", "Role")
                        .WithMany("Claims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ASPNETCoreIdentitySample.Entities.Identity.UserClaim", b =>
                {
                    b.HasOne("ASPNETCoreIdentitySample.Entities.Identity.User", "User")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ASPNETCoreIdentitySample.Entities.Identity.UserLogin", b =>
                {
                    b.HasOne("ASPNETCoreIdentitySample.Entities.Identity.User", "User")
                        .WithMany("Logins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ASPNETCoreIdentitySample.Entities.Identity.UserRole", b =>
                {
                    b.HasOne("ASPNETCoreIdentitySample.Entities.Identity.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ASPNETCoreIdentitySample.Entities.Identity.User", "User")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ASPNETCoreIdentitySample.Entities.Identity.UserToken", b =>
                {
                    b.HasOne("ASPNETCoreIdentitySample.Entities.Identity.User", "User")
                        .WithMany("UserTokens")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ASPNETCoreIdentitySample.Entities.Identity.UserUsedPassword", b =>
                {
                    b.HasOne("ASPNETCoreIdentitySample.Entities.Identity.User", "User")
                        .WithMany("UserUsedPasswords")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ASPNETCoreIdentitySample.Entities.Product", b =>
                {
                    b.HasOne("ASPNETCoreIdentitySample.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
