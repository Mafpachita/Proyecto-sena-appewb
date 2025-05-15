# 🏘️ Sistema de Administración de Conjunto Residencial

Este repositorio contiene una **API RESTful** desarrollada en **ASP.NET Web API** para administrar tareas internas de un conjunto residencial. Entre las funcionalidades planificadas están:

- 📄 Registro de pagos de administración *(pendiente)*
- 📅 Reservas de espacios comunes *(pendiente)*
- 🛠️ Sistema de tickets de mantenimiento ✅
- 📢 Comunicación de avisos y FAQ *(pendiente)*

---

## 🧰 Módulo activo: Sistema de Tickets de Mantenimiento

Este módulo permite a los residentes registrar solicitudes de mantenimiento desde una aplicación web.

### 📝 Campos de la solicitud:

- `Nombre`: Nombre del residente
- `Correo`: Correo electrónico
- `NumeroApartamento`: Número del apartamento
- `NumeroTorre`: Torre correspondiente
- `TipoTicket`: Categoría del ticket (Ej. electricidad, plomería)
- `Resumen`: Descripción breve del problema
- `Detalle`: Detalle completo de la solicitud

---

## 🗃️ Base de Datos

Nombre: `DB_CONJUNTO_RESIDENCIAL`

### 🔧 Tecnologías Utilizadas
ASP.NET Web API

SQL Server

Visual Studio

Postman (para pruebas de endpoints)

## 📡 Endpoints del API

| Método | Ruta                                | Descripción                        |
|--------|-------------------------------------|------------------------------------|
| GET    | `/api/TicketMantenimiento`          | Listar todos los tickets           |
| GET    | `/api/TicketMantenimiento/{id}`     | Obtener ticket por ID              |
| POST   | `/api/TicketMantenimiento`          | Crear nuevo ticket                 |
| PUT    | `/api/TicketMantenimiento`          | Actualizar un ticket existente     |
| DELETE | `/api/TicketMantenimiento/{id}`     | Eliminar ticket por ID             |

## ▶️ Cómo ejecutar
- Clona este repositorio.

- Abre el proyecto en Visual Studio.

- Asegúrate de que SQL Server esté activo y que la cadena de conexión esté correcta.

- Ejecuta la solución.

- Usa Postman o tu navegador para probar los endpoints.

## 👤 Autor

- **Nombre**: María Vega Ocampo
- **Correo**: [maryvegaocampo97@hotmail.com]
- **Proyecto de formación**: [Sena PPSO]
- **Fecha**: Mayo de 2025





