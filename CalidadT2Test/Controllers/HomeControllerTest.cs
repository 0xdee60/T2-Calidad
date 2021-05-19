using CalidadT2.Controllers;
using CalidadT2.Models;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalidadT2Test.Controllers
{
    [TestFixture]
    class HomeControllerTest
    {
       

        [Test]
        public void Homecaso01()
        {

            //var dbsetMock = new Mock<DbSet<Autor>>();
            
            var contextMock = new Mock<Repositorio>();
            //contextMock.Setup(o => o.autores).Returns(dbsetMock.Object);

            var controller = new HomeController(contextMock.Object);
            var viewResult = controller.Index() as ViewResult;

            Assert.AreEqual("Index", viewResult.ViewName);
        }


    }
}
