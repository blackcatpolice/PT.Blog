﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PageTechsLMS.DataCore.DbContexts;

namespace PageTechsLMS.DataCore.Data.Mysql.Migrations
{
    [DbContext(typeof(PageTechsLMSDbContext))]
    [Migration("20210423112250_addWxUserinfo")]
    partial class addWxUserinfo
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.5");

            modelBuilder.Entity("IdentityServer4.EntityFramework.Entities.DeviceFlowCodes", b =>
                {
                    b.Property<string>("ClientId")
                        .HasColumnType("longtext CHARACTER SET utf8");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Data")
                        .HasColumnType("longtext CHARACTER SET utf8");

                    b.Property<string>("Description")
                        .HasColumnType("longtext CHARACTER SET utf8");

                    b.Property<string>("DeviceCode")
                        .HasColumnType("longtext CHARACTER SET utf8");

                    b.Property<DateTime?>("Expiration")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("SessionId")
                        .HasColumnType("longtext CHARACTER SET utf8");

                    b.Property<string>("SubjectId")
                        .HasColumnType("longtext CHARACTER SET utf8");

                    b.Property<string>("UserCode")
                        .HasColumnType("longtext CHARACTER SET utf8");

                    b.ToTable("DeviceFlowCodes");
                });

            modelBuilder.Entity("IdentityServer4.EntityFramework.Entities.PersistedGrant", b =>
                {
                    b.Property<string>("Key")
                        .HasColumnType("varchar(255) CHARACTER SET utf8");

                    b.Property<string>("ClientId")
                        .HasColumnType("longtext CHARACTER SET utf8");

                    b.Property<DateTime?>("ConsumedTime")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Data")
                        .HasColumnType("longtext CHARACTER SET utf8");

                    b.Property<string>("Description")
                        .HasColumnType("longtext CHARACTER SET utf8");

                    b.Property<DateTime?>("Expiration")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("SessionId")
                        .HasColumnType("longtext CHARACTER SET utf8");

                    b.Property<string>("SubjectId")
                        .HasColumnType("longtext CHARACTER SET utf8");

                    b.Property<string>("Type")
                        .HasColumnType("longtext CHARACTER SET utf8");

                    b.HasKey("Key");

                    b.ToTable("PersistedGrants");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext CHARACTER SET utf8");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext CHARACTER SET utf8");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(255) CHARACTER SET utf8");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext CHARACTER SET utf8");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext CHARACTER SET utf8");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255) CHARACTER SET utf8");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255) CHARACTER SET utf8");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("varchar(255) CHARACTER SET utf8");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext CHARACTER SET utf8");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255) CHARACTER SET utf8");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255) CHARACTER SET utf8");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(255) CHARACTER SET utf8");

                    b.Property<string>("Value")
                        .HasColumnType("longtext CHARACTER SET utf8");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("PageTechsLMS.DataCore.Community.Post", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Content")
                        .HasColumnType("longtext CHARACTER SET utf8");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("FavoriteNum")
                        .HasColumnType("int");

                    b.Property<int>("LikeNum")
                        .HasColumnType("int");

                    b.Property<string>("MemberId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8");

                    b.Property<Guid>("TopicId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("MemberId");

                    b.HasIndex("TopicId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("PageTechsLMS.DataCore.Community.Topics", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Title")
                        .HasColumnType("longtext CHARACTER SET utf8");

                    b.HasKey("Id");

                    b.ToTable("Topics");
                });

            modelBuilder.Entity("PageTechsLMS.DataCore.Courses.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Cover")
                        .HasColumnType("longtext CHARACTER SET utf8");

                    b.Property<string>("Description")
                        .HasColumnType("longtext CHARACTER SET utf8");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8");

                    b.HasKey("Id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("PageTechsLMS.DataCore.Courses.Comments", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Content")
                        .HasColumnType("longtext CHARACTER SET utf8");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("MemberAccountId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8");

                    b.Property<string>("MemberId")
                        .HasColumnType("longtext CHARACTER SET utf8");

                    b.HasKey("Id");

                    b.HasIndex("MemberAccountId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("PageTechsLMS.DataCore.Courses.Course", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("char(36)");

                    b.Property<int>("CommentNum")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .HasColumnType("longtext CHARACTER SET utf8");

                    b.Property<string>("Cover")
                        .HasColumnType("longtext CHARACTER SET utf8");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .HasColumnType("longtext CHARACTER SET utf8");

                    b.Property<int>("Favorite")
                        .HasColumnType("int");

                    b.Property<string>("Icon")
                        .HasColumnType("longtext CHARACTER SET utf8");

                    b.Property<bool>("IsHot")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Level")
                        .HasColumnType("longtext CHARACTER SET utf8");

                    b.Property<int>("Like")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("double");

                    b.Property<int>("StartNum")
                        .HasColumnType("int");

                    b.Property<string>("Video")
                        .HasColumnType("longtext CHARACTER SET utf8");

                    b.Property<int>("ViewNumb")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("PageTechsLMS.DataCore.Courses.Lesson", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("CourseId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Description")
                        .HasColumnType("longtext CHARACTER SET utf8");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("Lessons");
                });

            modelBuilder.Entity("PageTechsLMS.DataCore.Courses.Section", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("CourseId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("LessonId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8");

                    b.HasKey("Id");

                    b.HasIndex("LessonId");

                    b.ToTable("Sections");
                });

            modelBuilder.Entity("PageTechsLMS.DataCore.Courses.SectionItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("CourseId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Duration")
                        .HasColumnType("longtext CHARACTER SET utf8");

                    b.Property<bool>("IsFree")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsTrailer")
                        .HasColumnType("tinyint(1)");

                    b.Property<Guid>("LessonId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Level")
                        .HasColumnType("longtext CHARACTER SET utf8");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8");

                    b.Property<Guid>("SectionId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Video")
                        .HasColumnType("longtext CHARACTER SET utf8");

                    b.HasKey("Id");

                    b.HasIndex("SectionId");

                    b.ToTable("SectionItems");
                });

            modelBuilder.Entity("PageTechsLMS.DataCore.Courses.Tags", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("CourseId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("PageTechsLMS.DataCore.File.FilebaseInfo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Ext")
                        .HasColumnType("longtext CHARACTER SET utf8");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8");

                    b.Property<string>("PhysicPath")
                        .HasColumnType("longtext CHARACTER SET utf8");

                    b.Property<string>("RelativePath")
                        .HasColumnType("longtext CHARACTER SET utf8");

                    b.Property<string>("Size")
                        .HasColumnType("longtext CHARACTER SET utf8");

                    b.HasKey("Id");

                    b.ToTable("FilebaseInfo");
                });

            modelBuilder.Entity("PageTechsLMS.DataCore.MemberCourse.MemberCourseLearnLog", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("CourseId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("LessonId")
                        .HasColumnType("char(36)");

                    b.Property<string>("MemberId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8");

                    b.Property<int>("Remaining")
                        .HasColumnType("int");

                    b.Property<Guid>("SectionId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("SectionItemId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("MemberId");

                    b.ToTable("MemberCourseLearnLogs");
                });

            modelBuilder.Entity("PageTechsLMS.DataCore.MemberCourse.MemberCoursePayLog", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("CourseId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("MemberId")
                        .HasColumnType("longtext CHARACTER SET utf8");

                    b.Property<Guid>("OrderId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.ToTable("MemberCoursePayLogs");
                });

            modelBuilder.Entity("PageTechsLMS.DataCore.MemberCourse.MemberFeedbackLog", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Content")
                        .HasColumnType("longtext CHARACTER SET utf8");

                    b.Property<Guid>("CourseId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("IsFavorite")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsLiked")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("MemberId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8");

                    b.Property<int>("StartNum")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MemberId");

                    b.ToTable("MemberFeedbackLogs");
                });

            modelBuilder.Entity("PageTechsLMS.DataCore.Members.MemberAccount", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255) CHARACTER SET utf8");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext CHARACTER SET utf8");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256) CHARACTER SET utf8");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("MemberBindId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8");

                    b.Property<string>("MemberInfoId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8");

                    b.Property<string>("NickName")
                        .HasColumnType("longtext CHARACTER SET utf8");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256) CHARACTER SET utf8");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256) CHARACTER SET utf8");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext CHARACTER SET utf8");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext CHARACTER SET utf8");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext CHARACTER SET utf8");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256) CHARACTER SET utf8");

                    b.HasKey("Id");

                    b.HasIndex("MemberBindId")
                        .IsUnique();

                    b.HasIndex("MemberInfoId")
                        .IsUnique();

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("PageTechsLMS.DataCore.Members.MemberBind", b =>
                {
                    b.Property<string>("MemberId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8");

                    b.Property<string>("WxNickName")
                        .HasColumnType("longtext CHARACTER SET utf8");

                    b.Property<string>("WxOpenId")
                        .HasColumnType("longtext CHARACTER SET utf8");

                    b.HasKey("MemberId");

                    b.ToTable("MemberBinds");
                });

            modelBuilder.Entity("PageTechsLMS.DataCore.Members.MemberInfo", b =>
                {
                    b.Property<string>("MemberId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8");

                    b.Property<string>("Avatart")
                        .HasColumnType("longtext CHARACTER SET utf8");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8");

                    b.HasKey("MemberId");

                    b.ToTable("MemberInfos");
                });

            modelBuilder.Entity("PageTechsLMS.DataCore.Members.MemberRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255) CHARACTER SET utf8");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext CHARACTER SET utf8");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256) CHARACTER SET utf8");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256) CHARACTER SET utf8");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("PageTechsLMS.DataCore.Message.Messagebox", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Content")
                        .HasColumnType("longtext CHARACTER SET utf8");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("FromeMemberId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8");

                    b.Property<bool>("IsRead")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("MemberId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8");

                    b.HasKey("Id");

                    b.HasIndex("FromeMemberId");

                    b.HasIndex("MemberId");

                    b.ToTable("Messageboxes");
                });

            modelBuilder.Entity("PageTechsLMS.DataCore.Orders.CourseOrder", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Channel")
                        .HasColumnType("longtext CHARACTER SET utf8");

                    b.Property<Guid>("CourseId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Desc")
                        .HasColumnType("longtext CHARACTER SET utf8");

                    b.Property<string>("Fee")
                        .HasColumnType("longtext CHARACTER SET utf8");

                    b.Property<string>("MemberId")
                        .HasColumnType("longtext CHARACTER SET utf8");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8");

                    b.Property<int>("OrderType")
                        .HasColumnType("int");

                    b.Property<string>("OutTradeNo")
                        .HasColumnType("longtext CHARACTER SET utf8");

                    b.Property<int>("PayChannel")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("double");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Tag")
                        .HasColumnType("longtext CHARACTER SET utf8");

                    b.Property<string>("TradeId")
                        .HasColumnType("longtext CHARACTER SET utf8");

                    b.HasKey("Id");

                    b.ToTable("CourseOrder");
                });

            modelBuilder.Entity("PageTechsLMS.DataCore.Payments.Paylog", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("MemberId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8");

                    b.Property<string>("OrderChannel")
                        .HasColumnType("longtext CHARACTER SET utf8");

                    b.Property<string>("OrderFee")
                        .HasColumnType("longtext CHARACTER SET utf8");

                    b.Property<string>("OrderName")
                        .HasColumnType("longtext CHARACTER SET utf8");

                    b.Property<string>("OrderType")
                        .HasColumnType("longtext CHARACTER SET utf8");

                    b.HasKey("Id");

                    b.HasIndex("MemberId");

                    b.ToTable("Paylogs");
                });

            modelBuilder.Entity("PageTechsLMS.DataCore.Setting.Basic.SiteSetting", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Description")
                        .HasColumnType("longtext CHARACTER SET utf8");

                    b.Property<string>("FooterInfo")
                        .HasColumnType("longtext CHARACTER SET utf8");

                    b.Property<string>("FooterScript")
                        .HasColumnType("longtext CHARACTER SET utf8");

                    b.Property<string>("Keys")
                        .HasColumnType("longtext CHARACTER SET utf8");

                    b.Property<string>("SiteName")
                        .HasColumnType("longtext CHARACTER SET utf8");

                    b.HasKey("Id");

                    b.ToTable("SiteSettings");
                });

            modelBuilder.Entity("PageTechsLMS.DataCore.Teachers.Teacher", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("CoverImg")
                        .HasColumnType("longtext CHARACTER SET utf8");

                    b.Property<string>("Description")
                        .HasColumnType("longtext CHARACTER SET utf8");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8");

                    b.HasKey("Id");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("PageTechsLMS.DataCore.Members.MemberRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("PageTechsLMS.DataCore.Members.MemberAccount", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("PageTechsLMS.DataCore.Members.MemberAccount", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("PageTechsLMS.DataCore.Members.MemberRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PageTechsLMS.DataCore.Members.MemberAccount", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("PageTechsLMS.DataCore.Members.MemberAccount", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PageTechsLMS.DataCore.Community.Post", b =>
                {
                    b.HasOne("PageTechsLMS.DataCore.Members.MemberInfo", "MemberInfo")
                        .WithMany()
                        .HasForeignKey("MemberId");

                    b.HasOne("PageTechsLMS.DataCore.Community.Topics", "Topics")
                        .WithMany()
                        .HasForeignKey("TopicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MemberInfo");

                    b.Navigation("Topics");
                });

            modelBuilder.Entity("PageTechsLMS.DataCore.Courses.Comments", b =>
                {
                    b.HasOne("PageTechsLMS.DataCore.Members.MemberAccount", "MemberAccount")
                        .WithMany()
                        .HasForeignKey("MemberAccountId");

                    b.Navigation("MemberAccount");
                });

            modelBuilder.Entity("PageTechsLMS.DataCore.Courses.Course", b =>
                {
                    b.HasOne("PageTechsLMS.DataCore.Courses.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("PageTechsLMS.DataCore.Courses.Lesson", b =>
                {
                    b.HasOne("PageTechsLMS.DataCore.Courses.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("PageTechsLMS.DataCore.Courses.Section", b =>
                {
                    b.HasOne("PageTechsLMS.DataCore.Courses.Lesson", null)
                        .WithMany("Sections")
                        .HasForeignKey("LessonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PageTechsLMS.DataCore.Courses.SectionItem", b =>
                {
                    b.HasOne("PageTechsLMS.DataCore.Courses.Section", null)
                        .WithMany("Items")
                        .HasForeignKey("SectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PageTechsLMS.DataCore.Courses.Tags", b =>
                {
                    b.HasOne("PageTechsLMS.DataCore.Courses.Course", "Course")
                        .WithMany("Tags")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("PageTechsLMS.DataCore.MemberCourse.MemberCourseLearnLog", b =>
                {
                    b.HasOne("PageTechsLMS.DataCore.Members.MemberAccount", "MemberAccount")
                        .WithMany()
                        .HasForeignKey("MemberId");

                    b.Navigation("MemberAccount");
                });

            modelBuilder.Entity("PageTechsLMS.DataCore.MemberCourse.MemberFeedbackLog", b =>
                {
                    b.HasOne("PageTechsLMS.DataCore.Members.MemberAccount", "MemberAccount")
                        .WithMany()
                        .HasForeignKey("MemberId");

                    b.Navigation("MemberAccount");
                });

            modelBuilder.Entity("PageTechsLMS.DataCore.Members.MemberAccount", b =>
                {
                    b.HasOne("PageTechsLMS.DataCore.Members.MemberBind", "MemberBind")
                        .WithOne("Account")
                        .HasForeignKey("PageTechsLMS.DataCore.Members.MemberAccount", "MemberBindId");

                    b.HasOne("PageTechsLMS.DataCore.Members.MemberInfo", "MemberInfo")
                        .WithOne("Account")
                        .HasForeignKey("PageTechsLMS.DataCore.Members.MemberAccount", "MemberInfoId");

                    b.Navigation("MemberBind");

                    b.Navigation("MemberInfo");
                });

            modelBuilder.Entity("PageTechsLMS.DataCore.Message.Messagebox", b =>
                {
                    b.HasOne("PageTechsLMS.DataCore.Members.MemberInfo", "FromMemberInfo")
                        .WithMany()
                        .HasForeignKey("FromeMemberId");

                    b.HasOne("PageTechsLMS.DataCore.Members.MemberInfo", "MemberInfo")
                        .WithMany()
                        .HasForeignKey("MemberId");

                    b.Navigation("FromMemberInfo");

                    b.Navigation("MemberInfo");
                });

            modelBuilder.Entity("PageTechsLMS.DataCore.Payments.Paylog", b =>
                {
                    b.HasOne("PageTechsLMS.DataCore.Members.MemberAccount", "Member")
                        .WithMany()
                        .HasForeignKey("MemberId");

                    b.Navigation("Member");
                });

            modelBuilder.Entity("PageTechsLMS.DataCore.Courses.Course", b =>
                {
                    b.Navigation("Tags");
                });

            modelBuilder.Entity("PageTechsLMS.DataCore.Courses.Lesson", b =>
                {
                    b.Navigation("Sections");
                });

            modelBuilder.Entity("PageTechsLMS.DataCore.Courses.Section", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("PageTechsLMS.DataCore.Members.MemberBind", b =>
                {
                    b.Navigation("Account");
                });

            modelBuilder.Entity("PageTechsLMS.DataCore.Members.MemberInfo", b =>
                {
                    b.Navigation("Account");
                });
#pragma warning restore 612, 618
        }
    }
}
