using System;
using Tyuiu.DonskoiIA.Sprint3.Task1.V11.Lib;

namespace Tyuiu.DonskoiIA.Sprint3.Task1.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.GetMultiplySeries(0, 1, 3);
            Assert.AreEqual(1.0/8, res);
        }
    }
}