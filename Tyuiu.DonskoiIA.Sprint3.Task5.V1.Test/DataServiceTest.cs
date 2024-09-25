using System;
using Tyuiu.DonskoiIA.Sprint3.Task5.V1.Lib;

namespace Tyuiu.DonskoiIA.Sprint3.Task5.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.GetSumSumSeries(1, 0, 0, 0, 0);
            Assert.AreEqual(0.5, res);
        }
    }
}