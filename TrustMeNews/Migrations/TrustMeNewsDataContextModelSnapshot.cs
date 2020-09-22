﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TrustMeNews.Data;

namespace TrustMeNews.Migrations
{
    [DbContext(typeof(TrustMeNewsDataContext))]
    partial class TrustMeNewsDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TrustMeNews.Models.Comment", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Comment")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CommentId");

                    b.HasIndex("Comment");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("TrustMeNews.Models.Field", b =>
                {
                    b.Property<string>("headline")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("bodyText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("byline")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("main")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("standfirst")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("thumbnail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("trailText")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("headline");

                    b.ToTable("Field");
                });

            modelBuilder.Entity("TrustMeNews.Models.Result", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("Result")
                        .HasColumnType("int");

                    b.Property<string>("fieldsheadline")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("sectionId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sectionName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("webPublicationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("webTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("Result");

                    b.HasIndex("fieldsheadline");

                    b.ToTable("Articles");
                });

            modelBuilder.Entity("TrustMeNews.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("TrustMeNews.Models.Comment", b =>
                {
                    b.HasOne("TrustMeNews.Models.User", "User")
                        .WithMany("Comments")
                        .HasForeignKey("Comment");
                });

            modelBuilder.Entity("TrustMeNews.Models.Result", b =>
                {
                    b.HasOne("TrustMeNews.Models.User", "User")
                        .WithMany("Articles")
                        .HasForeignKey("Result");

                    b.HasOne("TrustMeNews.Models.Field", "fields")
                        .WithMany()
                        .HasForeignKey("fieldsheadline");
                });
#pragma warning restore 612, 618
        }
    }
}
