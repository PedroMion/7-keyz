﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace _7keyz.Migrations
{
    [DbContext(typeof(KeyzContext))]
    [Migration("20240420144835_AddingReferenceSecondTry")]
    partial class AddingReferenceSecondTry
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Chats", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StatusCode")
                        .HasColumnType("int");

                    b.Property<DateTime>("ValidFrom")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ValidTo")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Chats");
                });

            modelBuilder.Entity("ChatsUsers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("chatsId")
                        .HasColumnType("int");

                    b.Property<int>("usersId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("chatsId");

                    b.HasIndex("usersId");

                    b.ToTable("ChatsUsers");
                });

            modelBuilder.Entity("Messages", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("ChatsId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ChatsId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("MemberSince")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ChatsUsers", b =>
                {
                    b.HasOne("Chats", "Chats")
                        .WithMany("Users")
                        .HasForeignKey("chatsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Users", "Users")
                        .WithMany("Chats")
                        .HasForeignKey("usersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Chats");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Messages", b =>
                {
                    b.HasOne("Chats", null)
                        .WithMany("Messages")
                        .HasForeignKey("ChatsId");
                });

            modelBuilder.Entity("Chats", b =>
                {
                    b.Navigation("Messages");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Users", b =>
                {
                    b.Navigation("Chats");
                });
#pragma warning restore 612, 618
        }
    }
}