using System;
using System.Linq;
using EjercicioClase.Data;
using EjercicioClase.Models;

namespace EjercicioClase.Services
{
    public class EfCoreService
    {
        public void InsertarProducto(string nombre, decimal precio, int stock)
        {
            // TODO: 1. Inicia un 'using' con TiendaContext.
            // TODO: 2. Crea una instancia de Producto con los parámetros recibidos.
            // TODO: 3. Agrega el producto al DbSet de Productos y llama a SaveChanges().
            // TODO: 4. Muestra un mensaje en consola confirmando la inserción.
        }

        public void ListarProductos()
        {
            // TODO: 1. Inicia un 'using' con TiendaContext.
            // TODO: 2. Realiza una proyección (Select) usando DTOs.ProductoDTO.
            //    - Asigna Nombre = p.Nombre.
            //    - Asigna PrecioFormateado = $"${p.Precio}".
            // TODO: 3. Convierte el resultado a lista y recórrelo con un foreach para imprimir en consola.
        }

        public void ActualizarProducto(int id, decimal nuevoPrecio)
        {
            // TODO: 1. Inicia un 'using' con TiendaContext.
            // TODO: 2. Usa el método .Find(id) para obtener el producto.
            // TODO: 3. Si el producto NO es nulo, actualiza su propiedad Precio.
            // TODO: 4. Guarda los cambios en la base de datos.
        }

        public void EliminarProducto(int id)
        {
            // TODO: 1. Inicia un 'using' con TiendaContext.
            // TODO: 2. Busca el producto por su id.
            // TODO: 3. Si existe, usa context.Productos.Remove(p) para marcarlo como eliminado.
            // TODO: 4. Guarda los cambios.
        }

        public void BuscarPorNombre(string nombre)
        {
            // TODO: 1. Inicia un 'using' con TiendaContext.
            // TODO: 2. Filtra la lista de productos usando .Where(p => p.Nombre.Contains(nombre)).
            // TODO: 3. Recorre el resultado e imprime el Nombre y el Precio de cada coincidencia.
        }
    }
}