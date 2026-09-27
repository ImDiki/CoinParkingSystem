# Coin Parking System

A parking-management desktop application built with **C# and WPF**. The project uses an MVVM-based structure to separate UI views, application state, commands, and supporting services.

## Features

- **Dashboard:** Displays parking-space availability.
- **Entry workflow (入庫):** Manages 15 parking slots and records entry timestamps.
- **Exit workflow (出庫):** Retrieves an occupied slot and calculates the parking fee based on elapsed time.
- **Receipt records:** Writes customer receipt information to local text files.
- **Income records:** Stores daily income entries for the owner.

## Project Structure

- `Commands/` — reusable command handling for UI actions
- `Models/` — application data models such as `ParkingSlot`
- `Services/` — supporting services such as receipt and income file output
- `ViewModels/` — application state and navigation logic
- `Views/` — WPF/XAML user-interface views
- `Data/` — locally generated receipt and income records

## Tech Stack

- C#
- .NET / WPF
- XAML
- MVVM
- Git / GitHub

## Architecture Notes

`MainNavigationViewModel` manages the current view and shares parking-slot state between the main, entry, and exit workflows. `ReceiptService` keeps receipt and income file-writing logic outside the UI views.

This is a student project and remains a learning project rather than a production parking system.

## Run Locally

1. Clone the repository.
2. Open the solution in Visual Studio.
3. Restore/build the project.
4. Run the WPF application.

## Possible Improvements

- Add automated tests for fee calculations and state changes.
- Improve file-path handling and error handling.
- Add persistent structured storage instead of text-file records.
- Continue separating application logic from UI concerns.
