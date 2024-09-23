using System;
using Tyuiu.DonskoiIA.Sprint3.Task2.V11.Lib;

namespace Tyuiu.DonskoiIA.Sprint3.Task2.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.GetSumSeries(0, 1, 3);
            Assert.AreEqual(0.481, res);
        }
    }
}