# PLM BOM Data Migration

A **C# .NET Console Application** designed to facilitate **Bill of Materials (BOM)** data migration in **Product Lifecycle Management (PLM)** systems.

---

## 📘 Overview

PLM BOM Data Migration is a beginner-friendly yet industry-relevant console application that simulates the migration of Bill of Materials data from legacy data sources such as **CSV and Excel files** into a structured PLM-style format.

This tool demonstrates how organizations can safely migrate complex product structure data during **PLM system upgrades, data cleanup initiatives, or platform transitions**, while maintaining data integrity and hierarchy.

---

## 🎯 Purpose of the Project

In real-world PLM implementations, BOM data often exists in spreadsheets or flat files. Migrating this data accurately into a PLM system is critical to avoid errors in manufacturing, procurement, and engineering.

This project showcases:
- How BOM data can be read from external files
- How parent–child relationships are processed
- How multi-level BOM structures are handled programmatically

---

## ✨ Features

- **Automated BOM Migration**  
  Reads BOM data from CSV and Excel files and processes it automatically.

- **Multi-Level BOM Handling**  
  Supports hierarchical parent–child relationships using recursive logic.

- **Data Validation**  
  Skips invalid, incomplete, or malformed rows to ensure clean migration.

- **Console-Based Interface**  
  Simple command-line interaction for ease of use and automation.

- **Scalable Architecture**  
  Modular design using services and models, aligned with real PLM migration tools.

---

## 🧰 Technology Stack

- **Language:** C#  
- **Framework:** .NET Console Application  
- **File Handling:** CSV and Excel (.xlsx)  
- **Architecture:** Layered (Models, Services, Program Controller)

---

## 📋 Prerequisites

Before running this application, ensure you have the following installed:

- **.NET Framework 4.8** or **.NET SDK 6.0+**
- **Visual Studio 2022 / Visual Studio Insiders / Visual Studio Code**
- Basic understanding of CSV or Excel file formats

---

## 📂 Project Structure
BOMMigration.Console
│

├── Models

│ └── BomRelation.cs

│

├── Services

│ ├── CsvService.cs

│ ├── ExcelService.cs

│ └── BomService.cs

│

└── Program.cs






---

## 📊 Supported Input Format

### CSV / Excel Columns (Mandatory)

| Column Name  | Description                     |
|-------------|---------------------------------|
| ParentPart  | Parent item / assembly number   |
| ChildPart   | Child component part number     |
| Quantity    | Quantity of child in parent     |

Example:

```csv
ParentPart,ChildPart,Quantity
P1000,A1100,2
A1100,B2100,3

