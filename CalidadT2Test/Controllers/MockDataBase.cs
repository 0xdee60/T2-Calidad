using CalidadT2.Models;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalidadT2Test.Controllers
{
    class MockDataBase
    {
        public static Mock<AppBibliotecaContext> GetContext()
        {
            //creando database de prueba
            var data = new List<Libro> {
                new Libro{ Id = 1, Nombre = "Metamorfosis", AutorId=1 },
                new Libro{ Id = 2, Nombre = "El resplandor", AutorId=2 }
            }.AsQueryable();


            var data2 = new List<Autor>
            {
                new Autor{Id=1,Nombres="Max Clark"},
                new Autor{Id=2,Nombres="Max asd"}
            }.AsQueryable();

            var data3 = new List<Usuario>
            {
                new Usuario{Id=1,Nombres="Miguel Kael'thas",Username="user1",Password="user1"},
                new Usuario{Id=2,Nombres="Lord Mugre",Username="user2",Password="user2"},
            }.AsQueryable();

            //mock dbset
            var dbsetMock = new Mock<DbSet<Libro>>();
            var dbsetMock2 = new Mock<DbSet<Autor>>();
            var dbsetMock3 = new Mock<DbSet<Usuario>>();
            //configurar dbsets
            dbsetMock.As<IQueryable<Libro>>().Setup(m => m.Provider).Returns(data.Provider);
            dbsetMock.As<IQueryable<Libro>>().Setup(m => m.Expression).Returns(data.Expression);
            dbsetMock.As<IQueryable<Libro>>().Setup(m => m.ElementType).Returns(data.ElementType);
            dbsetMock.As<IQueryable<Libro>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());


            dbsetMock2.As<IQueryable<Autor>>().Setup(m => m.Provider).Returns(data2.Provider);
            dbsetMock2.As<IQueryable<Autor>>().Setup(m => m.Expression).Returns(data2.Expression);
            dbsetMock2.As<IQueryable<Autor>>().Setup(m => m.ElementType).Returns(data2.ElementType);
            dbsetMock2.As<IQueryable<Autor>>().Setup(m => m.GetEnumerator()).Returns(data2.GetEnumerator());


            dbsetMock3.As<IQueryable<Usuario>>().Setup(m => m.Provider).Returns(data3.Provider);
            dbsetMock3.As<IQueryable<Usuario>>().Setup(m => m.Expression).Returns(data3.Expression);
            dbsetMock3.As<IQueryable<Usuario>>().Setup(m => m.ElementType).Returns(data3.ElementType);
            dbsetMock3.As<IQueryable<Usuario>>().Setup(m => m.GetEnumerator()).Returns(data3.GetEnumerator());




            //mock de la coneccion a base de datos
            var contextMock = new Mock<AppBibliotecaContext>();
            contextMock.Setup(o => o.Libros).Returns(dbsetMock.Object);
            contextMock.Setup(o => o.Autores).Returns(dbsetMock2.Object);
            contextMock.Setup(o => o.Usuarios).Returns(dbsetMock3.Object);

            return contextMock;
        }
    }
}
