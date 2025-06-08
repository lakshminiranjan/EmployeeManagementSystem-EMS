# Employee Management System (EMS)

## Objective
- Develop an employee management system that incorporates features ensuring reusability, security, and functionality.
- System is robust, flexible, and user-friendly.

## Duration
2 days

## Tech Stack
- **Frontend:** React.js
- **Backend:** ASP.NET Web API (developed using Visual Studio Community Edition)
- **Database:** SQL Server

## Scope
- Backend development using ASP.NET Web API (with Visual Studio Community Edition)
- Database integration with SQL Server
- User-friendly frontend website using React.js with backend-API integration

## Requirements & Implementation

### 1. Token-based Authentication
- Implemented using JWT (JSON Web Tokens) in the ASP.NET Web API backend.
- On successful login, the backend issues a JWT token, which is stored in the browser's localStorage.
- All protected API requests from the frontend include this token in the Authorization header.

### 2. API Development
- Developed RESTful APIs for all employee operations (CRUD):
  - **Create:** Add a new employee
  - **Read:** Get all employees or a single employee
  - **Update:** Edit employee details
  - **Delete:** Remove an employee
- APIs are secured and require a valid JWT token for access.

### 3. Frontend Integration
- The React.js frontend communicates with the backend via HTTP requests using Axios.
- On login, the token is saved and used for all subsequent API calls.
- The UI is responsive and user-friendly, matching modern design standards.
- Features include:
  - Login and registration pages
  - Dashboard with employee list, search, add, edit, and delete functionality
  - Logout functionality
  - Alerts and modals for user feedback

### 4. Database
- SQL Server is used to store all employee and user data.
- Entity Framework Core is used in the backend for ORM and migrations.

## API Documentation
Once the backend server is running, you can explore and test all available API endpoints using Swagger UI:

- **Swagger URL:** [http://localhost:7289/swagger/index.html](http://localhost:7289/swagger/index.html)

Swagger provides an interactive interface to try out the APIs, view request/response formats, and see available endpoints.

## Project Structure
```
EMS/
├── Client/ems-frontend/   # React.js frontend
├── Server/EMS_Server/     # ASP.NET Web API backend
└── ...
```

## How Each Requirement is Met
- **Token-based Authentication:**
  - Implemented in backend using JWT; validated on every protected API call.
- **APIs for Each Operation:**
  - Endpoints for add, update, delete, and fetch employees.
- **Frontend-Backend Integration:**
  - React frontend uses Axios to call backend APIs, passing the JWT token.
- **CURD Operations:**
  - All CRUD (Create, Update, Read, Delete) operations are available from the dashboard UI.

## Deliverables
- **GitHub repository URL:** [Add your repo link here]
- **Project Documentation:** (This README)
- **Deployment URL:** (Optional, add if deployed)

## Output Screenshots
Below are some screenshots of the application in action:

### Login Page
![Login Page](<add-path-to-login-screenshot>)

### Dashboard / Employee List
![Dashboard](<add-path-to-dashboard-screenshot>)

### Add/Edit Employee Modal
![Add/Edit Modal](<add-path-to-modal-screenshot>)

### Database Schema
![Database Schema](<add-path-to-db-schema-screenshot>)

> _Replace `<add-path-to-...>` with the actual image paths or URLs. Use the `description` field in the image tag to describe each screenshot._

## How to Run the Project

### Backend (ASP.NET Web API)
#### Option 1: Using Visual Studio Community Edition
1. Open the solution file (`.sln`) in `Server/EMS_Server/` using Visual Studio Community Edition.
2. Set the startup project to `EMS_Server` if not already set.
3. Configure your SQL Server connection string in `appsettings.json`.
4. (Optional) Run database migrations using the Package Manager Console:
   ```powershell
   Update-Database
   ```
5. Press `F5` or click the **Start** button to run the backend server.

#### Option 2: Using .NET CLI
1. Navigate to `Server/EMS_Server/`.
2. Configure your SQL Server connection string in `appsettings.json`.
3. Run database migrations (if needed):
   ```bash
   dotnet ef database update
   ```
4. Start the backend server:
   ```bash
   dotnet run
   ```

### Frontend (React.js)
1. Navigate to `Client/ems-frontend/`.
2. Install dependencies:
   ```bash
   npm install
   ```
3. Start the frontend server:
   ```bash
   npm start
   ```
4. The app will be available at `http://localhost:3000`.

## Notes
- Make sure the backend is running before starting the frontend for full functionality.
- All API endpoints are protected and require authentication.
- For any issues, check the browser console and backend logs.

---

