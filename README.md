# 📚 Course Management API

A lightweight, RESTful API built with **.NET 8.0** to manage students, courses, and enrollments in a university-like environment.

---

## 🚀 Features

- Full CRUD support for **students** and **courses**
- Enroll and unenroll students in courses
- View all courses a student is enrolled in
- View all students enrolled in a course
- Follows **RESTful best practices**
- JSON responses with proper HTTP status codes
- PostgreSQL Database storage
- Dockerized for easy local development
- Publicly accessible APIs via deployed Azure App Service
- Integrated **CI/CD with GitHub Actions** for automatic containerized deployment

---

## 🛠️ Tech Stack

- **Framework**: ASP.NET Core 8.0
- **Language**: C#
- **Architecture**: RESTful API
- **Docs**: Swagger/OpenAPI
- **Containerization**: Docker
- **CI/CD**: GitHub Actions
- **Deployment**: Azure App Service (Linux container)

---

## 📂 Project Structure

```
CourseManagementAPI/
├── Controllers/
│   ├── StudentsController.cs
│   └── CoursesController.cs
├── Models/
│   ├── Student.cs
│   └── Course.cs
├── Program.cs
├── Dockerfile
├── docker-compose.yml
├── .github/workflows/deploy.yml
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

## 🧪 Sample Request

```http
POST /students
Content-Type: application/json

{
  "name": "Jane Doe",
  "email": "jane.doe@example.com"
}
```

---

## 🐳 Running Locally with Docker

### 🔸 Using Docker CLI

```bash
docker build -t coursemanagementsystem .
docker run -d -p 5092:5092 --name cms coursemanagementsystem
```

Access the API at: [http://localhost:5092/swagger](http://localhost:5092/swagger)

### 🔸 Using Docker Compose

If you prefer using Docker Compose:

```bash
docker compose up --build
```

> Make sure `docker-compose.yml` is in your project root.

---

## ☁️ Access the Deployed Public API

Once deployed, you can access the public API on **Azure App Service**:

```
https://<your-app-name>.azurewebsites.net/swagger
```

All API endpoints are exactly the same as listed above. The service is hosted in a Docker Linux container using GitHub Actions for CI/CD.

---

## 🔄 CI/CD with GitHub Actions

This project includes a CI/CD pipeline using GitHub Actions:

### ✅ Workflow Summary

- Triggered on every `push` to `main`
- Builds Docker image
- Pushes image to Azure Container Registry (or GitHub Container Registry)
- Deploys container to Azure App Service

### 🔧 File: `.github/workflows/deploy.yml`

```yaml
name: Build and Deploy to Azure

on:
  push:
    branches:
      - main

jobs:
  build-and-deploy:
    runs-on: ubuntu-latest
    steps:
      - uses: actions/checkout@v3
      - uses: azure/docker-login@v1
        with:
          login-server: <your-registry>
          username: ${{ secrets.REGISTRY_USERNAME }}
          password: ${{ secrets.REGISTRY_PASSWORD }}

      - run: |
          docker build -t <your-registry>/course-management-api .
          docker push <your-registry>/course-management-api

      - uses: azure/webapps-deploy@v2
        with:
          app-name: <your-app-name>
          images: <your-registry>/course-management-api
```

> Replace `<your-app-name>` and `<your-registry>` with your Azure values.

---

## 📚 Sample Data (Optional)

To test the API with initial data, you can hardcode sample students and courses in `DataStore.cs`.

---

## 🔓 Public Repository

This codebase is open-source and available at:

```
https://github.com/<your-username>/CourseManagementAPI
```

Feel free to fork, clone, and contribute!

---
