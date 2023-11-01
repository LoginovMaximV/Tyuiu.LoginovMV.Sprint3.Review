using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LoginovMV.Sprint3.TaskReview.V22.Lib;

namespace Tyuiu.LoginovMV.Sprint3.TaskReview.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            int len = stopValue - startValue + 1;
            double[] valueWA;
            valueWA = new double[len];
            valueWA[0] = 8.04;
            valueWA[1] = 6.68;
            valueWA[2] = 4.84;
            valueWA[3] = 1.76;
            valueWA[4] = 0.45;
            valueWA[5] = 0.5;
            valueWA[6] = -0.87;
            valueWA[7] = -2.42;
            valueWA[8] = -3.88;
            valueWA[9] = -6.83;
            valueWA[10] = -8.88;
            double[] wait;
            wait = new double[len];
            wait = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWA, wait);
        }
    }
}
