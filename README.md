# RoleAuth

RoleAuth is an ASP.NET Core 8 MVC web application that demonstrates **custom login and registration pages**, **Entity Framework Core Identity integration**, **role-based authentication**, and **admin/user dashboards**. This project overrides the default Identity UI and provides full control over user management and authentication flow.

## ✨ Features

- ASP.NET Core 8 MVC with Razor Views
- Fully **custom Login and Registration pages**
- **Role-based authentication** (e.g., Admin and User)
- User **role selection during registration**
- **Two-Factor Authentication (2FA)** support (optional)
- Admin vs User **dashboard redirection**
- **Entity Framework Core** with SQL Server
- Secure password hashing and login via Identity
- Session and authentication cookies

## 🚀 Technologies Used

- ASP.NET Core 8 MVC
- Entity Framework Core 8
- SQL Server
- ASP.NET Core Identity (custom implementation)
- Bootstrap 5 (for responsive UI)

## 📁 Project Structure

```
RoleAuth/
├── Controllers/
│   └── AccountController.cs
│   └── HomeController.cs
├── Models/
│   └── ApplicationUser.cs
│   └── RegisterViewModel.cs
│   └── LoginViewModel.cs
├── Views/
│   ├── Account/
│   │   ├── Register.cshtml
│   │   └── Login.cshtml
│   ├── Home/
│   │   └── Index.cshtml
│   └── Shared/
│       └── _Layout.cshtml
│       └── _LoginPartial.cshtml
├── Data/
│   └── ApplicationDbContext.cs
├── Program.cs
└── appsettings.json
```

## ⚙️ Setup Instructions

1. **Clone the repository**

```bash
git clone https://github.com/yourusername/RoleAuth.git
cd RoleAuth
```

2. **Update Connection String**

Open `appsettings.json` and set your SQL Server connection string:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=YOUR_SERVER;Database=RoleAuthDb;Trusted_Connection=True;MultipleActiveResultSets=true"
}
```

3. **Run Migrations & Update Database**

```bash
dotnet ef migrations add Init
dotnet ef database update
```

4. **Run the App**

```bash
dotnet run
```

5. **Access the Application**

Visit: [http://localhost:5000](http://localhost:5000)

## 👥 Default Roles

- **Admin**
- **User**

> Roles are automatically seeded during application startup. You can modify them inside the `Program.cs` file.

## 🛡️ Custom Identity Implementation

This app overrides the default Identity UI and uses custom MVC Controllers and Views for login and registration. It uses the `ApplicationUser` class that extends `IdentityUser` to include additional properties (if required in future).

## 🔐 Authentication Flow

- **Registration Page** → User chooses role (Admin/User)
- **Login Page** → Authenticates via Identity
- **Post-Login** → Redirected to respective dashboard based on role

## 🧪 Sample Accounts

| Email           | Password  | Role  |
|----------------|-----------|--------|
| admin@test.com | Admin@123 | Admin |
| user@test.com  | User@123  | User  |

> You may create new users and assign roles directly through the registration form.

## 📌 TODO (optional)

- Add Email confirmation and reset password
- Add Role Management UI
- Add 2FA toggle from profile settings

## 📃 License

This project is licensed under the Arpit Jain (arpitjain.rtm@outlook.com) (LICENSE).
