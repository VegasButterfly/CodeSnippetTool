﻿// <auto-generated />
using System;
using CodeSnippetTool.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CodeSnippetTool.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241129191541_DisableForeignKeys")]
    partial class DisableForeignKeys
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.0");

            modelBuilder.Entity("CodeSnippetTool.Models.Language", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("LanguageName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("LanguageName")
                        .IsUnique();

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("CodeSnippetTool.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleName")
                        .IsUnique();

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("CodeSnippetTool.Models.Snippet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AnalysisText")
                        .HasColumnType("TEXT");

                    b.Property<string>("CodeSnippetText")
                        .HasColumnType("TEXT");

                    b.Property<int>("CreatedById")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<bool>("IsAnalyzed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasDefaultValue(false);

                    b.Property<bool>("IsReviewed")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("LanguageId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LanguageName")
                        .HasColumnType("TEXT");

                    b.Property<int?>("ReviewedById")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("ReviewedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("SnippetDescription")
                        .HasColumnType("TEXT");

                    b.Property<string>("SnippetName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CreatedById");

                    b.HasIndex("ReviewedById");

                    b.ToTable("Snippets");
                });

            modelBuilder.Entity("CodeSnippetTool.Models.Translation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Language")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("ReviewDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Reviewed")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ReviewerId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SnippetId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TranslationText")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ReviewerId");

                    b.HasIndex("SnippetId");

                    b.ToTable("Translations");
                });

            modelBuilder.Entity("CodeSnippetTool.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Salt")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("UserRoles", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RoleId")
                        .HasColumnType("INTEGER");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("CodeSnippetTool.Models.Snippet", b =>
                {
                    b.HasOne("CodeSnippetTool.Models.User", "CreatedBy")
                        .WithMany("Snippets")
                        .HasForeignKey("CreatedById")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.HasOne("CodeSnippetTool.Models.User", "ReviewedBy")
                        .WithMany("ReviewedSnippets")
                        .HasForeignKey("ReviewedById")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("CreatedBy");

                    b.Navigation("ReviewedBy");
                });

            modelBuilder.Entity("CodeSnippetTool.Models.Translation", b =>
                {
                    b.HasOne("CodeSnippetTool.Models.User", "Reviewer")
                        .WithMany()
                        .HasForeignKey("ReviewerId");

                    b.HasOne("CodeSnippetTool.Models.Snippet", "Snippet")
                        .WithMany("Translations")
                        .HasForeignKey("SnippetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Reviewer");

                    b.Navigation("Snippet");
                });

            modelBuilder.Entity("UserRoles", b =>
                {
                    b.HasOne("CodeSnippetTool.Models.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodeSnippetTool.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CodeSnippetTool.Models.Snippet", b =>
                {
                    b.Navigation("Translations");
                });

            modelBuilder.Entity("CodeSnippetTool.Models.User", b =>
                {
                    b.Navigation("ReviewedSnippets");

                    b.Navigation("Snippets");
                });
#pragma warning restore 612, 618
        }
    }
}
