using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CourseManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class SeedFifteenEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("0845e442-4f64-455d-b156-c424a40c1e88"), new Guid("b6756c5b-00f2-4a72-b059-c483ac8191ca") });

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("5022858f-eaf2-4735-8be5-bdea19e16979"), new Guid("b6756c5b-00f2-4a72-b059-c483ac8191ca") });

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("0845e442-4f64-455d-b156-c424a40c1e88"), new Guid("e8c5a032-1f06-4d0f-a947-db726f9b8a45") });

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("0845e442-4f64-455d-b156-c424a40c1e88"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("5022858f-eaf2-4735-8be5-bdea19e16979"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("b6756c5b-00f2-4a72-b059-c483ac8191ca"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("e8c5a032-1f06-4d0f-a947-db726f9b8a45"));

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Description", "Instructor", "Title" },
                values: new object[,]
                {
                    { new Guid("0806acac-1ba6-4458-b4e1-7652cda13d40"), "Description for Course 10", "Instructor 10", "Course 10" },
                    { new Guid("38c03fc4-a333-47e5-8028-5e1174b94077"), "Description for Course 7", "Instructor 7", "Course 7" },
                    { new Guid("43329c06-9981-4ce3-bdec-ac78c6ea4d46"), "Description for Course 12", "Instructor 12", "Course 12" },
                    { new Guid("53f35b80-1839-4d5c-86f6-93888eb13fc0"), "Description for Course 1", "Instructor 1", "Course 1" },
                    { new Guid("615ff614-9e69-4a51-8dfb-678f8d1d5a98"), "Description for Course 11", "Instructor 11", "Course 11" },
                    { new Guid("a60aeaf7-e625-4669-ad8f-9a0790221cf3"), "Description for Course 2", "Instructor 2", "Course 2" },
                    { new Guid("a639a0d2-a4f6-41f0-b99d-a1c1b43a8b93"), "Description for Course 14", "Instructor 14", "Course 14" },
                    { new Guid("a75abeea-87dc-4efb-a9eb-a41b47e6318c"), "Description for Course 4", "Instructor 4", "Course 4" },
                    { new Guid("b04f4754-585d-456b-bf55-25e9a9d12aa3"), "Description for Course 6", "Instructor 6", "Course 6" },
                    { new Guid("c22f2cdf-267a-4e59-b5fa-d6797f6cb206"), "Description for Course 9", "Instructor 9", "Course 9" },
                    { new Guid("cc60e831-dc1a-4e52-9f00-df0450b65376"), "Description for Course 8", "Instructor 8", "Course 8" },
                    { new Guid("cc898a1c-b27b-4262-ad13-6bbfeec4f7d4"), "Description for Course 3", "Instructor 3", "Course 3" },
                    { new Guid("cd9b8323-dcc6-4d60-a0e6-b7be21b972af"), "Description for Course 5", "Instructor 5", "Course 5" },
                    { new Guid("dd94b31e-42a1-4319-9867-db96b40075da"), "Description for Course 15", "Instructor 15", "Course 15" },
                    { new Guid("e65b9568-dfea-402c-9084-1db6c3064663"), "Description for Course 13", "Instructor 13", "Course 13" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[,]
                {
                    { new Guid("031ac92b-ed67-4aa9-94e2-8d5c5a8fd057"), "student14@school.edu", "Student 14" },
                    { new Guid("12b60aa5-fdca-458b-98c4-ed2e876b5f2d"), "student7@school.edu", "Student 7" },
                    { new Guid("248562aa-d0f9-4dc6-957f-379e133cdb30"), "student6@school.edu", "Student 6" },
                    { new Guid("5a5e28ff-23ff-473f-a533-094b17433cb4"), "student3@school.edu", "Student 3" },
                    { new Guid("5b30fbec-a0f9-4072-bd6b-7044985fd7f5"), "student15@school.edu", "Student 15" },
                    { new Guid("62cc3518-9cb7-45af-aec7-f9051c8fb108"), "student12@school.edu", "Student 12" },
                    { new Guid("8338eb2f-71d6-4195-b6dc-352f25af234d"), "student1@school.edu", "Student 1" },
                    { new Guid("90446585-bead-4ce2-b7bd-12c0089f086a"), "student13@school.edu", "Student 13" },
                    { new Guid("9e1231a8-10e4-4d12-871a-9f2151c2f1c3"), "student11@school.edu", "Student 11" },
                    { new Guid("b901a08a-441b-425e-be3c-6e7d45b3c66e"), "student4@school.edu", "Student 4" },
                    { new Guid("c30f4634-27e5-490e-9f11-86ef5621e74b"), "student10@school.edu", "Student 10" },
                    { new Guid("c6f2927a-7147-4c8d-8316-6a56271bba95"), "student8@school.edu", "Student 8" },
                    { new Guid("ce4612be-5d81-4cbe-809f-879f9b1a557c"), "student9@school.edu", "Student 9" },
                    { new Guid("dcb26bb0-0ec4-4e21-9ad1-7c73ca17b594"), "student2@school.edu", "Student 2" },
                    { new Guid("fd3116e7-74cf-438a-ba07-b35f63cb0087"), "student5@school.edu", "Student 5" }
                });

            migrationBuilder.InsertData(
                table: "Enrollments",
                columns: new[] { "CourseId", "StudentId" },
                values: new object[,]
                {
                    { new Guid("53f35b80-1839-4d5c-86f6-93888eb13fc0"), new Guid("031ac92b-ed67-4aa9-94e2-8d5c5a8fd057") },
                    { new Guid("a639a0d2-a4f6-41f0-b99d-a1c1b43a8b93"), new Guid("031ac92b-ed67-4aa9-94e2-8d5c5a8fd057") },
                    { new Guid("dd94b31e-42a1-4319-9867-db96b40075da"), new Guid("031ac92b-ed67-4aa9-94e2-8d5c5a8fd057") },
                    { new Guid("38c03fc4-a333-47e5-8028-5e1174b94077"), new Guid("12b60aa5-fdca-458b-98c4-ed2e876b5f2d") },
                    { new Guid("c22f2cdf-267a-4e59-b5fa-d6797f6cb206"), new Guid("12b60aa5-fdca-458b-98c4-ed2e876b5f2d") },
                    { new Guid("cc60e831-dc1a-4e52-9f00-df0450b65376"), new Guid("12b60aa5-fdca-458b-98c4-ed2e876b5f2d") },
                    { new Guid("38c03fc4-a333-47e5-8028-5e1174b94077"), new Guid("248562aa-d0f9-4dc6-957f-379e133cdb30") },
                    { new Guid("b04f4754-585d-456b-bf55-25e9a9d12aa3"), new Guid("248562aa-d0f9-4dc6-957f-379e133cdb30") },
                    { new Guid("cc60e831-dc1a-4e52-9f00-df0450b65376"), new Guid("248562aa-d0f9-4dc6-957f-379e133cdb30") },
                    { new Guid("a75abeea-87dc-4efb-a9eb-a41b47e6318c"), new Guid("5a5e28ff-23ff-473f-a533-094b17433cb4") },
                    { new Guid("cc898a1c-b27b-4262-ad13-6bbfeec4f7d4"), new Guid("5a5e28ff-23ff-473f-a533-094b17433cb4") },
                    { new Guid("cd9b8323-dcc6-4d60-a0e6-b7be21b972af"), new Guid("5a5e28ff-23ff-473f-a533-094b17433cb4") },
                    { new Guid("53f35b80-1839-4d5c-86f6-93888eb13fc0"), new Guid("5b30fbec-a0f9-4072-bd6b-7044985fd7f5") },
                    { new Guid("a60aeaf7-e625-4669-ad8f-9a0790221cf3"), new Guid("5b30fbec-a0f9-4072-bd6b-7044985fd7f5") },
                    { new Guid("dd94b31e-42a1-4319-9867-db96b40075da"), new Guid("5b30fbec-a0f9-4072-bd6b-7044985fd7f5") },
                    { new Guid("43329c06-9981-4ce3-bdec-ac78c6ea4d46"), new Guid("62cc3518-9cb7-45af-aec7-f9051c8fb108") },
                    { new Guid("a639a0d2-a4f6-41f0-b99d-a1c1b43a8b93"), new Guid("62cc3518-9cb7-45af-aec7-f9051c8fb108") },
                    { new Guid("e65b9568-dfea-402c-9084-1db6c3064663"), new Guid("62cc3518-9cb7-45af-aec7-f9051c8fb108") },
                    { new Guid("53f35b80-1839-4d5c-86f6-93888eb13fc0"), new Guid("8338eb2f-71d6-4195-b6dc-352f25af234d") },
                    { new Guid("a60aeaf7-e625-4669-ad8f-9a0790221cf3"), new Guid("8338eb2f-71d6-4195-b6dc-352f25af234d") },
                    { new Guid("cc898a1c-b27b-4262-ad13-6bbfeec4f7d4"), new Guid("8338eb2f-71d6-4195-b6dc-352f25af234d") },
                    { new Guid("a639a0d2-a4f6-41f0-b99d-a1c1b43a8b93"), new Guid("90446585-bead-4ce2-b7bd-12c0089f086a") },
                    { new Guid("dd94b31e-42a1-4319-9867-db96b40075da"), new Guid("90446585-bead-4ce2-b7bd-12c0089f086a") },
                    { new Guid("e65b9568-dfea-402c-9084-1db6c3064663"), new Guid("90446585-bead-4ce2-b7bd-12c0089f086a") },
                    { new Guid("43329c06-9981-4ce3-bdec-ac78c6ea4d46"), new Guid("9e1231a8-10e4-4d12-871a-9f2151c2f1c3") },
                    { new Guid("615ff614-9e69-4a51-8dfb-678f8d1d5a98"), new Guid("9e1231a8-10e4-4d12-871a-9f2151c2f1c3") },
                    { new Guid("e65b9568-dfea-402c-9084-1db6c3064663"), new Guid("9e1231a8-10e4-4d12-871a-9f2151c2f1c3") },
                    { new Guid("a75abeea-87dc-4efb-a9eb-a41b47e6318c"), new Guid("b901a08a-441b-425e-be3c-6e7d45b3c66e") },
                    { new Guid("b04f4754-585d-456b-bf55-25e9a9d12aa3"), new Guid("b901a08a-441b-425e-be3c-6e7d45b3c66e") },
                    { new Guid("cd9b8323-dcc6-4d60-a0e6-b7be21b972af"), new Guid("b901a08a-441b-425e-be3c-6e7d45b3c66e") },
                    { new Guid("0806acac-1ba6-4458-b4e1-7652cda13d40"), new Guid("c30f4634-27e5-490e-9f11-86ef5621e74b") },
                    { new Guid("43329c06-9981-4ce3-bdec-ac78c6ea4d46"), new Guid("c30f4634-27e5-490e-9f11-86ef5621e74b") },
                    { new Guid("615ff614-9e69-4a51-8dfb-678f8d1d5a98"), new Guid("c30f4634-27e5-490e-9f11-86ef5621e74b") },
                    { new Guid("0806acac-1ba6-4458-b4e1-7652cda13d40"), new Guid("c6f2927a-7147-4c8d-8316-6a56271bba95") },
                    { new Guid("c22f2cdf-267a-4e59-b5fa-d6797f6cb206"), new Guid("c6f2927a-7147-4c8d-8316-6a56271bba95") },
                    { new Guid("cc60e831-dc1a-4e52-9f00-df0450b65376"), new Guid("c6f2927a-7147-4c8d-8316-6a56271bba95") },
                    { new Guid("0806acac-1ba6-4458-b4e1-7652cda13d40"), new Guid("ce4612be-5d81-4cbe-809f-879f9b1a557c") },
                    { new Guid("615ff614-9e69-4a51-8dfb-678f8d1d5a98"), new Guid("ce4612be-5d81-4cbe-809f-879f9b1a557c") },
                    { new Guid("c22f2cdf-267a-4e59-b5fa-d6797f6cb206"), new Guid("ce4612be-5d81-4cbe-809f-879f9b1a557c") },
                    { new Guid("a60aeaf7-e625-4669-ad8f-9a0790221cf3"), new Guid("dcb26bb0-0ec4-4e21-9ad1-7c73ca17b594") },
                    { new Guid("a75abeea-87dc-4efb-a9eb-a41b47e6318c"), new Guid("dcb26bb0-0ec4-4e21-9ad1-7c73ca17b594") },
                    { new Guid("cc898a1c-b27b-4262-ad13-6bbfeec4f7d4"), new Guid("dcb26bb0-0ec4-4e21-9ad1-7c73ca17b594") },
                    { new Guid("38c03fc4-a333-47e5-8028-5e1174b94077"), new Guid("fd3116e7-74cf-438a-ba07-b35f63cb0087") },
                    { new Guid("b04f4754-585d-456b-bf55-25e9a9d12aa3"), new Guid("fd3116e7-74cf-438a-ba07-b35f63cb0087") },
                    { new Guid("cd9b8323-dcc6-4d60-a0e6-b7be21b972af"), new Guid("fd3116e7-74cf-438a-ba07-b35f63cb0087") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("53f35b80-1839-4d5c-86f6-93888eb13fc0"), new Guid("031ac92b-ed67-4aa9-94e2-8d5c5a8fd057") });

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("a639a0d2-a4f6-41f0-b99d-a1c1b43a8b93"), new Guid("031ac92b-ed67-4aa9-94e2-8d5c5a8fd057") });

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("dd94b31e-42a1-4319-9867-db96b40075da"), new Guid("031ac92b-ed67-4aa9-94e2-8d5c5a8fd057") });

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("38c03fc4-a333-47e5-8028-5e1174b94077"), new Guid("12b60aa5-fdca-458b-98c4-ed2e876b5f2d") });

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("c22f2cdf-267a-4e59-b5fa-d6797f6cb206"), new Guid("12b60aa5-fdca-458b-98c4-ed2e876b5f2d") });

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("cc60e831-dc1a-4e52-9f00-df0450b65376"), new Guid("12b60aa5-fdca-458b-98c4-ed2e876b5f2d") });

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("38c03fc4-a333-47e5-8028-5e1174b94077"), new Guid("248562aa-d0f9-4dc6-957f-379e133cdb30") });

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("b04f4754-585d-456b-bf55-25e9a9d12aa3"), new Guid("248562aa-d0f9-4dc6-957f-379e133cdb30") });

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("cc60e831-dc1a-4e52-9f00-df0450b65376"), new Guid("248562aa-d0f9-4dc6-957f-379e133cdb30") });

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("a75abeea-87dc-4efb-a9eb-a41b47e6318c"), new Guid("5a5e28ff-23ff-473f-a533-094b17433cb4") });

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("cc898a1c-b27b-4262-ad13-6bbfeec4f7d4"), new Guid("5a5e28ff-23ff-473f-a533-094b17433cb4") });

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("cd9b8323-dcc6-4d60-a0e6-b7be21b972af"), new Guid("5a5e28ff-23ff-473f-a533-094b17433cb4") });

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("53f35b80-1839-4d5c-86f6-93888eb13fc0"), new Guid("5b30fbec-a0f9-4072-bd6b-7044985fd7f5") });

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("a60aeaf7-e625-4669-ad8f-9a0790221cf3"), new Guid("5b30fbec-a0f9-4072-bd6b-7044985fd7f5") });

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("dd94b31e-42a1-4319-9867-db96b40075da"), new Guid("5b30fbec-a0f9-4072-bd6b-7044985fd7f5") });

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("43329c06-9981-4ce3-bdec-ac78c6ea4d46"), new Guid("62cc3518-9cb7-45af-aec7-f9051c8fb108") });

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("a639a0d2-a4f6-41f0-b99d-a1c1b43a8b93"), new Guid("62cc3518-9cb7-45af-aec7-f9051c8fb108") });

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("e65b9568-dfea-402c-9084-1db6c3064663"), new Guid("62cc3518-9cb7-45af-aec7-f9051c8fb108") });

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("53f35b80-1839-4d5c-86f6-93888eb13fc0"), new Guid("8338eb2f-71d6-4195-b6dc-352f25af234d") });

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("a60aeaf7-e625-4669-ad8f-9a0790221cf3"), new Guid("8338eb2f-71d6-4195-b6dc-352f25af234d") });

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("cc898a1c-b27b-4262-ad13-6bbfeec4f7d4"), new Guid("8338eb2f-71d6-4195-b6dc-352f25af234d") });

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("a639a0d2-a4f6-41f0-b99d-a1c1b43a8b93"), new Guid("90446585-bead-4ce2-b7bd-12c0089f086a") });

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("dd94b31e-42a1-4319-9867-db96b40075da"), new Guid("90446585-bead-4ce2-b7bd-12c0089f086a") });

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("e65b9568-dfea-402c-9084-1db6c3064663"), new Guid("90446585-bead-4ce2-b7bd-12c0089f086a") });

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("43329c06-9981-4ce3-bdec-ac78c6ea4d46"), new Guid("9e1231a8-10e4-4d12-871a-9f2151c2f1c3") });

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("615ff614-9e69-4a51-8dfb-678f8d1d5a98"), new Guid("9e1231a8-10e4-4d12-871a-9f2151c2f1c3") });

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("e65b9568-dfea-402c-9084-1db6c3064663"), new Guid("9e1231a8-10e4-4d12-871a-9f2151c2f1c3") });

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("a75abeea-87dc-4efb-a9eb-a41b47e6318c"), new Guid("b901a08a-441b-425e-be3c-6e7d45b3c66e") });

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("b04f4754-585d-456b-bf55-25e9a9d12aa3"), new Guid("b901a08a-441b-425e-be3c-6e7d45b3c66e") });

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("cd9b8323-dcc6-4d60-a0e6-b7be21b972af"), new Guid("b901a08a-441b-425e-be3c-6e7d45b3c66e") });

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("0806acac-1ba6-4458-b4e1-7652cda13d40"), new Guid("c30f4634-27e5-490e-9f11-86ef5621e74b") });

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("43329c06-9981-4ce3-bdec-ac78c6ea4d46"), new Guid("c30f4634-27e5-490e-9f11-86ef5621e74b") });

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("615ff614-9e69-4a51-8dfb-678f8d1d5a98"), new Guid("c30f4634-27e5-490e-9f11-86ef5621e74b") });

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("0806acac-1ba6-4458-b4e1-7652cda13d40"), new Guid("c6f2927a-7147-4c8d-8316-6a56271bba95") });

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("c22f2cdf-267a-4e59-b5fa-d6797f6cb206"), new Guid("c6f2927a-7147-4c8d-8316-6a56271bba95") });

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("cc60e831-dc1a-4e52-9f00-df0450b65376"), new Guid("c6f2927a-7147-4c8d-8316-6a56271bba95") });

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("0806acac-1ba6-4458-b4e1-7652cda13d40"), new Guid("ce4612be-5d81-4cbe-809f-879f9b1a557c") });

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("615ff614-9e69-4a51-8dfb-678f8d1d5a98"), new Guid("ce4612be-5d81-4cbe-809f-879f9b1a557c") });

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("c22f2cdf-267a-4e59-b5fa-d6797f6cb206"), new Guid("ce4612be-5d81-4cbe-809f-879f9b1a557c") });

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("a60aeaf7-e625-4669-ad8f-9a0790221cf3"), new Guid("dcb26bb0-0ec4-4e21-9ad1-7c73ca17b594") });

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("a75abeea-87dc-4efb-a9eb-a41b47e6318c"), new Guid("dcb26bb0-0ec4-4e21-9ad1-7c73ca17b594") });

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("cc898a1c-b27b-4262-ad13-6bbfeec4f7d4"), new Guid("dcb26bb0-0ec4-4e21-9ad1-7c73ca17b594") });

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("38c03fc4-a333-47e5-8028-5e1174b94077"), new Guid("fd3116e7-74cf-438a-ba07-b35f63cb0087") });

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("b04f4754-585d-456b-bf55-25e9a9d12aa3"), new Guid("fd3116e7-74cf-438a-ba07-b35f63cb0087") });

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("cd9b8323-dcc6-4d60-a0e6-b7be21b972af"), new Guid("fd3116e7-74cf-438a-ba07-b35f63cb0087") });

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("0806acac-1ba6-4458-b4e1-7652cda13d40"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("38c03fc4-a333-47e5-8028-5e1174b94077"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("43329c06-9981-4ce3-bdec-ac78c6ea4d46"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("53f35b80-1839-4d5c-86f6-93888eb13fc0"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("615ff614-9e69-4a51-8dfb-678f8d1d5a98"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("a60aeaf7-e625-4669-ad8f-9a0790221cf3"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("a639a0d2-a4f6-41f0-b99d-a1c1b43a8b93"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("a75abeea-87dc-4efb-a9eb-a41b47e6318c"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("b04f4754-585d-456b-bf55-25e9a9d12aa3"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("c22f2cdf-267a-4e59-b5fa-d6797f6cb206"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("cc60e831-dc1a-4e52-9f00-df0450b65376"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("cc898a1c-b27b-4262-ad13-6bbfeec4f7d4"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("cd9b8323-dcc6-4d60-a0e6-b7be21b972af"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("dd94b31e-42a1-4319-9867-db96b40075da"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("e65b9568-dfea-402c-9084-1db6c3064663"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("031ac92b-ed67-4aa9-94e2-8d5c5a8fd057"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("12b60aa5-fdca-458b-98c4-ed2e876b5f2d"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("248562aa-d0f9-4dc6-957f-379e133cdb30"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("5a5e28ff-23ff-473f-a533-094b17433cb4"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("5b30fbec-a0f9-4072-bd6b-7044985fd7f5"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("62cc3518-9cb7-45af-aec7-f9051c8fb108"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("8338eb2f-71d6-4195-b6dc-352f25af234d"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("90446585-bead-4ce2-b7bd-12c0089f086a"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("9e1231a8-10e4-4d12-871a-9f2151c2f1c3"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("b901a08a-441b-425e-be3c-6e7d45b3c66e"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("c30f4634-27e5-490e-9f11-86ef5621e74b"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("c6f2927a-7147-4c8d-8316-6a56271bba95"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("ce4612be-5d81-4cbe-809f-879f9b1a557c"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("dcb26bb0-0ec4-4e21-9ad1-7c73ca17b594"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("fd3116e7-74cf-438a-ba07-b35f63cb0087"));

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Description", "Instructor", "Title" },
                values: new object[,]
                {
                    { new Guid("0845e442-4f64-455d-b156-c424a40c1e88"), "Mechanics and Thermodynamics", "Prof. Einstein", "Physics 201" },
                    { new Guid("5022858f-eaf2-4735-8be5-bdea19e16979"), "Basic Algebra and Calculus", "Prof. Newton", "Math 101" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[,]
                {
                    { new Guid("b6756c5b-00f2-4a72-b059-c483ac8191ca"), "alice@school.edu", "Alice Smith" },
                    { new Guid("e8c5a032-1f06-4d0f-a947-db726f9b8a45"), "bob@school.edu", "Bob Johnson" }
                });

            migrationBuilder.InsertData(
                table: "Enrollments",
                columns: new[] { "CourseId", "StudentId" },
                values: new object[,]
                {
                    { new Guid("0845e442-4f64-455d-b156-c424a40c1e88"), new Guid("b6756c5b-00f2-4a72-b059-c483ac8191ca") },
                    { new Guid("5022858f-eaf2-4735-8be5-bdea19e16979"), new Guid("b6756c5b-00f2-4a72-b059-c483ac8191ca") },
                    { new Guid("0845e442-4f64-455d-b156-c424a40c1e88"), new Guid("e8c5a032-1f06-4d0f-a947-db726f9b8a45") }
                });
        }
    }
}
