# ASP.NET Order Processing Application

## Objective
This project is a simple ASP.NET web application that processes customer orders based on business logic. It calculates discounts for loyal customers and displays the final order total.

## Business Logic
Customers can enter an order amount and select their customer type ("New" or "Loyal").

**Discount Rules:**
- If the order amount is $100 or more and the customer is "Loyal", a 10% discount is applied.
- Otherwise, no discount is applied.

The application will display the discount amount and final order total on a results page.

## Features
- User-friendly Interface with two views:
  - **Order Entry Page:** Allows users to input their order details.
  - **Results Page:** Displays the calculated discount and final total.
- Robust validation to handle edge cases (e.g., exactly $100, invalid inputs).
- Developed using ASP.NET MVC 4.8.1.

## Technical Implementation
1. **Application Structure:**
   - **Controllers:** Handles user input and business logic.
   - **Views:** Displays the user interface.
   - **Models:** Represents the order and discount calculations.
2. **Version Control with GitHub:**
   - **Repository:** [https://github.com/mpal33141/ASP.NET-Order-Processing-Application]
   - **Branching Strategy:**
     - `main` - Stable, production-ready code.
     - `feature/*` - New features and updates.
     - `bugfix/*` - Fixes for identified issues.
3. **Continuous Integration/Continuous Deployment (CI/CD):**
   - GitHub Actions set up to run automated tests on each commit.
   - Ensures code quality and correctness before merging into the main branch.
4. **Automated Testing:**
   - Implemented using xUnit/MSTest to validate discount calculation logic.
   - Tests run automatically on every commit using the CI/CD pipeline.

## Setup Instructions

### Prerequisites
- Install .NET Framework 4.8.1.
- Install Visual Studio (with ASP.NET MVC support).

### Installation Steps
```sh
git clone [https://github.com/mpal33141/ASP.NET-Order-Processing-Application]

Open the project in Visual Studio.

Build the solution to restore dependencies.

Run the application using IIS Express or a local server.

Running Tests

Run automated tests using the following command:

dotnet test
