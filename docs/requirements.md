# 📋 Project Requirements – MicroShop

## 🛍️ Project Overview

MicroShop is a microservices-based e-commerce system designed for learning and implementing modern software architecture principles. It provides essential e-commerce features such as user registration, product listing, and order management using a distributed, scalable architecture.

## 👤 User Roles

- **Customer**: Can register, log in, view products, and place orders.
- **Admin**: Can manage product listings and view order history.

## ✅ User Stories

1. As a **user**, I want to register and log in so I can access the system securely.
2. As a **user**, I want to browse available products so I can choose what to buy.
3. As a **user**, I want to place an order so I can purchase products.
4. As an **admin**, I want to add, update, or remove products.
5. As a **system**, I want to process orders asynchronously so that services remain decoupled and scalable.

## 📌 Functional Requirements

- User registration and login (with JWT authentication)
- Product CRUD operations (admin only)
- Product listing (public)
- Order placement with async processing (via RabbitMQ)
- Each service has its own database and API

## ⚙️ Technical Requirements (from syllabus)

- 3+ microservices using different frameworks/languages:
  - Spring Boot (Java) → User Service
  - Node.js (Express) → Product Service
  - Python (Flask) → Order Service
- PostgreSQL + MongoDB + Redis
- RESTful APIs + RabbitMQ (event-driven order processing)
- Dockerized microservices
- Kubernetes deployment with at least one scaled service
- JWT-based auth + Role-based access control (admin/user)
- Prometheus/Grafana or ELK for observability
- Unit, integration, and contract testing
- OpenAPI (Swagger) documentation

## 📎 Assumptions and Constraints

- No payment integration (mock orders only)
- UI is out of scope (focus is backend services)
- Project will be run locally with Docker/Kubernetes
