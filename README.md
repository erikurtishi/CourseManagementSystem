# 📚 Course Management API

A lightweight, RESTful API built with **.NET 8.0** to manage students, courses, and enrollments in a university-like environment. This project supports both local, containerized and deployed version and is integrated with CI/CD and Azure services.

---

## 🚀 Features

- Full **CRUD** functionality for **Students** and **Courses**
- **Enroll/Unenroll** students in/from courses
- View all courses a student is enrolled in
- View all students enrolled in a course
- Follows **RESTful best practices**
- Uses **Repository Pattern** and **DTOs** for clean architecture
- JSON responses with proper HTTP status codes
- Swagger UI for interactive API testing
- PostgreSQL as the production database (hosted on Azure)
- **Seed data** is automatically applied on first run
- Dockerized for easy local development
- Publicly accessible APIs via deployed Azure App Service
- Integrated **CI/CD with GitHub Actions** for automatic deployment

---

## 🛠️ Tech Stack

- **Framework**: ASP.NET Core 8.0
- **Language**: C#
- **Architecture**: RESTful API
- **Docs**: Swagger/OpenAPI
- **Containerization**: Docker
- **CI/CD**: GitHub Actions
- **Deployment**: Azure App Service

---

## 🧱 Architecture Overview

This project follows the **Layered Architecture** with:

- **Controllers**: Handle HTTP requests and route to services/repositories
- **Models**: First Logical made Objects
- **DTOs**: Data Transfer Objects that shape request and response bodies
- **Repositories**: Abstract database logic for cleaner separation of concerns
- **EF Core**: Entity Framework Core for ORM and PostgreSQL interaction
- **Seed Data**: Automatically seeds students, courses, and enrollments

## 📂 Project Structure

```
CourseManagementSystem/
├── Controllers/
│   ├── CoursesController.cs
│   ├── EnrollmentController.cs
│   └── StudentsController.cs
├── Data/
│   └── AppDbContext.cs
├── DTOs/
│   ├── CourseDTOs/
│   │   ├── CourseCreateDTO.cs
│   │   ├── CourseGetDTO.cs
│   │   └── CourseUpdateDTO.cs
│   └── StudentDTOs/
│       ├── StudentCreateDTO.cs
│       ├── StudentGetDTO.cs
│       └── StudentUpdateDTO.cs
├── Migrations/
│   └── ... (EF Core migrations)
├── Models/
│   ├── Course.cs
│   ├── Enrollment.cs
│   └── Student.cs
├── Properties/
│   └── launchSettings.json
├── Repositories/
│   ├── Implementations/
│   │   ├── CourseRepo.cs
│   │   ├── EnrollmentRepo.cs
│   │   └── StudentRepo.cs
│   └── Interfaces/
│       ├── ICourseRepo.cs
│       ├── IEnrollmentRepo.cs
│       └── IStudentRepo.cs
├── Utils/
│   └── SchoolEmailAttribute.cs
├── appsettings.json
├── appsettings.Development.json
├── CourseManagementSystem.csproj
├── Dockerfile
├── Program.cs
└── CourseManagementSystem.http

Root Directory/
├── CourseManagementSystem/
├── CourseManagementSystem.sln
├── compose.yaml
├── global.json
└── README.md
```

---

## 📦 API Endpoints

### 🔹 Students

| Method | Endpoint         | Description        |
| ------ | ---------------- | ------------------ |
| GET    | `/students`      | Get all students   |
| GET    | `/students/{id}` | Get student by ID  |
| POST   | `/students`      | Create new student |
| PUT    | `/students/{id}` | Update student     |
| DELETE | `/students/{id}` | Delete student     |

### 🔹 Courses

| Method | Endpoint        | Description       |
| ------ | --------------- | ----------------- |
| GET    | `/courses`      | Get all courses   |
| GET    | `/courses/{id}` | Get course by ID  |
| POST   | `/courses`      | Create new course |
| PUT    | `/courses/{id}` | Update course     |
| DELETE | `/courses/{id}` | Delete course     |

### 🔹 Enrollment

| Method | Endpoint                       | Description                  |
| ------ | ------------------------------ | ---------------------------- |
| GET    | `/students/{id}/courses`       | List courses student is in   |
| POST   | `/students/{id}/courses/{cid}` | Enroll student in course     |
| DELETE | `/students/{id}/courses/{cid}` | Unenroll student from course |
| GET    | `/courses/{id}/students`       | List students in course      |

---

## 🧪 Sample Requests

