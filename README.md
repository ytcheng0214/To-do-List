# To-do List (C# .NET Avalonia UI)

A simple To-Do List application built using **Avalonia UI**, a cross-platform .NET UI framework.

## Demo
![ezgif-39dfedfb430bbe](https://github.com/user-attachments/assets/2f6d5f7a-54a4-46aa-97d1-37091417cf4c)

![ ](https://github.com/user-attachments/assets/f5c5939c-83d3-4f5a-a5dd-7c96f7bffdc4)

## Features
- Add and remove tasks in a list
- User-friendly interface with a modern design
- Uses data binding for task management

## Technologies Used
- **Avalonia UI** (v11.2.6) for cross-platform UI development
- **C# .NET 9.0** for application logic
- **MVVM pattern** for better separation of UI and logic
- **ObservableCollection** for dynamic task list management

## Getting Started
### Prerequisites
- .NET SDK 9.0+

### Installation & Run
```sh
# Clone the repository
git clone https://github.com/ytcheng0214/To-do-List.git
cd TodoApp2

# Restore dependencies
dotnet restore

# Build the project
dotnet build

# Run the application
dotnet run
```

## File Structure
- `MainWindow.axaml` - Defines the UI layout
- `MainWindow.axaml.cs` - Handles application logic
- `TodoApp2.csproj` - Project configuration
