using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio42;

namespace Ejercicio45
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestClase6()
        {
            try
            {
                Class6 class6 = new Class6();
                class6.MetodoInsatncia();
            }
            catch(Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(MiException));
            }


        }

        [TestMethod]
        public void TestClase5()
        {
            MiException miException = new MiException("Mensaje", new Exception());
            Assert.IsNotNull(miException);
        }

        [TestMethod]
        public void TestClase4()
        {
            UnaException unaException = new UnaException("Hola", new Exception());
            Assert.IsNotNull(unaException);
        }


        [TestMethod]
        public void TestClase3()
        {
            try
            {
                Class3 class3 = new Class3();
                Assert.IsNotNull(class3);
            }
            catch(Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(UnaException));
            }
        }

        [TestMethod]
        public void TestClase2()
        {
            try
            {
                Class2 class2 = new Class2();
                Assert.IsNotNull(class2);
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(DivideByZeroException));
            }
        }

        [TestMethod]
        public void TestClase1()
        {
            try
            {
                Class1 class1 = new Class1();
                Class1.MetodoEstatico();
                Assert.IsNotNull(class1);
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(DivideByZeroException));
            }
        }
    }
}