> ✅ All GET endpoints use **server-side pagination** with default `?page=1&pageSize=10` (10 records per page).  
> ✅ `Student.Email` requires a **custom validation** that enforces the domain `@school.edu`.

---

### 🔹 Create a Student

```http
POST /students
Content-Type: application/json

{
  "name": "Jane Doe",
  "email": "jane.doe@school.edu" // must include @school.edu domain (custom validation)
}
```

---

### 🔹 Update a Student

```http
PUT /students/{id}
Content-Type: application/json

{
  "name": "Jane Smith",
  "email": "jane.smith@school.edu" // must include @school.edu domain (custom validation)
}
```

---

### 🔹 Create a Course

```http
POST /courses
Content-Type: application/json

{
  "title": "Introduction to Databases",
  "description": "Learn relational database design and SQL",
  "instructor": "Dr. John Doe"
}
```

---

### 🔹 Update a Course

```http
PUT /courses/{id}
Content-Type: application/json

{
  "title": "Advanced Databases",
  "description": "Covers indexing, transactions, and NoSQL",
  "instructor": "Dr. Jane Smith"
}
```

---

### 🔹 Enroll a Student in a Course

```http
POST /students/{studentId}/courses/{courseId}
```

---

### 🔹 Unenroll a Student from a Course

```http
DELETE /students/{studentId}/courses/{courseId}
```

---

### 🔹 List Courses a Student Is Enrolled In

```http
GET /students/{studentId}/courses?page=1&pageSize=10
```

---

### 🔹 List Students Enrolled in a Course

```http
GET /courses/{courseId}/students?page=1&pageSize=10
```

---

## 🛠️ Configuration & Database

The application uses PostgreSQL as a persistent storage. Connection string is injected via environment variable `ConnectionStrings__DefaultConnection`.

### Sample format:

```
Host=my-db-host;Port=5432;Database=CourseDb;Username=postgres;Password=mypass;SslMode=Require
```

This value is provided via Azure **App Service → Configuration → Application settings**, and not exposed in the source code.

---

## 🐳 Running the Application

### 🔸 Option 1: Run with Docker CLI

```bash
cd CourseManagementSystem  # Enter the directory containing the Dockerfile
docker build -t coursemanagementsystem:latest .
docker run -d -p 5092:5092 --name coursemanagementsystem coursemanagementsystem:latest
```

Access the API at: [http://localhost:5092/swagger](http://localhost:5092/swagger)

### 🔸 Option 2: Run with Docker Compose

```bash
docker compose up --build
```

> Make sure `docker-compose.yml` is in your project root.

### 🔸 Option 3: Run Locally

Update your `appsettings.json` with a valid connection string (only for local dev) or use the Remote Host Database that I already instantiated:

```json
"ConnectionStrings": {
  "DefaultConnection": "Host=localhost;Port=5432;Database=CourseDb;Username=postgres;Password=yourpassword;SslMode=Disable"
}
```

Then run:

```bash
dotnet restore
dotnet ef database update
dotnet run --project CourseManagementSystem
```

Access the API at: [http://localhost:5092/swagger](http://localhost:5092/swagger)

---

## ☁️ Access the Deployed Public API

### 🔹 Hosting and Deployment

- The app is deployed to **Azure App Service (Linux)** as **code**, not as a Docker container.
- The backend is connected to a **managed PostgreSQL Flexible Server** hosted on Azure.
- Deployment is fully automated using **GitHub Actions CI/CD** triggered on each push to the `main` branch.

### 🔹 CI/CD Workflow

- On every push to `main`, GitHub Actions:
  - Restores dependencies
  - Builds and publishes the .NET project
  - Deploys the output using a secure **Azure Publish Profile**

---

### 🔹 API Access

The app is publicly accessible via the following base URL:

```
https://course-management-system.azurewebsites.net/swagger
```

You can directly test API routes using this domain.

#### 🔸 Example Requests

- View all courses:

  ```
  GET https://course-management-system.azurewebsites.net/courses
  ```

- View all students:

  ```
  GET https://course-management-system.azurewebsites.net/students
  ```

- Enroll a student in a course:
  ```
  POST https://course-management-system.azurewebsites.net/students/{studentId}/courses/{courseId}
  ```

---

## 📚 Sample Data

To test the API with initial data, you can hardcode sample students and courses in `DataStore.cs`.

---

## 🔗 Resources

- [Swagger UI](https://course-management-f0a7ghfnfuagh0d9.italynorth-01.azurewebsites.net/swagger/index.html)
- [GitHub Repository](https://github.com/erikurtishi/CourseManagementSystem)

---
