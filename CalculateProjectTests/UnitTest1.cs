using CalculateProject;
namespace CalculateProjectTests
{
    [TestClass]
    public class UnitTest1:TestBase
    {
        [TestMethod]
        public void TestMethod1()
        {
            int x = int.Parse(TestContext.Properties["one"].ToString());
            int y = int.Parse(TestContext.Properties["two"].ToString());
            int result = Calculator.Add(x, y);
            Assert.AreEqual(15, result);
        }
        [TestMethod]
        public void Subtract_6_1_results_5()
        {
            int x = 5;
            int y = 12;
            int result = Calculate.Subtract(x, y);
        }

            
        }
    }
}