# Guía Práctica: Acceso a Datos en .NET (Grupo 2)

¡Bienvenidos a la práctica de acceso a datos! En esta sesión, exploraremos cómo interactuar con bases de datos en aplicaciones .NET utilizando dos enfoques fundamentales: el moderno **Entity Framework Core (EF Core)** y el tradicional **ADO.NET**.

---

## 🛠️ Requisitos Previos e Instalación

Antes de comenzar a escribir código, asegúrate de tener el siguiente entorno configurado en tu equipo:

1. **.NET SDK:** Instalar la versión más reciente (recomendado .NET 8) desde la página oficial de Microsoft.
2. **Editor de Código:** Visual Studio Code (con la extensión "C# Dev Kit") o Visual Studio 2022.
3. **Motor de Base de Datos:** SQL Server Express (gratuito). Debe estar en ejecución como una instancia local (usualmente bajo el nombre `.\SQLEXPRESS`).
4. **Cliente SQL:** SQL Server Management Studio (SSMS) o Azure Data Studio para visualizar las tablas y registros generados.

---

## ⚙️ Preparación del Entorno (Para ambos ejercicios)

Los proyectos base ya cuentan con la estructura de Arquitectura en Capas (`Models`, `Data`, `Services`, `DTOs`). Para prepararlos en tu máquina, abre tu terminal y ejecuta los siguientes comandos para restaurar las dependencias necesarias.

**Para el Ejercicio 3.3 (EF Core):**
`cd Ejercicio_Clase`
`dotnet add package Microsoft.EntityFrameworkCore.SqlServer`

**Para el Desafío 3.4 (Híbrido):**
`cd Desafio`
`dotnet add package Microsoft.EntityFrameworkCore.SqlServer`
`dotnet add package Microsoft.Data.SqlClient`

> **Nota:** En el archivo `Program.cs` de ambos proyectos se ha incluido el comando `db.Database.EnsureCreated();`. Esto automatiza la creación de la base de datos y las tablas al ejecutar el programa, por lo que no es necesario ejecutar migraciones manualmente para esta clase.

---

## 🚀 Ejercicio 3.3: CRUD Completo con Entity Framework Core

### 📖 Contexto
Entity Framework Core es el ORM (Object-Relational Mapper) oficial de Microsoft. Nos permite trabajar con bases de datos utilizando objetos de C# en lugar de escribir consultas SQL manuales. En este ejercicio, gestionaremos el inventario de una tienda. Para separar la información de la base de datos de lo que mostramos al usuario, utilizaremos un patrón de diseño llamado **DTO (Data Transfer Object)**.

### 🎯 Objetivo
Completar el ciclo de vida de los datos (Create, Read, Update, Delete) para la entidad `Producto` utilizando exclusivamente el contexto de base de datos (`TiendaContext`) y consultas LINQ.

### 📝 Instrucciones
1. Abre la carpeta `Ejercicio_Clase` en tu editor.
2. Dirígete al archivo `Services/EfCoreService.cs`.
3. Encontrarás 5 métodos vacíos (`InsertarProducto`, `ListarProductos`, `ActualizarProducto`, `EliminarProducto`, `BuscarPorNombre`).
4. Reemplaza los comentarios marcados con `TODO` con el código C# correspondiente utilizando `TiendaContext`.
5. Ejecuta el programa con `dotnet run`.

**Resultado esperado:** La consola deberá mostrar un flujo sin errores donde se insertan productos, se listan con el precio formateado (gracias al DTO), se realiza una búsqueda parcial, se actualiza un precio y finalmente se elimina un registro, mostrando la lista actualizada en cada paso.

---

## 🏆 Desafío Final 3.4: Sistema de Biblioteca Híbrido (ADO.NET + EF Core)

### 📖 Contexto
En proyectos empresariales a gran escala, es común combinar tecnologías. EF Core es excelente para la lógica de negocio compleja y la velocidad de desarrollo, mientras que ADO.NET es inmejorable cuando necesitamos ejecutar consultas rápidas y directas con el máximo rendimiento. 

En este desafío, construiremos el motor de una biblioteca. Utilizaremos **ADO.NET** para gestionar a los Usuarios (CRUD simple y rápido) y **EF Core** para gestionar los Libros y la complejidad de los Préstamos, asegurando la integridad de los datos mediante **Transacciones**.

### 🎯 Objetivo
Desarrollar un sistema de acceso a datos híbrido, implementando consultas SQL parametrizadas para la gestión de usuarios y métodos ORM seguros para operaciones críticas de inventario.

### 📝 Instrucciones
1. Abre la carpeta `Desafio` en tu editor.
2. Dirígete primero al archivo `Services/AdoNetService.cs`.
   * Completa los 4 métodos del CRUD de Usuarios (`RegistrarUsuario`, `ListarUsuarios`, `ActualizarEmailUsuario`, `EliminarUsuario`).
   * **Regla estricta:** Debes usar `SqlConnection`, `SqlCommand` y consultas SQL puras (`INSERT`, `SELECT`, `UPDATE`, `DELETE`).
3. Dirígete al archivo `Services/EfCoreService.cs`.
   * Completa el CRUD para la entidad Libro utilizando `BibliotecaContext`.
   * Presta especial atención al método `RealizarPrestamo`. Deberás implementar una **Transacción de base de datos** (`BeginTransaction`, `Commit`, `Rollback`) para asegurar que el cambio de disponibilidad del libro solo se guarde si el proceso completo tiene éxito.
4. Ejecuta el programa con `dotnet run`.

**Resultado esperado:** La consola mostrará la ejecución de ambos servicios trabajando en conjunto sobre la misma base de datos. Se registrarán usuarios (ADO.NET) y libros (EF Core), se actualizarán datos, se ejecutará el préstamo de un libro afectando su disponibilidad, y finalmente se eliminarán registros, demostrando el dominio total de ambas herramientas.