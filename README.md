# 🛍️ MicroShop – Microservice E-Commerce System

MicroShop is a distributed e-commerce backend system built as a personal software engineering project. It is designed to reflect modern microservice architecture principles including modularity, service autonomy, asynchronous messaging, and cloud-native deployment.

The project is developed for learning purposes with real-world tools and practices such as REST APIs, Docker, Kubernetes, Redis, RabbitMQ, and Prometheus.

---

## 🎯 Project Goals

- Learn and apply microservice architectural principles
- Build a scalable and modular e-commerce system
- Use asynchronous communication and service autonomy
- Explore real-world tools like Docker, Kubernetes, Redis, and RabbitMQ

---

## 🧱 System Architecture (Planned)

| Service         | Tech Stack         | Database        | Description                                  |
| --------------- | ------------------ | --------------- | -------------------------------------------- |
| User Service    | Java + Spring Boot | PostgreSQL      | Handles registration, login, JWT auth        |
| Product Service | Node.js + Express  | MongoDB + Redis | Manages products and caching                 |
| Order Service   | Python + Flask     | PostgreSQL      | Processes orders asynchronously via RabbitMQ |

- All services communicate via REST and RabbitMQ
- Each service has its own container and database
- Deployment will be managed via Kubernetes

---

## 🛠️ Technologies Used

- Java 21, Spring Boot
- Node.js, Express.js
- Python 3.10, Flask
- PostgreSQL, MongoDB, Redis
- RabbitMQ (event messaging)
- Docker, Kubernetes, Prometheus
- Swagger / OpenAPI for API documentation
- Git & GitHub for version control and CI

---

## 🧪 Software Lifecycle Process

1. Requirements analysis ✅
2. System and domain modeling
3. API & database design
4. Service-by-service implementation
5. Integration testing
6. Containerization & deployment
7. Observability & monitoring
8. Final documentation and showcase

---

## 🚀 Local Setup (To be added later)

Each service will be independently deployable using Docker.

```bash
# Example (to be updated per service)
cd user-service
./mvnw spring-boot:run
```
