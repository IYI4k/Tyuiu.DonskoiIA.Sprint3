using System;
using Tyuiu.DonskoiIA.Sprint2.Task7.V9.Lib;

namespace Tyuiu.DonskoiIA.Sprint2.Task7.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.CheckDotInShadedArea(Math.PI / 2, 0.5);
            Assert.AreEqual(true, res);
        }
    }
}