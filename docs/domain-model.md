# 🧩 Domain Model – MicroShop

This document defines the core entities of the MicroShop microservices-based e-commerce system. Each microservice is responsible for its own bounded context and database, with minimal shared knowledge across domains.

---

## 👤 User Entity

**Service:** `user-service`  
**Database:** PostgreSQL

| Field      | Type            | Description               |
| ---------- | --------------- | ------------------------- |
| id         | UUID            | Unique identifier         |
| name       | string          | Full name                 |
| email      | string (unique) | Login email               |
| password   | string (hashed) | Encrypted password        |
| role       | enum            | `customer` or `admin`     |
| created_at | timestamp       | Timestamp of registration |

---

## 📦 Product Entity

**Service:** `product-service`  
**Database:** MongoDB  
**Cache:** Redis (frequently accessed product listings)

| Field       | Type      | Description               |
| ----------- | --------- | ------------------------- |
| \_id        | ObjectId  | MongoDB unique identifier |
| name        | string    | Product name              |
| description | string    | Product description       |
| price       | float     | Product price             |
| stock       | integer   | Stock quantity            |
| created_at  | timestamp | Time of product creation  |

---

## 🧾 Order Entity

**Service:** `order-service`  
**Database:** PostgreSQL  
**Communication:** Receives events via RabbitMQ from order placement

| Field       | Type      | Description                         |
| ----------- | --------- | ----------------------------------- |
| id          | UUID      | Unique order ID                     |
| user_id     | UUID      | ID of the user who placed the order |
| items       | array     | List of `{ product_id, quantity }`  |
| total_price | float     | Total price of the order            |
| status      | enum      | `pending`, `processed`, `failed`    |
| created_at  | timestamp | Order creation time                 |

---

## 🔗 Entity Relationships (Logical View)

```text
User (1) ────────< places >──────── (∞) Order
Order (1) ────────< contains >───── (∞) Product
```
