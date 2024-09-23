using System;
using Tyuiu.DonskoiIA.Sprint3.Task3.V24.Lib;

namespace Tyuiu.DonskoiIA.Sprint3.Task3.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.ReplaceCharInString("gft hggt ntg", 'g', '*');
            Assert.AreEqual("*ft h**t nt*", res);
        }
    }
}