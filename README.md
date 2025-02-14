Petclinic/Animal Hospital Management System
Author: Kritish Dhital
This repository contains the implementation of a Petclinic/Animal Hospital Management System designed to manage the daily operations of an animal hospital. The system allows users to perform various operations such as managing pet information, appointments, treatments, staff details, and much more.

Table of Contents
Features
Technologies Used
System Entities
Web Implementation
Setup and Installation
Usage

Features
Pet Information Management: Add, update, and view pet details such as breed, age, and medical history.
Appointment Scheduling: Schedule and manage appointments for pets with veterinarians.
Treatment Records: Keep track of treatments and procedures performed on pets.
Staff Management: Maintain staff details, including veterinarians, technicians, and administrators.
Search and Filtering: Easily search for pets, appointments, treatments, and staff.
Reports: Generate reports based on appointments, treatments, and other important metrics.
Technologies Used
Backend: The system is built using .NET for creating the API and managing backend functionalities.
Frontend: The front-end of the application is designed using CSS for styling and HTML for structure, ensuring a responsive and user-friendly interface.
Database: SQL-based relational database to store data related to pets, staff, appointments, etc.
IDE: The system is developed using Visual Studio as the integrated development environment (IDE).
System Entities
Pet: Represents the pets in the hospital. Attributes include pet name, type, breed, age, medical history, etc.
Appointment: Holds information about pet appointments, including the date, time, pet, and attending veterinarian.
Treatment: Represents the treatments performed on pets during appointments, including diagnosis, procedures, and medications.
Staff: Includes data about the hospital staff such as veterinarians, technicians, and administrative personnel.
Relationship between Entities
A pet can have multiple appointments.
An appointment can have one or more treatments associated with it.
Each treatment is provided by a specific staff member (veterinarian or technician).
Web Implementation
The web-based user interface is designed using HTML, CSS, and .NET for seamless integration with the backend. The system is built to ensure the following:

Responsiveness: The UI adjusts to different screen sizes, making it usable on both desktop and mobile devices.
User Experience (UX): Easy navigation and interaction with system features like managing pet records, scheduling appointments, and viewing treatment histories.
Styling: CSS is used to style the pages, ensuring that the system is visually appealing, clean, and organized.
The backend services are built using .NET, which connects to the database, processes user requests, and serves data to the frontend interface. Various forms and dashboards are employed to enhance user interaction and management capabilities.

Setup and Installation
Clone this repository to your local machine:![Screenshot 2025-02-14 211045](https://github.com/user-attachments/assets/9fc84a35-07c9-4d1f-bdc6-76f9b038fe0c)

bash
Copy
Edit
git clone https://github.com/KritishX/Petclinic-AnimallHospitalManagementSystem.git
Open the solution file (.sln) in Visual Studio.
Ensure all dependencies are restored, and build the solution.
Run the application locally using Visual Studio's built-in tools or configure the database and deployment environment.![Screenshot 2025-02-14 210702](https://github.com/user-attachments/assets/d090bcad-9d86-432f-a002-c8f209d5bb34)

Usage
Run the system in a web browser by navigating to the appropriate URL (usually http://localhost:PORT).
Register an account or log in with existing credentials.
Explore the dashboard, view and manage pets, appointments, treatments, and staff records.
Use the search feature to find specific records based on criteria such as pet name, appointment date, or treatment type.![Screenshot 2025-02-14 210840](https://github.com/user-attachments/assets/94942135-8173-4330-bc60-d83c9faeba9a)

