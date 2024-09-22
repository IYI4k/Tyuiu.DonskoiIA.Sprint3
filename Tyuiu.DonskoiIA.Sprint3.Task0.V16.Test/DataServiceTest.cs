using System;
using Tyuiu.DonskoiIA.Sprint3.Task0.V16.Lib;

namespace Tyuiu.DonskoiIA.Sprint3.Task0.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.GetMultiplySeries(2, 1, 2);
            Assert.AreEqual(8, res);
        }
    }
}