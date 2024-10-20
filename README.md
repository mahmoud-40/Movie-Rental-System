# Movie Rental System

## Overview
The **Movie Rental System** is a console application built with C# to manage movie rentals. It allows users to rent, return, and manage movie inventory while handling customer information and payments. The application demonstrates object-oriented programming principles through the use of classes and relationships.

## Features
- **Customer Management**: Add, edit, and view customer details.
- **Movie Inventory**: Maintain a catalog of available movies for rent.
- **Order Processing**: Create and manage rental orders, including rental and return functionalities.
- **Payment Handling**: Process payments for movie rentals.
- **Suggestions**: Provide movie recommendations based on customer preferences.

## Diagrams
### Entity-Relationship Diagram (ERD)
The ERD visualizes the relationships between different entities in the Movie Rental System:

![ERD](./Movie%20Rental%20System%20Class%20Diagram.svg)

### Class Diagram
The class diagram shows the system's classes and their relationships, including `Customer`, `Movie`, `Order`, `Payment`, `Rent`, `Suggestor`, and `System`.

## Classes
- **Customer.cs**: Represents a customer, including name and contact information.
- **Movie.cs**: Represents a movie, including title, genre, and rental status.
- **Order.cs**: Manages rental orders, linking customers and movies.
- **Payment.cs**: Handles payment transactions for rentals.
- **Rent.cs**: Manages the rental process, including dates and return information.
- **Suggestor.cs**: Provides movie suggestions based on preferences.
- **System.cs**: Main class that ties all components together, handling user input and application flow.
- **Program.cs**: Entry point of the application, executing the main logic.

## Getting Started
1. Clone the repository:
   ```bash
   git clone https://github.com/yourusername/MovieRent.git
   ```
2. Navigate to the project directory:
   ```bash
   cd MovieRent
   ```
3. Open the project in your preferred C# IDE (e.g., Visual Studio).
4. Build and run the application.

## Requirements
- .NET SDK
- C# Development Environment

## Usage
Follow the console prompts to manage movie rentals, add customers, and process payments.

## Contribution
Submit issues or pull requests for enhancements or bug fixes.

## License
This project is licensed under the MIT License. See the LICENSE file for details.