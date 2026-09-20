# PolyMetrics - Polyurethane Foam Management System

![Version](https://img.shields.io/badge/Version-Beta%20v1.0-blue?style=for-the-badge)
![Platform](https://img.shields.io/badge/Platform-Windows%20Forms%20(.NET)-purple?style=for-the-badge)
![Database](https://img.shields.io/badge/Database-SQL%20Server-cc2927?style=for-the-badge&logo=microsoft-sql-server&logoColor=white)

## 🏭 Overview
PolyMetrics is a specialized desktop application designed for Polyurethane (PU) foam manufacturing plants and production lines. It helps chemical engineers and production managers track raw materials, environmental conditions, formulation stages, machine properties, and laboratory test results efficiently.

---

## 📥 Installation & Database Setup

To get the database up and running with the pre-populated realistic industrial data:
1. Download the database backup file (.bak) from the repository (or the releases section).
2. Restore the .bak file into your Microsoft SQL Server.
3. *(Optional)* If you want to clear/reset all sample data and start fresh, open and run the reset script query located inside the database folder.

---

## 🔌 Connecting the Application to Your Database

To link the desktop application with your SQL Server database:
1. Open the project solution file (.sln) using Visual Studio.
2. Navigate through the solution explorer to find the class file:
   clsDataAccessSettings.cs
3. Update the Connection String inside this class to match your local SQL Server instance credentials (Server name, Authentication, etc.).
4. Run/Start the project!

---

## 🖥 System Features & UI
* Main Dashboard: Quick navigation through core modules (Materials, Equipments, Formulations, Foam Catalogs).
* Manager Screens: Organized grid views to display all operational records.
* Unified Edit Forms: Seamlessly view, update, and edit records within the same interface.
* Advanced Search & Filters: Easily find specific records using built-in filters.