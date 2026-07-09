using System;
using Microsoft.Data.SqlClient;
using DesafioFinal.Utils;

namespace DesafioFinal.Services
{
    public class AdoNetService
    {
        public void RegistrarUsuario(string nombre, string email)
        {
            // TODO: 1. Instancia una SqlConnection usando DatabaseHelper.ConnectionString.
            // TODO: 2. Escribe la consulta SQL: "INSERT INTO Usuarios (Nombre, Email) VALUES (@Nombre, @Email)".
            // TODO: 3. Crea un SqlCommand y añade los parámetros (@Nombre, @Email) usando AddWithValue.
            // TODO: 4. Abre la conexión, ejecuta el comando con ExecuteNonQuery() y muestra un mensaje de éxito.
        }

        public void ListarUsuarios()
        {
            // TODO: 1. Instancia una SqlConnection.
            // TODO: 2. Escribe la consulta: "SELECT Id, Nombre, Email FROM Usuarios".
            // TODO: 3. Crea el SqlCommand y abre la conexión.
            // TODO: 4. Usa ExecuteReader() y recorre los resultados con un bucle while (reader.Read()).
            // TODO: 5. Imprime en consola cada fila obtenida.
        }

        public void ActualizarEmailUsuario(int id, string nuevoEmail)
        {
            // TODO: 1. Instancia SqlConnection y SqlCommand con un "UPDATE Usuarios SET Email...".
            // TODO: 2. Añade los parámetros, abre conexión y usa ExecuteNonQuery().
        }

        public void EliminarUsuario(int id)
        {
            // TODO: 1. Instancia SqlConnection y SqlCommand con un "DELETE FROM Usuarios...".
            // TODO: 2. Añade el parámetro del Id, abre conexión y ejecuta.
        }
    }
}