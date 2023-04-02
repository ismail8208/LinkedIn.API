﻿// <auto-generated />
using System;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(OnlineCommunityContext))]
    [Migration("20230402125908_one_to_many_projects_users")]
    partial class one_to_many_projects_users
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("OnlineCommunityDomain.Address", b =>
                {
                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("AddressId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("OnlineCommunityDomain.Comment", b =>
                {
                    b.Property<int>("CommentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CommentID"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("PostID")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("CommentID");

                    b.HasIndex("PostID");

                    b.HasIndex("UserID");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("OnlineCommunityDomain.Education", b =>
                {
                    b.Property<int>("EducationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EducationId"));

                    b.Property<string>("Level")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("EducationId");

                    b.HasIndex("UserId");

                    b.ToTable("Educations");
                });

            modelBuilder.Entity("OnlineCommunityDomain.Endore", b =>
                {
                    b.Property<int>("EndoreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EndoreId"));

                    b.Property<int>("SkillId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("EndoreId");

                    b.HasIndex("SkillId");

                    b.HasIndex("UserId");

                    b.ToTable("Endores");
                });

            modelBuilder.Entity("OnlineCommunityDomain.Experience", b =>
                {
                    b.Property<int>("ExperienceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ExperienceId"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ExperienceDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("ExperienceId");

                    b.HasIndex("UserId");

                    b.ToTable("Experiences");
                });

            modelBuilder.Entity("OnlineCommunityDomain.Follow", b =>
                {
                    b.Property<int>("FollowerID")
                        .HasColumnType("int");

                    b.Property<int>("FolloweeID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("FollowID")
                        .HasColumnType("int");

                    b.HasKey("FollowerID", "FolloweeID");

                    b.HasIndex("FolloweeID");

                    b.ToTable("Follows");
                });

            modelBuilder.Entity("OnlineCommunityDomain.Like", b =>
                {
                    b.Property<int>("LikeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LikeID"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("PostID")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("LikeID");

                    b.HasIndex("PostID");

                    b.HasIndex("UserID");

                    b.ToTable("Likes");
                });

            modelBuilder.Entity("OnlineCommunityDomain.Post", b =>
                {
                    b.Property<int>("PostID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PostID"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfComments")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfLikes")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.Property<string>("VideoURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PostID");

                    b.HasIndex("UserID");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("OnlineCommunityDomain.Project", b =>
                {
                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ExperienceId")
                        .HasColumnType("int");

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("ProjectId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("OnlineCommunityDomain.Share", b =>
                {
                    b.Property<int>("ShareID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ShareID"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("PostID")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("ShareID");

                    b.HasIndex("PostID");

                    b.HasIndex("UserID");

                    b.ToTable("Shares");
                });

            modelBuilder.Entity("OnlineCommunityDomain.Skill", b =>
                {
                    b.Property<int>("SkillId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SkillId"));

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("SkillId");

                    b.HasIndex("UserId");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("OnlineCommunityDomain.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserID"));

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("OnlineCommunityDomain.Address", b =>
                {
                    b.HasOne("OnlineCommunityDomain.User", "User")
                        .WithOne("Address")
                        .HasForeignKey("OnlineCommunityDomain.Address", "AddressId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("OnlineCommunityDomain.Comment", b =>
                {
                    b.HasOne("OnlineCommunityDomain.Post", "Post")
                        .WithMany("Comments")
                        .HasForeignKey("PostID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("OnlineCommunityDomain.User", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Post");

                    b.Navigation("User");
                });

            modelBuilder.Entity("OnlineCommunityDomain.Education", b =>
                {
                    b.HasOne("OnlineCommunityDomain.User", "User")
                        .WithMany("Educations")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("OnlineCommunityDomain.Endore", b =>
                {
                    b.HasOne("OnlineCommunityDomain.Skill", "Skill")
                        .WithMany("Endores")
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("OnlineCommunityDomain.User", "User")
                        .WithMany("Endores")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Skill");

                    b.Navigation("User");
                });

            modelBuilder.Entity("OnlineCommunityDomain.Experience", b =>
                {
                    b.HasOne("OnlineCommunityDomain.User", "User")
                        .WithMany("Experiences")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("OnlineCommunityDomain.Follow", b =>
                {
                    b.HasOne("OnlineCommunityDomain.User", "Followee")
                        .WithMany("Followers")
                        .HasForeignKey("FolloweeID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("OnlineCommunityDomain.User", "Follower")
                        .WithMany("Followees")
                        .HasForeignKey("FollowerID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Followee");

                    b.Navigation("Follower");
                });

            modelBuilder.Entity("OnlineCommunityDomain.Like", b =>
                {
                    b.HasOne("OnlineCommunityDomain.Post", "Post")
                        .WithMany("Likes")
                        .HasForeignKey("PostID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("OnlineCommunityDomain.User", "User")
                        .WithMany("Likes")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Post");

                    b.Navigation("User");
                });

            modelBuilder.Entity("OnlineCommunityDomain.Post", b =>
                {
                    b.HasOne("OnlineCommunityDomain.User", "User")
                        .WithMany("Posts")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("OnlineCommunityDomain.Project", b =>
                {
                    b.HasOne("OnlineCommunityDomain.Experience", "Experience")
                        .WithOne("Project")
                        .HasForeignKey("OnlineCommunityDomain.Project", "ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineCommunityDomain.User", "User")
                        .WithMany("Projects")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Experience");

                    b.Navigation("User");
                });

            modelBuilder.Entity("OnlineCommunityDomain.Share", b =>
                {
                    b.HasOne("OnlineCommunityDomain.Post", "Post")
                        .WithMany("Shares")
                        .HasForeignKey("PostID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("OnlineCommunityDomain.User", "User")
                        .WithMany("SharedPosts")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Post");

                    b.Navigation("User");
                });

            modelBuilder.Entity("OnlineCommunityDomain.Skill", b =>
                {
                    b.HasOne("OnlineCommunityDomain.User", "User")
                        .WithMany("Skills")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("OnlineCommunityDomain.Experience", b =>
                {
                    b.Navigation("Project")
                        .IsRequired();
                });

            modelBuilder.Entity("OnlineCommunityDomain.Post", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Likes");

                    b.Navigation("Shares");
                });

            modelBuilder.Entity("OnlineCommunityDomain.Skill", b =>
                {
                    b.Navigation("Endores");
                });

            modelBuilder.Entity("OnlineCommunityDomain.User", b =>
                {
                    b.Navigation("Address")
                        .IsRequired();

                    b.Navigation("Comments");

                    b.Navigation("Educations");

                    b.Navigation("Endores");

                    b.Navigation("Experiences");

                    b.Navigation("Followees");

                    b.Navigation("Followers");

                    b.Navigation("Likes");

                    b.Navigation("Posts");

                    b.Navigation("Projects");

                    b.Navigation("SharedPosts");

                    b.Navigation("Skills");
                });
#pragma warning restore 612, 618
        }
    }
}
