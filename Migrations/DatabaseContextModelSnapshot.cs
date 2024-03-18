﻿// <auto-generated />
using System;
using Forum.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Forum.Infrastructure.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.16");

            modelBuilder.Entity("Forum.Domain.Models.Comment", b =>
                {
                    b.Property<long?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("TEXT");

                    b.Property<long?>("CreatorId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Likes")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Text")
                        .HasColumnType("TEXT");

                    b.Property<long?>("TopicId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CreatorId");

                    b.HasIndex("TopicId");

                    b.ToTable("Comment");
                });

            modelBuilder.Entity("Forum.Domain.Models.Topic", b =>
                {
                    b.Property<long?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("TEXT");

                    b.Property<long?>("CreatorId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Likes")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Subject")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CreatorId");

                    b.ToTable("Topic");
                });

            modelBuilder.Entity("Forum.Domain.Models.User", b =>
                {
                    b.Property<long?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("id");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("TEXT")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .HasMaxLength(64)
                        .HasColumnType("TEXT")
                        .HasColumnName("first_name");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasDefaultValue(false)
                        .HasColumnName("is_deleted");

                    b.Property<string>("LastName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT")
                        .HasColumnName("last_name");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("TEXT")
                        .HasColumnName("password");

                    b.Property<string>("Role")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValue("User")
                        .HasColumnName("role");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("TEXT")
                        .HasColumnName("username");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique()
                        .HasDatabaseName("UX_public_users_email");

                    b.HasIndex("Username")
                        .IsUnique()
                        .HasDatabaseName("UX_public_users_username");

                    b.HasIndex("Username", "Role")
                        .HasDatabaseName("IX_public_users_usename_role");

                    b.ToTable("users", "public");
                });

            modelBuilder.Entity("Forum.Domain.Models.Comment", b =>
                {
                    b.HasOne("Forum.Domain.Models.User", "Creator")
                        .WithMany("Comments")
                        .HasForeignKey("CreatorId");

                    b.HasOne("Forum.Domain.Models.Topic", "Topic")
                        .WithMany("Comments")
                        .HasForeignKey("TopicId");

                    b.Navigation("Creator");

                    b.Navigation("Topic");
                });

            modelBuilder.Entity("Forum.Domain.Models.Topic", b =>
                {
                    b.HasOne("Forum.Domain.Models.User", "Creator")
                        .WithMany("Topics")
                        .HasForeignKey("CreatorId");

                    b.Navigation("Creator");
                });

            modelBuilder.Entity("Forum.Domain.Models.Topic", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("Forum.Domain.Models.User", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Topics");
                });
#pragma warning restore 612, 618
        }
    }
}
