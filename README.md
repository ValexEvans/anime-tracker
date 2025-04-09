

# Anime Tracker App

This lightweight anime tracking app is designed for macOS, Windows, and Linux. To avoid database compatibility issues, it uses SQLite instead of SQL Server. The app focuses on essential anime tracking features without unnecessary complexity.

This project was developed as a way to understand .NET and C#, and some AI tools were utilized for structuring the code and UI. In the future, I plan to integrate the Jikan open-source API to enhance anime-related data retrieval.

## Key Features

- Uses **SQLite** (no external database setup required)  
- Simplified **Anime** entity with essential tracking fields  
- **CRUD operations** (Create, Read, Update, Delete)  
- **Bootstrap for responsive styling**  
- No user authentication – focus purely on anime tracking  

---

## Setup and Installation

### 1. Create a New .NET Core MVC Project
```sh
dotnet new mvc -n AnimeTracker
cd AnimeTracker
```

### 2. Install Required Packages
```sh
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
dotnet add package JikanDotNet
dotnet restore
```

### 3. Set Up Files and Folders
Create the necessary files and folder structure as shown in the provided code artifact.  

### 4. Run the Application
```sh
dotnet run
```
The app will **automatically create and seed the SQLite database** on first launch.  

---

## App Features 

- Track Your Anime List
- View a list of your anime  
- Filter by watch status: **Watching, Completed, Plan to Watch, Dropped**  
- Add new anime to your list  
- Edit anime details (watch status, episodes watched, rating)  
- Delete anime from your list  

---

## Why Use This App?

- **Cross-platform compatibility** – Works on **macOS, Windows, and Linux**  
- **No complex database setup** – Uses built-in **SQLite**  
- **Minimalist design** – Focuses only on **core anime tracking functionality**  
- **Easy to set up & modify** – Clean and straightforward code  

---
