# 🛡️ Zero Trust Access Manager (ZTAM)

A lightweight **Zero-Trust inspired access control system** built with **ASP.NET Core**, **Entity Framework Core**, and **SQLite**.  
Designed to demonstrate core authorization concepts used by modern security platforms such as ThreatLocker.

---

## 🚀 Features

- 🧑‍💼 Manage **Users**
- 🖥️ Manage **Applications**
- 🔐 Assign **Permissions** (allow/deny rules)
- ✔️ **Access Check API** (`/api/access/check`)
- 📦 SQLite persistence with EF Core
- 📘 Built-in Swagger UI
- 📂 Clean, interview-ready architecture

---

## 🧱 Tech Stack

| Component | Technology |
|----------|------------|
| Backend | ASP.NET Core 8 Web API |
| Database | SQLite + Entity Framework Core |
| API Docs | Swagger / OpenAPI |
| Architecture | RESTful Controllers |
| Optional Frontend | React + Tailwind dashboard |

---

## 🗄️ Database Setup

Run the migration:

```bash
dotnet ef database update

