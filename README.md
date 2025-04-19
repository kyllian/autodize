# autodize

Autodize is a web application for rolling dice and visualizing results. It is built using Blazor and leverages the MudBlazor component library for a modern and responsive UI.

## Features

- **Dice Rolling**: Roll various types of dice (e.g., d6, d20, etc.) and view the results.
- **Data Grid**: Displays rolled results in a sortable, filterable, and groupable grid.
- **Group Statistics**: View grouped statistics such as count, total, highest, and lowest values for each dice type.
- **Responsive Design**: Optimized for different screen sizes.

## Technologies Used

- **Blazor**: A framework for building interactive web UIs with C#.
- **MudBlazor**: A Material Design component library for Blazor.
- **C#**: The primary programming language for the application.

## Getting Started

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) (version 9.0 or later)
- A modern web browser

### Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/kyllian/autodize.git
   cd autodize
   ```

2. Navigate to the `Autodize.Client` project directory:
   ```bash
   cd Autodize.Client
   ```

3. Restore dependencies:
   ```bash
   dotnet restore
   ```

4. Run the application:
   ```bash
   dotnet run
   ```

5. Open your browser and navigate to `http://localhost:5000`.

## Usage

1. Add dice to the list by selecting the desired dice type.
2. Click the "Roll" button to roll the dice.
3. View the results in the data grid, grouped by dice type.
4. Use the "Expand All" and "Collapse All" buttons to manage group visibility.

## Project Structure

- `Autodize.Client`: The Blazor client-side application.
- `Autodize.Client/Components`: Contains reusable Razor components.
- `Autodize.Client/Layout`: Defines the layout and navigation structure.

## Contributing

Contributions are welcome! Feel free to open issues or submit pull requests.

## Acknowledgments

- [MudBlazor](https://mudblazor.com) for the UI components.
- The .NET community for their support and resources.
