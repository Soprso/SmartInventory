# 🧠 SmartInventory Console App

A simple, scalable **inventory management system** built using **C#**, following clean code principles and `SOLID` architecture.  
This is a **console-based project** to demonstrate the use of **Generics, Interfaces, LINQ, and Repository Pattern**.

---

## 📌 Features

- ✅ Manage Products and Categories
- ✅ Add, Update, Remove entities
- ✅ Query/filter using LINQ
- ✅ `IEnumerable<T>` used for secure data exposure
- ✅ `ICollection<T>` used for navigation properties (e.g., `Category.Products`)
- ✅ Clean architecture with separation of concerns

---

## 🛠 Tech Stack

- **Language:** C# (.NET 8 Console App)
- **Design:** Generic Repository Pattern
- **Principles:** SOLID, Clean Code
- **IDE:** Visual Studio Code

---

## 📂 Project Structure

SmartInventory/
├── Models/
│ ├── IEntity.cs
│ ├── Product.cs
│ └── Category.cs
│
├── Repository/
│ ├── IRepository.cs
│ └── GenericRepository.cs
│
├── Program.cs
└── SmartInventory.sln


---

## 🚀 How to Run

1. Clone the repository:
   ```bash
   git clone https://github.com/Soprso/SmartInventory.git
   cd SmartInventory
dotnet run
Follow the console prompts to:

Add Products

Assign Categories

Filter/Search inventory
🧪 Concepts Practiced
🔁 IEnumerable<T> for read-only access

➕ ICollection<T> for internal manipulation

🔍 LINQ for filtering and searching

🧱 Domain models with inheritance (IEntity)

🧼 Repository pattern for separation of concerns

💡 Why This Project?
This was a learning-driven project to strengthen backend fundamentals in .NET, before moving to Web APIs or full-stack systems like .NET + Angular.
