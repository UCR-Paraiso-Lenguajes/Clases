using core.Data;
using core.Domain;
using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void HappyPath()
        {
            Genero g1 = new Genero(1, "Test");

            Assert.AreEqual(1, g1.CodGenero);
            Assert.AreEqual("Test", g1.NombreGenero);
        }

        [Test]
        public void Db()
        {
            //IEnumerable generos = new GeneroData().List();

            //Assert.AreNotEqual(null, generos);

            IEnumerable peliculas = new PeliculaData().List();

            Assert.AreNotEqual(null, peliculas);
        }

        [Test]
        public void CodValidation()
        {
            try
            {
                Genero g1 = new Genero(0, "Test");
                Assert.Fail("Exception was expected.");
            }
            catch (Exception e)
            {
                Assert.AreEqual("El c�digo debe ser positivo.", e.Message);
            }
            
        }
    }
}