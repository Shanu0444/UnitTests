namespace UnitTest_MathLibTest;

using UnitTest_MathLib;

[TestClass]
public class Calculator_Add
{
    [TestMethod]
    public void Calculator_Add_Method_Recieves_Two_Zeroes_And_Returns_Zero()
    {
        Calculator calculator = new Calculator();
        var result = calculator.Add(0,0);
        Assert.AreEqual(0, result);
    }

     [TestMethod]
    public void Calculator_Add_Method_Recieves_One_And_Zero_And_Returns_One()
    {
        Calculator calculator = new Calculator();
        var result = calculator.Add(0,1);
        Assert.AreEqual(1, result);
    }
}