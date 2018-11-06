using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio43;

namespace Ejercicio46
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestListaCompetencia()
        {
            Competencia competencia = new Competencia(3, 5, Competencia.TipoCompetencia.F1);
            Assert.IsNotNull(competencia.Competidores);
        }

        [TestMethod]
        public void TestCompetenciaNoDisponibleException()
        {
            bool algo;
            Competencia competencia = new Competencia(3, 5, Competencia.TipoCompetencia.MotoCross);
            AutoF1 autoF1 = new AutoF1(15, "Ferrari");

            try
            {
                algo = competencia + autoF1;
            }
            catch(Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(CompetenciaNoDisponibleException));
            }
        }

        [TestMethod]
        public void TestNoException()
        {
            bool algo;
            Competencia competencia = new Competencia(3, 5, Competencia.TipoCompetencia.MotoCross);
            MotoCross moto = new MotoCross(15, "Ferrari");

            try
            {
                algo = competencia + moto;
            }
            catch (Exception e)
            {
                Assert.Fail("No deberia producirse excepcion");
            }
        }

        [TestMethod]
        public void TestAgregarLista()
        {
            bool algo;
            Competencia competencia = new Competencia(3, 5, Competencia.TipoCompetencia.MotoCross);
            MotoCross moto = new MotoCross(15, "Ferrari");

            algo = competencia + moto;
            Assert.IsTrue(competencia == moto);
        }

        [TestMethod]
        public void TestQuitarLista()
        {
            bool algo;
            Competencia competencia = new Competencia(3, 5, Competencia.TipoCompetencia.MotoCross);
            MotoCross moto = new MotoCross(15, "Ferrari");

            algo = competencia + moto;
            algo = competencia - moto;
            Assert.IsTrue(competencia != moto);
        }
    }


}
