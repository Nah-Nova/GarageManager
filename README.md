# AutoProfix Garage Management System 🚗🔧

## Table of Contents
1. [Introduction](#introduction)
2. [Assignment Context](#assignment-context)
3. [Project Structure](#project-structure)
4. [Development Steps](#development-steps)
5. [Getting Started](#getting-started)
6. [Diagrams and Designs](#diagrams-and-designs)

## Introduction 🌐🛠️

Welcome to the AutoProfix Garage Management System repository! This project is designed to help Harold, the owner of "AutoProfix," a thriving auto repair shop in an idyllic countryside town, modernize his garage management operations. With the increasing customer base, it's time to transition from the traditional pen-and-paper approach to a web-based solution. using a code to database approch and scaffolding the controllers and views from the models

## Assignment Context 📋

### Garage Management Challenge
Harold, the owner of a successful auto repair business named "AutoProfix" in a picturesque countryside town, is facing a challenge. His customer base has been steadily growing, and the traditional pen-and-paper method of managing the garage's operations is no longer efficient. To address this, he's considering modernizing the garage management system by implementing a web-based solution.

Here are the key points of the challenge he's facing:

- **Vehicle Registration**: Harold wants a system that can capture detailed information about each vehicle, including brand, model, year, chassis number, mileage, and maintenance status.

- **Maintenance Management**: Keeping track of all repairs and maintenance services, including dates, costs, and work done, is crucial.

- **Appointment Scheduling**: Manual appointment scheduling is time-consuming. How can the process be improved?

- **Invoicing and Payments**: Generating invoices for customers and tracking payments are essential.

- **Customer Management**: Maintaining customer data, including contact information and vehicle history, is important.

- **Inventory Management**: Managing the stock of necessary parts and materials is vital.

- **Reporting and Analyses**: Harold would like insights into financial data, performance metrics, and maintenance history. How can a digital system help generate useful reports and analyses?

- **Security**: Ensuring customer data is secure and protecting the system from potential threats is a top priority.

## Project Structure 🏗️

:warning: **Not a Finished Production System**: This project represents an MVP (Minimum Viable Product) created to demonstrate the implementation of concepts covered in web application lectures. It intentionally refrains from going beyond the instructed scope to avoid unnecessary complexity. Please note that this is not a fully polished or production-ready application but serves as a foundation for further development and learning.

Here's an organized project structure to consider for your ASP.NET Core MVC application:

1. **Project Root**:
   - `appsettings.json` or configuration files.
   - `Program.cs` and `Startup.cs`.

2. **Controllers**:
   - Create a folder for your controller classes. This is where you'll define the actions that handle incoming HTTP requests.

   In your project, you have the following controllers:

   - **MVC Controllers**:
     - `CustomerController`: Handles operations related to customers in your web application.
     - `HomeController`: Manages the main home page and general site navigation.
     - `InventoryItemController`: Deals with inventory items in your application.
     - `InvoiceController`: Manages invoice-related actions and views.
     - `MaintenanceRecordController`: Handles maintenance record operations.
     - `PaymentController`: Controls payment-related functionalities.
     - `UserController`: Manages user-related actions, likely for authentication and user management.
     - `VehicleController`: Handles operations related to vehicles in your application.

   - **API Controllers**:
     - `CustomerApiController`: Provides a RESTful API for CRUD operations on customer data. For example, you can use the following URL to retrieve customer data: `GET http://localhost:5137/api/CustomerApi/2`.
     - `VehicleApiController`: Offers a RESTful API for CRUD operations on vehicle data. You can access vehicle information using the API, e.g., `GET http://localhost:5137/api/VehicleApi/2`.
   
3. **Views**:
   - Organize your views within a folder structure that follows your controller organization. Views are responsible for rendering HTML templates and presenting data to users.

   In this project, you have the following views organized by their respective controllers:

   - **Customer Views**:
     - `Customer`: Views related to customer operations.
     
   - **Home Views**:
     - `Home`: Main home page and general site content.
     
   - **InventoryItem Views**:
     - `InventoryItem`: Views for inventory item management.
     
   - **Invoice Views**:
     - `Invoice`: Views for invoice-related actions and display.
     
   - **MaintenanceRecord Views**:
     - `MaintenanceRecord`: Views related to maintenance record management.
     
   - **Payment Views**:
     - `Payment`: Views related to payment operations.
     
   - **Shared Views**:
     - `Shared`: Common shared views that can be reused across multiple controllers.
     
   - **User Views**:
     - `User`: Views for user management and authentication.
     
   - **Vehicle Views**:
     - `Vehicle`: Views related to vehicle operations.

4. **Models**:
   - Create an `Entities` folder to store your entity classes. These classes represent the data structure of your application and are often mapped to database tables.

   In your project, you may have the following models:

   - **Customer Model**:
     - Represents customer data and attributes.
   
   - **ErrorViewModel Model**:
     - Typically used for error handling and displaying error messages in views.

   - **InventoryItem Model**:
     - Represents information about items in your inventory.

   - **Invoice Model**:
     - Represents invoice data, including line items and total amounts.

   - **MaintenanceRecord Model**:
     - Represents records of maintenance activities.

   - **Payment Model**:
     - Represents payment information for transactions.

   - **User Model**:
     - Represents user data and attributes, often used for authentication and user management.

   - **Vehicle Model**:
     - Represents information about vehicles, including make, model, and other relevant details.

   These models define the structure of your data and play a crucial role in interacting with your database and rendering views. Organizing them in an `Entities` folder helps maintain clarity in your project structure.
   
5. **Data**:
   - `ApplicationDbContexts` folder: Contains your Entity Framework context classes.
   - `Migrations` folder: Contains database migration files generated by Entity Framework.
     
6. **wwwroot**:
   - Store your static files like JavaScript, CSS, and images in this folder.

7. **Tests** (optional):
    - Create folders for unit tests and integration tests to ensure code quality.

## Development Steps 📝

Building an ASP.NET Core MVC application involves several key steps:

1. **Setup Development Environment**:
   - Install Visual Studio or Visual Studio Code.
   - Ensure you have the .NET SDK installed.

2. **Create a New ASP.NET MVC Project**:
   - Choose the "MVC" template.

3. **Define Your Models**:
   - Create C# classes to represent your data entities.

4. **Create a DbContext**:
   - Define an Entity Framework DbContext class for database connectivity.

5. **Configure Dependency Injection**:
   - Set up dependency injection in `Startup.cs` to inject services and repositories.

6. **Create Controllers**:
   - Handle HTTP requests by creating controllers and actions.

7. **Create Views**:
   - Develop Razor views (.cshtml files) for rendering HTML templates.

8. **Implement Routing**:
   - Configure URL routing in `Startup.cs` to map URLs to controller actions.

9. **Implement CRUD Operations**:
   - Create methods in controllers for Create, Read, Update, and Delete (CRUD) operations.

10. **Apply Validation**:
    - Add data validation to models using annotations or custom logic.

11. **Implement Authentication and Authorization** (if needed):
    - Configure user authentication and authorization.

12. **Testing**:
    - Write unit tests for controllers and services using testing frameworks like xUnit or NUnit.

13. **Logging**:
    - Configure logging for debugging and monitoring.

14. **Styling and Client-Side Scripts**:
    - Enhance UI with CSS styles and client-side scripts.

15. **Deployment**:
    - Prepare for deployment to a web server or cloud platform.

16. **Testing in a Production-Like Environment**:
    - Ensure your app functions correctly in a staging environment.

17. **Documentation**:
    - Create documentation including installation instructions and usage guides.

18. **Optimization**:
    - Optimize for performance and scalability.

19. **Security**:
    - Implement security best practices.

20. **Monitoring and Error Handling**:
    - Set up monitoring and error tracking.

21. **Launch**:
    - Deploy your app to production.

22. **Maintenance**:
    - Regularly maintain and update your app.


# Getting Started 🚀

Follow these steps to get started with the AutoProfix Garage Management System:

1. **Prerequisites**:
   - Make sure you have the following prerequisites installed on your development machine:
     - Visual Studio or Visual Studio Code.
     - .NET SDK (Software Development Kit).
     - SQL Server (or another preferred database system).

2. **Clone the Repository**:
   - Clone this GitHub repository to your local machine using the following command:
     ```
     git clone https://github.com/Nah-Nova/GarageManager.git
     ```

3. **Open the Project**:
   - Open the project using your chosen development environment (Visual Studio or Visual Studio Code).

4. **Database Configuration**:
   - Configure your database connection string in the `appsettings.json` file. Ensure it points to your SQL Server instance or preferred database system.

5. **Database Migration**:
   - This project was created with Code First in mind, not Database First. Code First allows you to define your database schema using C# classes and generate the database from your model. Open a terminal within your project's root directory and run the following commands to apply the initial database migration:
     ```
     dotnet ef migrations add InitialCreate
     dotnet ef database update
     ```

6. **Run the Application**:
   - Build and run the application using your development environment. If using Visual Studio, press F5. If using Visual Studio Code, use the `dotnet run` command.

7. **Access the Application**:
   - Open your web browser and navigate to `http://localhost:5137` (or the port specified in your `Startup.cs` if different). You should see the AutoProfix Garage Management System homepage.

8. **Explore the Functionality**:
   - Explore the various features and functionalities of the application, such as managing customers, vehicles, invoices, maintenance records, and more.

9. **Customize and Extend**:
   - Customize the application to meet your specific requirements or extend its functionality as needed. You can modify controllers, views, models, and add new features to suit your garage management needs.

10. **Testing and Deployment**:
    - Test the application thoroughly to ensure it meets your requirements and standards.
    - When ready, deploy the application to a production environment or hosting service to make it accessible to your team and customers.

11. **Documentation**:
    - Create documentation for your team, including user guides and admin instructions on how to use and maintain the system.

12. **Enjoy**:
    - Enjoy the benefits of the AutoProfix Garage Management System, which will help streamline your garage operations, improve customer service, and enhance your business efficiency.

Feel free to refer to the [Diagrams and Designs](#diagrams-and-designs) section for visual representations of the application's architecture, database schema, and user interface designs to gain a better understanding of the system's structure and functionality.


## Diagrams and Designs 📊🎨

1. **Wireframes and Mockups**: Design the user interface of your application using wireframes or mockups to outline the layout and user interaction flow.
   
![frame](https://github.com/Nah-Nova/GarageManager/assets/56248103/f74ebd0c-800c-4b63-8ea2-1760198582f9)

2. **Use Case Diagram**: Visualizes the use cases per actor.
   
![usecase](https://github.com/Nah-Nova/GarageManager/assets/56248103/9d8d156f-ac54-4e64-b708-61c1dcd3f16f)

3. **Entity Class Diagrams**: Visualize the relationships between entities in your code, including classes, properties, and methods.
    
![class](https://github.com/Nah-Nova/GarageManager/assets/56248103/ccbfac4d-0e81-4fa1-bc74-48459cf61729)

4. **Componment Diagrams**: Visualize the modular structure of a software system, depicting components, interfaces, dependencies, and their relationships.
![component](https://github.com/Nah-Nova/GarageManager/assets/56248103/d3990a78-2cc7-4fd0-8cfb-f9e8f690c33b)
