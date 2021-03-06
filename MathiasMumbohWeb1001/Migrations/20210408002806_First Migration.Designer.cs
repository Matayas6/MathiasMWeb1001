﻿// <auto-generated />
using MathiasMumbohWeb1001.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MathiasMumbohWeb1001.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210408002806_First Migration")]
    partial class FirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MathiasMumbohWeb1001.Pages.Models.AuthorClass", b =>
                {
                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Birthday")
                        .HasColumnType("int");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("First_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Last_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Province")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Website")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Email");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("MathiasMumbohWeb1001.Pages.Models.BlogClass", b =>
                {
                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AuthorClassEmail")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PublishDate")
                        .HasColumnType("int");

                    b.HasKey("Title");

                    b.HasIndex("AuthorClassEmail");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("MathiasMumbohWeb1001.Pages.Models.BlogClass", b =>
                {
                    b.HasOne("MathiasMumbohWeb1001.Pages.Models.AuthorClass", "AuthorClass")
                        .WithMany("BlogClass")
                        .HasForeignKey("AuthorClassEmail");

                    b.Navigation("AuthorClass");
                });

            modelBuilder.Entity("MathiasMumbohWeb1001.Pages.Models.AuthorClass", b =>
                {
                    b.Navigation("BlogClass");
                });
#pragma warning restore 612, 618
        }
    }
}
