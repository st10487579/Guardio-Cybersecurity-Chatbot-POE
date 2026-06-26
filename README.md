# Guardio-Cybersecurity-Chatbot-POE

## 📌 Project Overview

Guardio is a WPF-based Cybersecurity Awareness Chatbot designed to educate users about online safety while providing interactive features such as task management, quizzes, NLP-based interaction, and activity tracking.

This project is developed as part of a POE (Part 3) assignment and integrates GUI, database connectivity, and intelligent user interaction.

---

## 🚀 Features

### 1. Chatbot Interface

* Interactive chatbot using WPF GUI
* Responds to cybersecurity-related queries
* Supports keyword-based and NLP simulation responses

### 2. Task Assistant (with MySQL Database)

* Add cybersecurity tasks (e.g., enable 2FA, update password)
* Store tasks in MySQL database
* View all tasks
* Delete or mark tasks as completed
* Optional reminders with date input

### 3. Cybersecurity Quiz Game

* 10+ multiple-choice and true/false questions
* Instant feedback after each answer
* Final score display
* Educational explanations for answers

### 4. NLP Simulation

* Detects user intent using keyword matching
* Recognises variations in user input such as:

  * “Add task”
  * “Set reminder”
  * “Start quiz”
  * “What have you done for me?”
* Improves chatbot flexibility and user experience

### 5. Activity Log System

* Records all major actions:

  * Task creation
  * Task deletion
  * Reminder setup
  * Quiz attempts
  * NLP detections
* Displays last 5–10 actions
* Option to view extended history

---

## 🛠 Technologies Used

* C# (.NET / WPF)
* MySQL Database
* ADO.NET (MySql.Data)
* Visual Studio 2022
* Git & GitHub

---

## ⚙️ Setup Instructions

1. Clone the repository:

   ```
   git clone https://github.com/your-username/Guardio-Cybersecurity-Chatbot-POE.git
   ```

2. Open the solution in **Visual Studio 2022**

3. Restore NuGet packages:

   * MySql.Data

4. Set up MySQL database:

   ```sql
   CREATE DATABASE GuardioDB;
   ```

5. Update database connection string in:

   ```
   TaskDatabase.cs
   ```

6. Run the application (Start Debugging)

---

## 📊 GitHub Requirements

This project includes:

* 6+ meaningful commits
* 3 tagged releases:

  * v1.0-Part1
  * v2.0-Part2
  * v3.0-POEFinal

---

## 🎯 Learning Outcomes

* GUI development using WPF
* Database integration using MySQL
* Basic NLP simulation using C#
* Event-driven programming
* Git version control

---

## 👨‍💻 Author

Student Project – Cybersecurity Awareness Chatbot (POE Part 3)
