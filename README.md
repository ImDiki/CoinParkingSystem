*COIN PARKNG SYSTEM*

A robust Parking Management System built with C# and WPF, utilizing the MVVM (Model-View-ViewModel) architectural pattern. Features

Features
Dashboard Status: Dynamically counts and displays real-time available parking slots.

Entry System (入庫): Manages a visual grid of slots 1 to 15 (Green = Empty, Red = Occupied). Clicking 登録 (Register) automatically records the vehicle's entry timestamp.

Exit System (出庫): Searches for an occupied slot, fetches the entry time, and automatically calculates parking fees based on elapsed duration.

Data Persistence: Automatically writes and archives clean customer receipts and daily income reports into text files inside the Data/ directory.

Clean Architecture: Implements the MVVM pattern to ensure a clear separation of concerns, resulting in highly maintainable and scalable code.

📂 Project Structure
Commands/: Contains RelayCommand.cs to handle generic user UI interaction events and button clicks.

Data/: Stores auto-generated text reports for both Customer Receipts and Owner Income Logs.

Models/: Defines data structures like ParkingSlot.cs to hold slot numbers, occupancy states, and timestamps.

Services/: Manages background file operations and logging tasks via ReceiptService.cs, keeping IO logic decoupled from the UI.

ViewModels/: Acts as the mediator between the UI and Model, utilizing MainNavigationViewModel.cs as a central router to switch screens (MapsToMain, MapsToEntry, MapsToExit).

Views/: Contains the XAML layouts for MainWindow, MainView (Dashboard), EntryView (1-15 Slot Grid), and ExitView (Payment Terminal).


🛠️ Technologies Used
Language: C#

Framework: .NET (WPF)

Design Pattern: MVVM (Model-View-ViewModel)

Version Control: Git & GitHub (Feature-Branch Workflow)

🚀 How to Use
Clone this repository to your local machine using GitHub Desktop or Git Terminal.

Open the solution file (.sln) in Visual Studio 2022.

Build the project and run the application.
