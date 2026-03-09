# csharp-student-management-system-y2

> A console-based **Student Management System** built with **C# and .NET 8** as part of Year 2 programming coursework.

---

## 📋 About This Project

A menu-driven CLI application that allows administrators to **add**, **remove**, and **display** student records stored in a dynamic linked list. The project focuses on applying core Object-Oriented Programming (OOP) principles, clean code structure, and robust input validation in a real-world-inspired scenario.

**Key features:**
- Add a student record (name + ID)
- Remove a student record by ID
- Display all enrolled students
- Full input validation with `try/catch` exception handling
- Loop-driven menu interface that runs until the user exits

---

## 🛠️ Tech Stack

| Technology | Version |
|---|---|
| Language | C# |
| Framework | .NET 8 |
| IDE | JetBrains Rider / Visual Studio |
| Data Structure | `LinkedList<Student>` |

---

## 🚀 Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) installed on your machine

Verify your installation:
```bash
dotnet --version
```

---

### Installation & Running

1. **Clone the repository**
   ```bash
   git clone https://github.com/<your-username>/csharp-student-management-system-y2.git
   cd csharp-student-management-system-y2
   ```

2. **Navigate to the project directory**
   ```bash
   cd Question_4
   ```

3. **Build the project**
   ```bash
   dotnet build
   ```

4. **Run the application**
   ```bash
   dotnet run
   ```

---

## 🖥️ Using the Application

Once running, you will see the main menu:

```
Student Management System

1. Add Student
2. Remove Student
3. Display Students
4. Exit

Choose an option (1-4):
```

### Option 1 — Add Student
Enter a student name and a unique student ID. The record is added to the end of the linked list.

```
Adding a new student...
Enter student name: Alice Johnson
Enter student ID: S1001
Student Alice Johnson with ID S1001 added successfully.
```

### Option 2 — Remove Student
Enter the ID of the student you want to remove. The system searches the linked list and removes the first matching record.

```
Removing a student...
Enter student ID to remove: S1001
Student with ID S1001 removed successfully.
```

If no student with that ID exists:
```
No student found with ID S1001.
```

### Option 3 — Display Students
Lists all currently enrolled students. If no records exist, a message is shown.

```
Enrolled students:
Name: Alice Johnson, ID: S1001
Name: Bob Smith, ID: S1002
```

### Option 4 — Exit
Gracefully exits the application.

```
Exiting the program...
```

---

## 📂 Project Structure

```
CSharp-CPMS-Q4-Y2-2025/
├── Question_4.sln              # Solution file
└── Question_4/
    ├── Program.cs              # Entry point — menu logic, input validation, switch handling
    ├── Student.cs              # Student model class — Name and ID properties
    └── Question_4.csproj       # Project configuration targeting .NET 8
```

---

## 💡 Concepts Demonstrated

- ✅ C# class design with constructors and auto-implemented properties
- ✅ `LinkedList<T>` for dynamic record management
- ✅ Menu-driven loop with `switch` statements
- ✅ Input validation using `try/catch` and `FormatException` handling
- ✅ LINQ (`FirstOrDefault`) for searching records
- ✅ Clean, readable console output formatting

---

## 📄 License

This project was created for educational purposes as part of a Year 2 programming module.

