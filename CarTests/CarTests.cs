using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CarTests
{
    [TestClass]
    public class CarTests
    {
        //TODO: add emptyTest so we can configure our runtime environment (remove this test before pushing to your personal GitHub account)
       [TestMethod]
       public void EmptyTest()
        {
            Assert.AreEqual(10, 10, .001);
        }
        //TODO: constructor sets gasTankLevel properly
        CarTests test_car;
                
        [TestInitialize]
        public void CreateCarObject()
        {
            //Car test_car = new Car("Toyota", "Prius", 10, 50);
            test_car = new Car("Toyota", "Prius", 10, 50);
        }
        //TODO: gasTankLevel is accurate after driving within tank range
        //TODO: gasTankLevel is accurate after attempting to drive past tank range
        //TODO: can't have more gas than tank size, expect an exception

    }
}
