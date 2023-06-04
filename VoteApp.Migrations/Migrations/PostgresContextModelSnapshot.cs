﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using VoteApp.Database;

#nullable disable

namespace VoteApp.Migrations.Migrations
{
    [DbContext(typeof(PostgresContext))]
    partial class PostgresContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("VoteApp.Database.Candidate.CandidateModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("PreviewDocumentId")
                        .HasColumnType("integer");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Candidate");
                });

            modelBuilder.Entity("VoteApp.Database.CandidateDocument.CandidateDocumentModel", b =>
                {
                    b.Property<int>("CandidateId")
                        .HasColumnType("integer");

                    b.Property<int>("DocumentId")
                        .HasColumnType("integer");

                    b.HasKey("CandidateId", "DocumentId");

                    b.HasIndex("DocumentId");

                    b.ToTable("CandidateDocument");
                });

            modelBuilder.Entity("VoteApp.Database.Document.DocumentModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("DocumentExtension")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("DocumentStatus")
                        .HasColumnType("integer");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Document");
                });

            modelBuilder.Entity("VoteApp.Database.User.UserModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("UserRole")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("VoteApp.Database.Candidate.CandidateModel", b =>
                {
                    b.HasOne("VoteApp.Database.User.UserModel", "User")
                        .WithMany("Candidates")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("VoteApp.Database.CandidateDocument.CandidateDocumentModel", b =>
                {
                    b.HasOne("VoteApp.Database.Candidate.CandidateModel", "Candidate")
                        .WithMany("CandidateDocuments")
                        .HasForeignKey("CandidateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VoteApp.Database.Document.DocumentModel", "Document")
                        .WithMany("CandidateDocuments")
                        .HasForeignKey("DocumentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Candidate");

                    b.Navigation("Document");
                });

            modelBuilder.Entity("VoteApp.Database.Document.DocumentModel", b =>
                {
                    b.HasOne("VoteApp.Database.User.UserModel", "UserModel")
                        .WithMany("Documents")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserModel");
                });

            modelBuilder.Entity("VoteApp.Database.Candidate.CandidateModel", b =>
                {
                    b.Navigation("CandidateDocuments");
                });

            modelBuilder.Entity("VoteApp.Database.Document.DocumentModel", b =>
                {
                    b.Navigation("CandidateDocuments");
                });

            modelBuilder.Entity("VoteApp.Database.User.UserModel", b =>
                {
                    b.Navigation("Candidates");

                    b.Navigation("Documents");
                });
#pragma warning restore 612, 618
        }
    }
}
