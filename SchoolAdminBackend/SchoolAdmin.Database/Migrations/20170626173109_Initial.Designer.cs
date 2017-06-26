using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using SchoolAdmin.Database;

namespace SchoolAdmin.Database.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20170626173109_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SchoolAdmin.Core.Entities.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Number");

                    b.Property<int>("SchoolId");

                    b.HasKey("Id");

                    b.HasIndex("SchoolId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("SchoolAdmin.Core.Entities.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CourseId");

                    b.Property<int>("Number");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("SchoolAdmin.Core.Entities.Parent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<bool>("IsLiceumAlumni");

                    b.Property<string>("LastName");

                    b.HasKey("Id");

                    b.ToTable("Parents");
                });

            modelBuilder.Entity("SchoolAdmin.Core.Entities.ParentStudent", b =>
                {
                    b.Property<int>("ParentID");

                    b.Property<int>("StudentId");

                    b.HasKey("ParentID", "StudentId");

                    b.HasIndex("StudentId");

                    b.ToTable("ParentStudent");
                });

            modelBuilder.Entity("SchoolAdmin.Core.Entities.Payment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Amount");

                    b.Property<string>("Comment");

                    b.Property<byte>("Month");

                    b.Property<DateTime>("PaymentDate");

                    b.Property<string>("ReceiptUrl");

                    b.Property<int>("StudentId");

                    b.Property<int>("Year");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("SchoolAdmin.Core.Entities.School", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Name");

                    b.HasKey("Id");

                    b.ToTable("Schools");
                });

            modelBuilder.Entity("SchoolAdmin.Core.Entities.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstName");

                    b.Property<int?>("GroupId");

                    b.Property<string>("LastName");

                    b.Property<string>("PhotoUrl");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("SchoolAdmin.Core.Entities.Visit", b =>
                {
                    b.Property<int>("StudentId");

                    b.Property<DateTime>("Date");

                    b.HasKey("StudentId", "Date");

                    b.ToTable("Visit");
                });

            modelBuilder.Entity("SchoolAdmin.Core.Entities.Course", b =>
                {
                    b.HasOne("SchoolAdmin.Core.Entities.School", "School")
                        .WithMany("Cources")
                        .HasForeignKey("SchoolId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SchoolAdmin.Core.Entities.Group", b =>
                {
                    b.HasOne("SchoolAdmin.Core.Entities.Course", "Course")
                        .WithMany("Groups")
                        .HasForeignKey("CourseId");
                });

            modelBuilder.Entity("SchoolAdmin.Core.Entities.ParentStudent", b =>
                {
                    b.HasOne("SchoolAdmin.Core.Entities.Parent", "Parent")
                        .WithMany("ParentChildren")
                        .HasForeignKey("ParentID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SchoolAdmin.Core.Entities.Student", "Student")
                        .WithMany("StudentParents")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SchoolAdmin.Core.Entities.Payment", b =>
                {
                    b.HasOne("SchoolAdmin.Core.Entities.Student", "Student")
                        .WithMany("Payments")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SchoolAdmin.Core.Entities.Student", b =>
                {
                    b.HasOne("SchoolAdmin.Core.Entities.Group", "Group")
                        .WithMany("Students")
                        .HasForeignKey("GroupId");
                });

            modelBuilder.Entity("SchoolAdmin.Core.Entities.Visit", b =>
                {
                    b.HasOne("SchoolAdmin.Core.Entities.Student", "Student")
                        .WithMany("Visits")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
