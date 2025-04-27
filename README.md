# Taskflow API - Documentation d'installation et d'utilisation

Bienvenue dans le projet **Taskflow API** ! 🌟

---

# 📚 Prérequis

Avant de commencer, assurez-vous d'avoir installé :

- [.NET 8 SDK](https://dotnet.microsoft.com/download) (version 8.0 ou supérieure) ou via un cmd (dotnet tool install --global dotnet-ef)
- [SQL Server](https://www.microsoft.com/fr-fr/sql-server/sql-server-downloads)
  - Instance locale recommandée : **localhost\SQLEXPRESS**
- [Azure Data Studio](https://learn.microsoft.com/fr-fr/sql/azure-data-studio/download-azure-data-studio) ou [SQL Server Management Studio (SSMS)](https://learn.microsoft.com/fr-fr/sql/ssms/download-sql-server-management-studio-ssms) pour visualiser la base
- (Optionnel) [Postman](https://www.postman.com/downloads/) pour tester les routes API

---

# 🔧 Installation du projet

1. **Clonez le projet** :
```bash
git clone https://github.com/Gael-Lopes-Da-Silva/taskflow.git
```

2. **Accédez au dossier** :
```bash
cd taskflow
```

3. **Configurez la base de données** :

- Vérifiez votre `appsettings.json` :
```json
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost\\SQLEXPRESS;Database=TaskflowDb;Trusted_Connection=True;TrustServerCertificate=True;"
}
```

4. **Générez la base de données** :
```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
```

5. **Lancez l'application** :
```bash
dotnet run
```

API disponible sur :
```
http://localhost:5110
```

---

# 🌍 Utilisation de l'API

## 🔍 Documentation Swagger

Ouvrez votre navigateur :
```
http://localhost:5110
```
Swagger UI permettra de tester toutes les routes !

## 💡 Fonctionnalités principales

- **Auth** :
  - `POST /api/users/register` : Inscription
  - `POST /api/users/login` : Connexion (génère un JWT)
- **Projects** (protégées par JWT) :
  - `GET /api/projects`
  - `POST /api/projects`
  - `GET /api/projects/{id}`
  - `PUT /api/projects/{id}`
  - `DELETE /api/projects/{id}`
- **Tasks** (protégées par JWT) :
  - `GET /api/tasks`
  - `POST /api/tasks`
  - `GET /api/tasks/{id}`
  - `PUT /api/tasks/{id}`
  - `DELETE /api/tasks/{id}`

## 🏃‍♂️ Exemple rapide

1. **Register**
```json
POST /api/users/register
{
  "name": "Jean Dupont",
  "email": "jean@example.com",
  "password": "Password123"
}
```

2. **Login pour obtenir un token**
```json
POST /api/users/login
{
  "email": "jean@example.com",
  "password": "Password123"
}
```

N'oubliez pas d'utiliser le token sur les autres routes :
```
Authorization: Bearer {votre_token}
```

---

# 👤 Gestion des rôles et statuts

- **Role**
  - `Admin` = 0
  - `User` = 1
- **Status des tâches**
  - `Afaire` = À faire
  - `Encours` = En cours
  - `Termine` = Terminé

---

# ⭐ Remarques

- Middleware d'exception actif.
- Codes HTTP standards utilisés.
- Authentification JWT obligatoire pour Projects et Tasks.
- Swagger documente toutes les routes.

---

# 📬 Support

Pour toute question ou problème, contactez-moi !

---

# 🚀 Bon développement avec Taskflow API !
