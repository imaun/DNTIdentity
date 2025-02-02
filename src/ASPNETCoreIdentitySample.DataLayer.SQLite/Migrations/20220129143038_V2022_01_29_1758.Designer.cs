﻿// <auto-generated />
using System;
using ASPNETCoreIdentitySample.DataLayer.SQLite;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ASPNETCoreIdentitySample.DataLayer.SQLite.Migrations
{
    [DbContext(typeof(SQLiteDbContext))]
    [Migration("20220129143038_V2022_01_29_1758")]
    partial class V2022_01_29_1758
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseCollation("NOCASE")
                .HasAnnotation("ProductVersion", "6.0.1");

            modelBuilder.Entity("ASPNETCoreIdentitySample.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CreatedByBrowserName")
                        .HasMaxLength(1000)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<string>("CreatedByIp")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<int?>("CreatedByUserId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("CreatedDateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("ModifiedByBrowserName")
                        .HasMaxLength(1000)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<string>("ModifiedByIp")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<int?>("ModifiedByUserId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("ModifiedDateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(450)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("ASPNETCoreIdentitySample.Entities.Identity.AppDataProtectionKey", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FriendlyName")
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<string>("XmlData")
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.HasKey("Id");

                    b.HasIndex("FriendlyName")
                        .IsUnique();

                    b.ToTable("AppDataProtectionKeys", (string)null);
                });

            modelBuilder.Entity("ASPNETCoreIdentitySample.Entities.Identity.AppLogItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CreatedByBrowserName")
                        .HasMaxLength(1000)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<string>("CreatedByIp")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<int?>("CreatedByUserId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("CreatedDateTime")
                        .HasColumnType("TEXT");

                    b.Property<int>("EventId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LogLevel")
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<string>("Logger")
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<string>("Message")
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<string>("ModifiedByBrowserName")
                        .HasMaxLength(1000)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<string>("ModifiedByIp")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<int?>("ModifiedByUserId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("ModifiedDateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("StateJson")
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.HasKey("Id");

                    b.ToTable("AppLogItems");
                });

            modelBuilder.Entity("ASPNETCoreIdentitySample.Entities.Identity.AppSqlCache", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(449)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<DateTime?>("AbsoluteExpiration")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ExpiresAtTime")
                        .HasColumnType("TEXT");

                    b.Property<long?>("SlidingExpirationInSeconds")
                        .HasColumnType("INTEGER");

                    b.Property<byte[]>("Value")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.HasKey("Id");

                    b.HasIndex("ExpiresAtTime")
                        .HasDatabaseName("Index_ExpiresAtTime");

                    b.ToTable("AppSqlCache", "dbo");
                });

            modelBuilder.Entity("ASPNETCoreIdentitySample.Entities.Identity.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<string>("CreatedByBrowserName")
                        .HasMaxLength(1000)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<string>("CreatedByIp")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<int?>("CreatedByUserId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("CreatedDateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<string>("ModifiedByBrowserName")
                        .HasMaxLength(1000)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<string>("ModifiedByIp")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<int?>("ModifiedByUserId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("ModifiedDateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AppRoles", (string)null);
                });

            modelBuilder.Entity("ASPNETCoreIdentitySample.Entities.Identity.RoleClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<string>("CreatedByBrowserName")
                        .HasMaxLength(1000)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<string>("CreatedByIp")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<int?>("CreatedByUserId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("CreatedDateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("ModifiedByBrowserName")
                        .HasMaxLength(1000)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<string>("ModifiedByIp")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<int?>("ModifiedByUserId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("ModifiedDateTime")
                        .HasColumnType("TEXT");

                    b.Property<int>("RoleId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AppRoleClaims", (string)null);
                });

            modelBuilder.Entity("ASPNETCoreIdentitySample.Entities.Identity.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<string>("CreatedByBrowserName")
                        .HasMaxLength(1000)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<string>("CreatedByIp")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<int?>("CreatedByUserId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("CreatedDateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .HasMaxLength(450)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsEmailPublic")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .HasMaxLength(450)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<DateTime?>("LastVisitDateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Location")
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("ModifiedByBrowserName")
                        .HasMaxLength(1000)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<string>("ModifiedByIp")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<int?>("ModifiedByUserId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("ModifiedDateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PhotoFileName")
                        .HasMaxLength(450)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AppUsers", (string)null);
                });

            modelBuilder.Entity("ASPNETCoreIdentitySample.Entities.Identity.UserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<string>("CreatedByBrowserName")
                        .HasMaxLength(1000)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<string>("CreatedByIp")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<int?>("CreatedByUserId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("CreatedDateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("ModifiedByBrowserName")
                        .HasMaxLength(1000)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<string>("ModifiedByIp")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<int?>("ModifiedByUserId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("ModifiedDateTime")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AppUserClaims", (string)null);
                });

            modelBuilder.Entity("ASPNETCoreIdentitySample.Entities.Identity.UserLogin", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<string>("CreatedByBrowserName")
                        .HasMaxLength(1000)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<string>("CreatedByIp")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<int?>("CreatedByUserId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("CreatedDateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("ModifiedByBrowserName")
                        .HasMaxLength(1000)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<string>("ModifiedByIp")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<int?>("ModifiedByUserId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("ModifiedDateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AppUserLogins", (string)null);
                });

            modelBuilder.Entity("ASPNETCoreIdentitySample.Entities.Identity.UserRole", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RoleId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CreatedByBrowserName")
                        .HasMaxLength(1000)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<string>("CreatedByIp")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<int?>("CreatedByUserId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("CreatedDateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("ModifiedByBrowserName")
                        .HasMaxLength(1000)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<string>("ModifiedByIp")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<int?>("ModifiedByUserId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("ModifiedDateTime")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AppUserRoles", (string)null);
                });

            modelBuilder.Entity("ASPNETCoreIdentitySample.Entities.Identity.UserToken", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<string>("CreatedByBrowserName")
                        .HasMaxLength(1000)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<string>("CreatedByIp")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<int?>("CreatedByUserId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("CreatedDateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("ModifiedByBrowserName")
                        .HasMaxLength(1000)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<string>("ModifiedByIp")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<int?>("ModifiedByUserId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("ModifiedDateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AppUserTokens", (string)null);
                });

            modelBuilder.Entity("ASPNETCoreIdentitySample.Entities.Identity.UserUsedPassword", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CreatedByBrowserName")
                        .HasMaxLength(1000)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<string>("CreatedByIp")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<int?>("CreatedByUserId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("CreatedDateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("HashedPassword")
                        .IsRequired()
                        .HasMaxLength(450)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<string>("ModifiedByBrowserName")
                        .HasMaxLength(1000)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<string>("ModifiedByIp")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<int?>("ModifiedByUserId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("ModifiedDateTime")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AppUserUsedPasswords", (string)null);
                });

            modelBuilder.Entity("ASPNETCoreIdentitySample.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CreatedByBrowserName")
                        .HasMaxLength(1000)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<string>("CreatedByIp")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<int?>("CreatedByUserId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("CreatedDateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("ModifiedByBrowserName")
                        .HasMaxLength(1000)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<string>("ModifiedByIp")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<int?>("ModifiedByUserId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("ModifiedDateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(450)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18, 6)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("ASPNETCoreIdentitySample.Entities.Identity.RoleClaim", b =>
                {
                    b.HasOne("ASPNETCoreIdentitySample.Entities.Identity.Role", "Role")
                        .WithMany("Claims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("ASPNETCoreIdentitySample.Entities.Identity.UserClaim", b =>
                {
                    b.HasOne("ASPNETCoreIdentitySample.Entities.Identity.User", "User")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("ASPNETCoreIdentitySample.Entities.Identity.UserLogin", b =>
                {
                    b.HasOne("ASPNETCoreIdentitySample.Entities.Identity.User", "User")
                        .WithMany("Logins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("ASPNETCoreIdentitySample.Entities.Identity.UserRole", b =>
                {
                    b.HasOne("ASPNETCoreIdentitySample.Entities.Identity.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ASPNETCoreIdentitySample.Entities.Identity.User", "User")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ASPNETCoreIdentitySample.Entities.Identity.UserToken", b =>
                {
                    b.HasOne("ASPNETCoreIdentitySample.Entities.Identity.User", "User")
                        .WithMany("UserTokens")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("ASPNETCoreIdentitySample.Entities.Identity.UserUsedPassword", b =>
                {
                    b.HasOne("ASPNETCoreIdentitySample.Entities.Identity.User", "User")
                        .WithMany("UserUsedPasswords")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("ASPNETCoreIdentitySample.Entities.Product", b =>
                {
                    b.HasOne("ASPNETCoreIdentitySample.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("ASPNETCoreIdentitySample.Entities.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("ASPNETCoreIdentitySample.Entities.Identity.Role", b =>
                {
                    b.Navigation("Claims");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("ASPNETCoreIdentitySample.Entities.Identity.User", b =>
                {
                    b.Navigation("Claims");

                    b.Navigation("Logins");

                    b.Navigation("Roles");

                    b.Navigation("UserTokens");

                    b.Navigation("UserUsedPasswords");
                });
#pragma warning restore 612, 618
        }
    }
}
