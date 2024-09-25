using System;
using Tyuiu.DonskoiIA.Sprint3.Task7.V18.Lib;

namespace Tyuiu.DonskoiIA.Sprint3.Task7.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.GetMassFunction(0, 2);
            CollectionAssert.AreEqual(new double[] { 2, 4.5, 5.333}, res);
        }
    }
}