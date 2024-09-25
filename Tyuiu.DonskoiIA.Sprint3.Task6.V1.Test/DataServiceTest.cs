using System;
using Tyuiu.DonskoiIA.Sprint3.Task6.V1.Lib;

namespace Tyuiu.DonskoiIA.Sprint3.Task5.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.GetSumTheDivisors(2, 4);
            Assert.AreEqual(1+1+1+2+3+4+2, res);
        }
    }
}