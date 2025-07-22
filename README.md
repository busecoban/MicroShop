# 🛍️ MicroShop – Microservice E-Commerce System

MicroShop is a personal software engineering project designed to implement a realistic, microservice-based e-commerce backend system. The project follows modern software architecture principles such as service autonomy, asynchronous communication, containerized deployment, and observability.

This project is developed for self-improvement, inspired by the CSE438 Microservice Architecture syllabus, but is not affiliated with any course or institution.

---

## 🎯 Project Goals

- Build a scalable and modular e-commerce backend system
- Learn and apply microservice patterns and distributed system principles
- Practice with REST APIs, messaging queues, containerization, and observability tools
- Gain experience with multiple languages and frameworks

---

## 🧱 System Architecture

| Service         | Tech Stack            | Database        | Description                                       |
| --------------- | --------------------- | --------------- | ------------------------------------------------- |
| User Service    | .NET 8 (ASP.NET Core) | PostgreSQL      | Handles user registration and login with JWT auth |
| Product Service | Node.js + Express     | MongoDB + Redis | Manages product catalog and caching               |
| Order Service   | Spring Boot (Java 21) | PostgreSQL      | Processes orders asynchronously using RabbitMQ    |

- Each service runs independently in its own container
- Services communicate via REST APIs and RabbitMQ messages
- Databases are not shared across services

---

## 🛠️ Technologies Used

- C# (.NET 8), Java (Spring Boot), JavaScript (Node.js)
- PostgreSQL, MongoDB, Redis
- RabbitMQ for asynchronous messaging
- Docker & Kubernetes for containerization and orchestration
- Prometheus, ELK Stack for observability
- Swagger/OpenAPI for API documentation
- Git & GitHub for version control

---

## 📦 Software Project Lifecycle

This project follows a structured software engineering process:

1. Requirements Analysis ✅
2. Domain Modeling ✅
3. API & Database Design (in progress)
4. Microservice Implementation (per service)
5. Integration & Asynchronous Communication
6. Testing (unit, integration, contract)
7. Dockerization & Kubernetes Deployment
8. Logging, Monitoring, and Observability
9. Documentation & Final Showcase

---

## 🚀 Setup Instructions (Coming Soon)

Setup and run instructions for each microservice will be added as development progresses.

---

## 📚 Documentation

- Requirements: [docs/requirements.md](docs/requirements.md)
- Domain Model: [docs/domain-model.md](docs/domain-model.md)
- API Docs: Swagger/OpenAPI files per service (coming soon)
- System Architecture Diagram (coming soon)

---

## 📈 Progress Tracker

- [x] Project scope and tech stack defined
- [x] Requirements documented
- [x] Domain model created
- [ ] API and data models designed
- [ ] Microservices under development
- [ ] Docker/Kubernetes setup
- [ ] Observability and monitoring tools integrated
