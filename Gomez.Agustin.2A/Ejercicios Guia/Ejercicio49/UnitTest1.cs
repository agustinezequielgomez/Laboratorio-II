using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Ejercicio49
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestListaCompetencia()
        {
            Competencia<AutoF1> competencia = new Competencia<AutoF1>(3, 5, Competencia<AutoF1>.TipoCompetencia.F1);
            Assert.IsNotNull(competencia.Competidores);
        }

        [TestMethod]
        public void TestCompetenciaNoDisponibleException()
        {
            bool algo;
            Competencia<AutoF1> competencia = new Competencia<AutoF1>(3, 5, Competencia<AutoF1>.TipoCompetencia.MotoCross);
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
            Competencia<MotoCross> competencia = new Competencia<MotoCross>(3, 5, Competencia<MotoCross>.TipoCompetencia.MotoCross);
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
            Competencia<MotoCross> competencia = new Competencia<MotoCross>(3, 5, Competencia<MotoCross>.TipoCompetencia.MotoCross);
            MotoCross moto = new MotoCross(15, "Ferrari");

            algo = competencia + moto;
            Assert.IsTrue(competencia == moto);
        }

        [TestMethod]
        public void TestQuitarLista()
        {
            bool algo;
            Competencia<MotoCross> competencia = new Competencia<MotoCross>(3, 5, Competencia<MotoCross>.TipoCompetencia.MotoCross);
            MotoCross moto = new MotoCross(15, "Ferrari");

            algo = competencia + moto;
            algo = competencia - moto;
            Assert.IsTrue(competencia != moto);
        }
    }


}
