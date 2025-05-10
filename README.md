# UrbanFix

Sistema ciudadano de reportes urbanos para informar y gestionar problemas en la vía pública como baches, luminarias, basurales y más.

---

## 🚀 Tecnologías Utilizadas

- **Frontend**: React + Vite + TypeScript
- **Backend**: ASP.NET Core (C#)
- **Base de Datos**: SQL Server
- **ORM**: Entity Framework Core
- **Autenticación**: JWT (JSON Web Tokens)
- **Control de versiones**: Git + GitHub
- **Despliegue**: Azure App Service (localmente)

---

## 🎯 Funcionalidades principales

- 📍 Reporte de incidentes con geolocalización
- 📸 Carga de imágenes al sistema
- 👤 Panel del ciudadano: envío y seguimiento de reportes
- 🛠️ Panel del técnico: tickets asignados, en curso y finalizados
- 🧑‍💼 Panel del administrador: gestión general del sistema
- 📄 Historial de reportes y estados
- 🔒 Autenticación de usuarios con JWT

---

## 📦 Estructura del Proyecto
/UrbanFix
├── backend/ # Proyecto ASP.NET Core
│ ├── Controllers/
│ ├── Models/
│ ├── DTOs/
│ ├── Services/
│ └── ...
├── frontend/ # Proyecto React
│ ├── src/
│ │ ├── components/
│ │ ├── pages/
│ │ ├── services/
│ │ └── ...
│ └── public/


---

## 🧪 Cómo probarlo localmente

### Backend (.NET)

```bash
cd backend
dotnet restore
dotnet run
cd frontend
npm install
npm run dev

