# 📋 Project Requirements – MicroShop

## 🛍️ Project Overview

MicroShop is a backend e-commerce system built using distributed microservices. Each service uses a distinct technology stack to simulate real-world, polyglot microservice architecture.

## 👤 User Roles

- Customer
- Admin

## ✅ User Stories

1. Register and log in as a user
2. View and search products
3. Place orders
4. Admin manages product catalog

## 📌 Functional Requirements

- User auth with JWT
- Product CRUD with stock
- Order placement via async messaging

## ⚙️ Technical Requirements

- 3 microservices:
  - User Service → **.NET 8 (ASP.NET Core Web API)** + PostgreSQL
  - Product Service → **Node.js + Express** + MongoDB + Redis
  - Order Service → **Spring Boot** + PostgreSQL + RabbitMQ
- REST + RabbitMQ communication
- Docker + Kubernetes
- JWT auth + Role-based access
- Monitoring: Prometheus / ELK
