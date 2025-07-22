# 🧩 Domain Model – MicroShop

---

## 👤 User Entity (.NET 8 + PostgreSQL)

| Field      | Type   | Description        |
| ---------- | ------ | ------------------ |
| id         | UUID   | User ID            |
| name       | string | Full name          |
| email      | string | Login email        |
| password   | string | Hashed password    |
| role       | enum   | customer / admin   |
| created_at | time   | Creation timestamp |

---

## 📦 Product Entity (Node.js + MongoDB + Redis)

| Field       | Type      | Description        |
| ----------- | --------- | ------------------ |
| \_id        | ObjectId  | MongoDB ID         |
| name        | string    | Product name       |
| description | string    | Details            |
| price       | float     | Price in currency  |
| stock       | integer   | Available quantity |
| created_at  | timestamp | Creation time      |

---

## 🧾 Order Entity (Spring Boot + PostgreSQL)

| Field       | Type  | Description                |
| ----------- | ----- | -------------------------- |
| id          | UUID  | Order ID                   |
| user_id     | UUID  | Reference to user          |
| items       | array | product_id + quantity      |
| total_price | float | Calculated total           |
| status      | enum  | pending / processed / fail |
| created_at  | time  | Order time                 |

---

## 🔗 Relationships (Logical View)

```text
User (1) ──────< places >────── (∞) Order
Order (1) ─────< contains >──── (∞) Product
```
