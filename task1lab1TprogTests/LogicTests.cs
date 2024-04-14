using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    namespace FirstApp.Tests
    {
        [TestClass()]
        public class LogicTests
        {
            [TestMethod()]//1-й тест: введенно число из отрицательного диапазона
            public void getnegativenumber()
            {
                double x = -7;
                Double anser = Logic.solution(x);
                Assert.AreEqual(0, anser);
            }

            [TestMethod()]//2-й тест: проверка границы диапазона диапазона, а именно числа 0
            public void getzero()
            {
                double x = 0;
                Double anser = Logic.solution(x);
                Assert.AreEqual(0, anser);
            }
            [TestMethod()]//3-й тест: проверка границы диапазона диапазона, а именно числа 1
            public void getone()
            {
                double x = 1;
                Double anser = Logic.solution(x);
                Assert.AreEqual(1, anser);
            }
            [TestMethod()]//4-й тест:  введенно число из диапазона от 0 до 1
            public void getfraction()
            {
                double x = 0.56;
                Double anser = Logic.solution(x);
                Assert.AreEqual(0.56, anser);
            }
            [TestMethod()]//5-й тест:  введенно число из положительного диапазона
            public void getpositivenumber()
            {
                double x = 4;
                Double anser = Logic.solution(x);
                Assert.AreEqual(16, anser);
            }
        }
    }

}