using System;
using System.Linq;
using DesafioFinal.Data;
using DesafioFinal.Models;

namespace DesafioFinal.Services
{
    public class EfCoreService
    {
        public void RegistrarLibro(string titulo, string isbn)
        {
            // TODO: 1. Inicia un using con BibliotecaContext.
            // TODO: 2. Agrega un nuevo Libro al DbSet de Libros (asegúrate de poner Disponible = true).
            // TODO: 3. Llama a SaveChanges().
        }

        public void ConsultarLibrosDisponibles()
        {
            // TODO: 1. Inicia el contexto.
            // TODO: 2. Usa LINQ para buscar solo los libros donde Disponible == true.
            // TODO: 3. Recorre e imprime los libros encontrados.
        }

        public void ActualizarTituloLibro(int id, string nuevoTitulo)
        {
            // TODO: 1. Inicia el contexto y busca el libro con Find(id).
            // TODO: 2. Si no es nulo, cambia el título y llama a SaveChanges().
        }

        public void EliminarLibro(int id)
        {
            // TODO: 1. Inicia el contexto y busca el libro.
            // TODO: 2. Usa context.Libros.Remove() y guarda los cambios.
        }

        public void RealizarPrestamo(int usuarioId, int libroId)
        {
            // TODO: 1. Inicia el contexto y luego inicia una transacción con context.Database.BeginTransaction().
            // TODO: 2. Dentro de un bloque try, busca el libro.
            // TODO: 3. Si el libro existe y está disponible, cambia su propiedad Disponible a false.
            // TODO: 4. Haz context.SaveChanges() y luego trans.Commit().
            // TODO: 5. En el bloque catch, usa trans.Rollback() por si algo falla.
        }
    }
}