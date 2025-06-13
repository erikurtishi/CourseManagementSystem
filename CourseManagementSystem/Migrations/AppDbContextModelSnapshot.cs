﻿// <auto-generated />
using System;
using CourseManagementSystem.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CourseManagementSystem.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("CourseManagementSystem.Models.Course", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Instructor")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            Id = new Guid("53f35b80-1839-4d5c-86f6-93888eb13fc0"),
                            Description = "Description for Course 1",
                            Instructor = "Instructor 1",
                            Title = "Course 1"
                        },
                        new
                        {
                            Id = new Guid("a60aeaf7-e625-4669-ad8f-9a0790221cf3"),
                            Description = "Description for Course 2",
                            Instructor = "Instructor 2",
                            Title = "Course 2"
                        },
                        new
                        {
                            Id = new Guid("cc898a1c-b27b-4262-ad13-6bbfeec4f7d4"),
                            Description = "Description for Course 3",
                            Instructor = "Instructor 3",
                            Title = "Course 3"
                        },
                        new
                        {
                            Id = new Guid("a75abeea-87dc-4efb-a9eb-a41b47e6318c"),
                            Description = "Description for Course 4",
                            Instructor = "Instructor 4",
                            Title = "Course 4"
                        },
                        new
                        {
                            Id = new Guid("cd9b8323-dcc6-4d60-a0e6-b7be21b972af"),
                            Description = "Description for Course 5",
                            Instructor = "Instructor 5",
                            Title = "Course 5"
                        },
                        new
                        {
                            Id = new Guid("b04f4754-585d-456b-bf55-25e9a9d12aa3"),
                            Description = "Description for Course 6",
                            Instructor = "Instructor 6",
                            Title = "Course 6"
                        },
                        new
                        {
                            Id = new Guid("38c03fc4-a333-47e5-8028-5e1174b94077"),
                            Description = "Description for Course 7",
                            Instructor = "Instructor 7",
                            Title = "Course 7"
                        },
                        new
                        {
                            Id = new Guid("cc60e831-dc1a-4e52-9f00-df0450b65376"),
                            Description = "Description for Course 8",
                            Instructor = "Instructor 8",
                            Title = "Course 8"
                        },
                        new
                        {
                            Id = new Guid("c22f2cdf-267a-4e59-b5fa-d6797f6cb206"),
                            Description = "Description for Course 9",
                            Instructor = "Instructor 9",
                            Title = "Course 9"
                        },
                        new
                        {
                            Id = new Guid("0806acac-1ba6-4458-b4e1-7652cda13d40"),
                            Description = "Description for Course 10",
                            Instructor = "Instructor 10",
                            Title = "Course 10"
                        },
                        new
                        {
                            Id = new Guid("615ff614-9e69-4a51-8dfb-678f8d1d5a98"),
                            Description = "Description for Course 11",
                            Instructor = "Instructor 11",
                            Title = "Course 11"
                        },
                        new
                        {
                            Id = new Guid("43329c06-9981-4ce3-bdec-ac78c6ea4d46"),
                            Description = "Description for Course 12",
                            Instructor = "Instructor 12",
                            Title = "Course 12"
                        },
                        new
                        {
                            Id = new Guid("e65b9568-dfea-402c-9084-1db6c3064663"),
                            Description = "Description for Course 13",
                            Instructor = "Instructor 13",
                            Title = "Course 13"
                        },
                        new
                        {
                            Id = new Guid("a639a0d2-a4f6-41f0-b99d-a1c1b43a8b93"),
                            Description = "Description for Course 14",
                            Instructor = "Instructor 14",
                            Title = "Course 14"
                        },
                        new
                        {
                            Id = new Guid("dd94b31e-42a1-4319-9867-db96b40075da"),
                            Description = "Description for Course 15",
                            Instructor = "Instructor 15",
                            Title = "Course 15"
                        });
                });

            modelBuilder.Entity("CourseManagementSystem.Models.Enrollment", b =>
                {
                    b.Property<Guid>("StudentId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("CourseId")
                        .HasColumnType("uuid");

                    b.HasKey("StudentId", "CourseId");

                    b.HasIndex("CourseId");

                    b.ToTable("Enrollments");

                    b.HasData(
                        new
                        {
                            StudentId = new Guid("8338eb2f-71d6-4195-b6dc-352f25af234d"),
                            CourseId = new Guid("53f35b80-1839-4d5c-86f6-93888eb13fc0")
                        },
                        new
                        {
                            StudentId = new Guid("8338eb2f-71d6-4195-b6dc-352f25af234d"),
                            CourseId = new Guid("a60aeaf7-e625-4669-ad8f-9a0790221cf3")
                        },
                        new
                        {
                            StudentId = new Guid("8338eb2f-71d6-4195-b6dc-352f25af234d"),
                            CourseId = new Guid("cc898a1c-b27b-4262-ad13-6bbfeec4f7d4")
                        },
                        new
                        {
                            StudentId = new Guid("dcb26bb0-0ec4-4e21-9ad1-7c73ca17b594"),
                            CourseId = new Guid("a60aeaf7-e625-4669-ad8f-9a0790221cf3")
                        },
                        new
                        {
                            StudentId = new Guid("dcb26bb0-0ec4-4e21-9ad1-7c73ca17b594"),
                            CourseId = new Guid("cc898a1c-b27b-4262-ad13-6bbfeec4f7d4")
                        },
                        new
                        {
                            StudentId = new Guid("dcb26bb0-0ec4-4e21-9ad1-7c73ca17b594"),
                            CourseId = new Guid("a75abeea-87dc-4efb-a9eb-a41b47e6318c")
                        },
                        new
                        {
                            StudentId = new Guid("5a5e28ff-23ff-473f-a533-094b17433cb4"),
                            CourseId = new Guid("cc898a1c-b27b-4262-ad13-6bbfeec4f7d4")
                        },
                        new
                        {
                            StudentId = new Guid("5a5e28ff-23ff-473f-a533-094b17433cb4"),
                            CourseId = new Guid("a75abeea-87dc-4efb-a9eb-a41b47e6318c")
                        },
                        new
                        {
                            StudentId = new Guid("5a5e28ff-23ff-473f-a533-094b17433cb4"),
                            CourseId = new Guid("cd9b8323-dcc6-4d60-a0e6-b7be21b972af")
                        },
                        new
                        {
                            StudentId = new Guid("b901a08a-441b-425e-be3c-6e7d45b3c66e"),
                            CourseId = new Guid("a75abeea-87dc-4efb-a9eb-a41b47e6318c")
                        },
                        new
                        {
                            StudentId = new Guid("b901a08a-441b-425e-be3c-6e7d45b3c66e"),
                            CourseId = new Guid("cd9b8323-dcc6-4d60-a0e6-b7be21b972af")
                        },
                        new
                        {
                            StudentId = new Guid("b901a08a-441b-425e-be3c-6e7d45b3c66e"),
                            CourseId = new Guid("b04f4754-585d-456b-bf55-25e9a9d12aa3")
                        },
                        new
                        {
                            StudentId = new Guid("fd3116e7-74cf-438a-ba07-b35f63cb0087"),
                            CourseId = new Guid("cd9b8323-dcc6-4d60-a0e6-b7be21b972af")
                        },
                        new
                        {
                            StudentId = new Guid("fd3116e7-74cf-438a-ba07-b35f63cb0087"),
                            CourseId = new Guid("b04f4754-585d-456b-bf55-25e9a9d12aa3")
                        },
                        new
                        {
                            StudentId = new Guid("fd3116e7-74cf-438a-ba07-b35f63cb0087"),
                            CourseId = new Guid("38c03fc4-a333-47e5-8028-5e1174b94077")
                        },
                        new
                        {
                            StudentId = new Guid("248562aa-d0f9-4dc6-957f-379e133cdb30"),
                            CourseId = new Guid("b04f4754-585d-456b-bf55-25e9a9d12aa3")
                        },
                        new
                        {
                            StudentId = new Guid("248562aa-d0f9-4dc6-957f-379e133cdb30"),
                            CourseId = new Guid("38c03fc4-a333-47e5-8028-5e1174b94077")
                        },
                        new
                        {
                            StudentId = new Guid("248562aa-d0f9-4dc6-957f-379e133cdb30"),
                            CourseId = new Guid("cc60e831-dc1a-4e52-9f00-df0450b65376")
                        },
                        new
                        {
                            StudentId = new Guid("12b60aa5-fdca-458b-98c4-ed2e876b5f2d"),
                            CourseId = new Guid("38c03fc4-a333-47e5-8028-5e1174b94077")
                        },
                        new
                        {
                            StudentId = new Guid("12b60aa5-fdca-458b-98c4-ed2e876b5f2d"),
                            CourseId = new Guid("cc60e831-dc1a-4e52-9f00-df0450b65376")
                        },
                        new
                        {
                            StudentId = new Guid("12b60aa5-fdca-458b-98c4-ed2e876b5f2d"),
                            CourseId = new Guid("c22f2cdf-267a-4e59-b5fa-d6797f6cb206")
                        },
                        new
                        {
                            StudentId = new Guid("c6f2927a-7147-4c8d-8316-6a56271bba95"),
                            CourseId = new Guid("cc60e831-dc1a-4e52-9f00-df0450b65376")
                        },
                        new
                        {
                            StudentId = new Guid("c6f2927a-7147-4c8d-8316-6a56271bba95"),
                            CourseId = new Guid("c22f2cdf-267a-4e59-b5fa-d6797f6cb206")
                        },
                        new
                        {
                            StudentId = new Guid("c6f2927a-7147-4c8d-8316-6a56271bba95"),
                            CourseId = new Guid("0806acac-1ba6-4458-b4e1-7652cda13d40")
                        },
                        new
                        {
                            StudentId = new Guid("ce4612be-5d81-4cbe-809f-879f9b1a557c"),
                            CourseId = new Guid("c22f2cdf-267a-4e59-b5fa-d6797f6cb206")
                        },
                        new
                        {
                            StudentId = new Guid("ce4612be-5d81-4cbe-809f-879f9b1a557c"),
                            CourseId = new Guid("0806acac-1ba6-4458-b4e1-7652cda13d40")
                        },
                        new
                        {
                            StudentId = new Guid("ce4612be-5d81-4cbe-809f-879f9b1a557c"),
                            CourseId = new Guid("615ff614-9e69-4a51-8dfb-678f8d1d5a98")
                        },
                        new
                        {
                            StudentId = new Guid("c30f4634-27e5-490e-9f11-86ef5621e74b"),
                            CourseId = new Guid("0806acac-1ba6-4458-b4e1-7652cda13d40")
                        },
                        new
                        {
                            StudentId = new Guid("c30f4634-27e5-490e-9f11-86ef5621e74b"),
                            CourseId = new Guid("615ff614-9e69-4a51-8dfb-678f8d1d5a98")
                        },
                        new
                        {
                            StudentId = new Guid("c30f4634-27e5-490e-9f11-86ef5621e74b"),
                            CourseId = new Guid("43329c06-9981-4ce3-bdec-ac78c6ea4d46")
                        },
                        new
                        {
                            StudentId = new Guid("9e1231a8-10e4-4d12-871a-9f2151c2f1c3"),
                            CourseId = new Guid("615ff614-9e69-4a51-8dfb-678f8d1d5a98")
                        },
                        new
                        {
                            StudentId = new Guid("9e1231a8-10e4-4d12-871a-9f2151c2f1c3"),
                            CourseId = new Guid("43329c06-9981-4ce3-bdec-ac78c6ea4d46")
                        },
                        new
                        {
                            StudentId = new Guid("9e1231a8-10e4-4d12-871a-9f2151c2f1c3"),
                            CourseId = new Guid("e65b9568-dfea-402c-9084-1db6c3064663")
                        },
                        new
                        {
                            StudentId = new Guid("62cc3518-9cb7-45af-aec7-f9051c8fb108"),
                            CourseId = new Guid("43329c06-9981-4ce3-bdec-ac78c6ea4d46")
                        },
                        new
                        {
                            StudentId = new Guid("62cc3518-9cb7-45af-aec7-f9051c8fb108"),
                            CourseId = new Guid("e65b9568-dfea-402c-9084-1db6c3064663")
                        },
                        new
                        {
                            StudentId = new Guid("62cc3518-9cb7-45af-aec7-f9051c8fb108"),
                            CourseId = new Guid("a639a0d2-a4f6-41f0-b99d-a1c1b43a8b93")
                        },
                        new
                        {
                            StudentId = new Guid("90446585-bead-4ce2-b7bd-12c0089f086a"),
                            CourseId = new Guid("e65b9568-dfea-402c-9084-1db6c3064663")
                        },
                        new
                        {
                            StudentId = new Guid("90446585-bead-4ce2-b7bd-12c0089f086a"),
                            CourseId = new Guid("a639a0d2-a4f6-41f0-b99d-a1c1b43a8b93")
                        },
                        new
                        {
                            StudentId = new Guid("90446585-bead-4ce2-b7bd-12c0089f086a"),
                            CourseId = new Guid("dd94b31e-42a1-4319-9867-db96b40075da")
                        },
                        new
                        {
                            StudentId = new Guid("031ac92b-ed67-4aa9-94e2-8d5c5a8fd057"),
                            CourseId = new Guid("a639a0d2-a4f6-41f0-b99d-a1c1b43a8b93")
                        },
                        new
                        {
                            StudentId = new Guid("031ac92b-ed67-4aa9-94e2-8d5c5a8fd057"),
                            CourseId = new Guid("dd94b31e-42a1-4319-9867-db96b40075da")
                        },
                        new
                        {
                            StudentId = new Guid("031ac92b-ed67-4aa9-94e2-8d5c5a8fd057"),
                            CourseId = new Guid("53f35b80-1839-4d5c-86f6-93888eb13fc0")
                        },
                        new
                        {
                            StudentId = new Guid("5b30fbec-a0f9-4072-bd6b-7044985fd7f5"),
                            CourseId = new Guid("dd94b31e-42a1-4319-9867-db96b40075da")
                        },
                        new
                        {
                            StudentId = new Guid("5b30fbec-a0f9-4072-bd6b-7044985fd7f5"),
                            CourseId = new Guid("53f35b80-1839-4d5c-86f6-93888eb13fc0")
                        },
                        new
                        {
                            StudentId = new Guid("5b30fbec-a0f9-4072-bd6b-7044985fd7f5"),
                            CourseId = new Guid("a60aeaf7-e625-4669-ad8f-9a0790221cf3")
                        });
                });

            modelBuilder.Entity("CourseManagementSystem.Models.Student", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = new Guid("8338eb2f-71d6-4195-b6dc-352f25af234d"),
                            Email = "student1@school.edu",
                            Name = "Student 1"
                        },
                        new
                        {
                            Id = new Guid("dcb26bb0-0ec4-4e21-9ad1-7c73ca17b594"),
                            Email = "student2@school.edu",
                            Name = "Student 2"
                        },
                        new
                        {
                            Id = new Guid("5a5e28ff-23ff-473f-a533-094b17433cb4"),
                            Email = "student3@school.edu",
                            Name = "Student 3"
                        },
                        new
                        {
                            Id = new Guid("b901a08a-441b-425e-be3c-6e7d45b3c66e"),
                            Email = "student4@school.edu",
                            Name = "Student 4"
                        },
                        new
                        {
                            Id = new Guid("fd3116e7-74cf-438a-ba07-b35f63cb0087"),
                            Email = "student5@school.edu",
                            Name = "Student 5"
                        },
                        new
                        {
                            Id = new Guid("248562aa-d0f9-4dc6-957f-379e133cdb30"),
                            Email = "student6@school.edu",
                            Name = "Student 6"
                        },
                        new
                        {
                            Id = new Guid("12b60aa5-fdca-458b-98c4-ed2e876b5f2d"),
                            Email = "student7@school.edu",
                            Name = "Student 7"
                        },
                        new
                        {
                            Id = new Guid("c6f2927a-7147-4c8d-8316-6a56271bba95"),
                            Email = "student8@school.edu",
                            Name = "Student 8"
                        },
                        new
                        {
                            Id = new Guid("ce4612be-5d81-4cbe-809f-879f9b1a557c"),
                            Email = "student9@school.edu",
                            Name = "Student 9"
                        },
                        new
                        {
                            Id = new Guid("c30f4634-27e5-490e-9f11-86ef5621e74b"),
                            Email = "student10@school.edu",
                            Name = "Student 10"
                        },
                        new
                        {
                            Id = new Guid("9e1231a8-10e4-4d12-871a-9f2151c2f1c3"),
                            Email = "student11@school.edu",
                            Name = "Student 11"
                        },
                        new
                        {
                            Id = new Guid("62cc3518-9cb7-45af-aec7-f9051c8fb108"),
                            Email = "student12@school.edu",
                            Name = "Student 12"
                        },
                        new
                        {
                            Id = new Guid("90446585-bead-4ce2-b7bd-12c0089f086a"),
                            Email = "student13@school.edu",
                            Name = "Student 13"
                        },
                        new
                        {
                            Id = new Guid("031ac92b-ed67-4aa9-94e2-8d5c5a8fd057"),
                            Email = "student14@school.edu",
                            Name = "Student 14"
                        },
                        new
                        {
                            Id = new Guid("5b30fbec-a0f9-4072-bd6b-7044985fd7f5"),
                            Email = "student15@school.edu",
                            Name = "Student 15"
                        });
                });

            modelBuilder.Entity("CourseManagementSystem.Models.Enrollment", b =>
                {
                    b.HasOne("CourseManagementSystem.Models.Course", "Course")
                        .WithMany("Enrollments")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CourseManagementSystem.Models.Student", "Student")
                        .WithMany("Enrollments")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("CourseManagementSystem.Models.Course", b =>
                {
                    b.Navigation("Enrollments");
                });

            modelBuilder.Entity("CourseManagementSystem.Models.Student", b =>
                {
                    b.Navigation("Enrollments");
                });
#pragma warning restore 612, 618
        }
    }
}
