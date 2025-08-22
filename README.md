# GestionAPI - Sistema de Gestión Empresarial

Un sistema completo de gestión empresarial desarrollado con .NET Core Web API y Blazor web app, implementando arquitectura limpia y autenticación JWT.

## 🎯 Objetivos del Proyecto

- **Sistema de Gestión Integral**: Manejo de clientes, productos, órdenes y usuarios
- **Arquitectura Escalable**: Implementación de Clean Architecture con separación de responsabilidades
- **Autenticación Segura**: Sistema JWT con refresh tokens y cookies HttpOnly
- **Interfaz Moderna**: Frontend desarrollado en Blazor web app con componentes reutilizables
- **Base de Datos Robusta**: Modelo relacional con Entity Framework Core

## 🏗️ Arquitectura del Proyecto

### Backend (.NET Core 8)

GestionAPI/
GestorAPI.API/              # Capa de Presentación 
GestionAPI.Application/     # Capa de Aplicación 
GestorAPI.Domain/          # Capa de Dominio 
GestorAPI.Infrastructure/  # Capa de Infraestructura 
GestionAPI.BlazorUI/       # Frontend Blazor web app

### Principios de Clean Architecture

- **Separación de Responsabilidades**: Cada capa tiene una responsabilidad específica
- **Inversión de Dependencias**: Las capas internas no dependen de las externas
- **Testabilidad**: Arquitectura que facilita las pruebas unitarias
- **Mantenibilidad**: Código organizado y fácil de mantener

## 🛠️ Tecnologías Utilizadas

### Backend Stack
- **.NET Core 8**: Framework principal
- **ASP.NET Core Web API**: Para crear APIs RESTful
- **Entity Framework Core**: ORM para acceso a datos
- **SQL Server**: Base de datos principal
- **JWT (JSON Web Tokens)**: Autenticación y autorización
- **BCrypt.Net**: Hashing seguro de contraseñas
- **Swagger/OpenAPI**: Documentación de API

### Frontend Stack
- **Blazor Web App**: Framework de UI interactivo
- **Bootstrap**: Framework CSS para diseño responsivo
- **HTML5 & CSS3**: Tecnologías web estándar

### Herramientas de Desarrollo
- **Visual Studio 2022**: IDE principal
- **SQL Server Management Studio**: Gestión de base de datos
- **Postman**: Testing de APIs
- **Git**: Control de versiones

## 📊 Modelo de Datos

### Entidades Principales

csharp
- **UserEntity** (Usuarios del Sistema)
- **ClientEntity** (Clientes)
- **OrderEntity** (Órdenes) 
- **ProductEntity** (Productos) 
- **OrderStateEntity** (Estados de Órdenes) 


