using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalidadT2.Models
{
    public interface IRepositorio
    {
        List<Autor> ObtenerAutores();
        List<Libro> ObtenerLibros();
        List<Usuario> ObtenerUsuarios();

    }
    public class Repositorio : IRepositorio
    {
        AppBibliotecaContext cnx;
        public Repositorio(AppBibliotecaContext cnx)
        {
            this.cnx = cnx;
        }
        public List<Libro> ObtenerLibros()
        {
            return cnx.Libros.Include(o=>o.Autor).ToList();
        }

        public List<Autor> ObtenerAutores()
        {
            return cnx.Autores.ToList();
        }

        public List<Usuario> ObtenerUsuarios()
        {
            return cnx.Usuarios.ToList();
        }
    }
}
