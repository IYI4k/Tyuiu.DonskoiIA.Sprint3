using System;
using Tyuiu.DonskoiIA.Sprint3.Task4.V6.Lib;

namespace Tyuiu.DonskoiIA.Sprint3.Task4.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate(-5, 5);
            Assert.AreEqual(-14.134, res);
        }
    }
}