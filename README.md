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


## 🧩 Code Structure & File Responsibilities

This project follows a simple layered structure to clearly separate data models, file handling logic, and BOM processing logic.  
Each file has a **single, well-defined responsibility**, similar to real-world PLM migration tools.

---

### 📁 Program.cs (Application Entry Point)

**Purpose:**  
Acts as the main controller of the application.

**Responsibilities:**
- Accepts file path input from the user (CSV or Excel)
- Detects file type based on extension
- Calls the appropriate file reader service (CSV or Excel)
- Accepts the root (top-level) part number
- Triggers BOM hierarchy printing in the console

**Why it exists:**  
This file coordinates all other components but does not contain business logic itself.

---

### 📁 Models/BomRelation.cs (Data Model)

**Purpose:**  
Represents a single BOM relationship.

**Contains:**
- `ParentPart` → Parent item or assembly
- `ChildPart` → Child component
- `Quantity` → Number of child components required

**Why it exists:**  
This model converts raw file data into structured objects that the program can safely process.

---

### 📁 Services/CsvService.cs (CSV File Handler)

**Purpose:**  
Handles reading and parsing BOM data from CSV files.

**Responsibilities:**
- Reads CSV files using file handling APIs
- Supports multiple delimiters (comma, semicolon, tab)
- Skips empty or malformed rows
- Validates numeric quantity values
- Converts valid rows into `BomRelation` objects

**Why it exists:**  
Separates CSV-specific logic from the main program, making the code easier to maintain and extend.

---

### 📁 Services/ExcelService.cs (Excel File Handler)

**Purpose:**  
Handles reading and parsing BOM data from Excel (.xlsx) files.

**Responsibilities:**
- Reads Excel files using `ExcelDataReader`
- Accesses the first worksheet
- Skips header rows
- Validates data integrity
- Converts Excel rows into `BomRelation` objects

**Why it exists:**  
Allows the application to support Excel files, which are commonly used in real PLM data migration scenarios.

---

### 📁 Services/BomService.cs (BOM Processing Logic)

**Purpose:**  
Processes and displays the BOM hierarchy.

**Responsibilities:**
- Identifies child components for a given parent part
- Uses recursion to traverse multi-level BOM structures
- Prints the BOM in a tree-like hierarchical format

**Why it exists:**  
Encapsulates BOM-specific logic separately from file handling and user interaction.

---

## 🔁 Overall Data Flow

1. User provides file path and root part number  
2. File is read (CSV or Excel) and converted into `BomRelation` objects  
3. All BOM relationships are stored in memory  
4. BOM hierarchy is recursively processed  
5. Final structure is displayed in the console  

This modular design closely reflects how BOM migration tools are implemented in real PLM systems.




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

