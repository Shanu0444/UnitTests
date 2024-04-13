namespace UnitTest_MathLibTest;

using UnitTest_MathLib;

[TestClass]
public class Calculator_Divide
{
    [TestMethod]
    public void Calculator_Divide_Method_Recieves_A_Number_And_One_Returns_Number()
    {
        Calculator calculator = new Calculator();
        var ret = calculator.Divide(3,1);
        Assert.AreEqual(3, ret);

    }

    [TestMethod]
    [DataRow(2.0,2.0,1.0)]
    [DataRow(5.0,5.0,1.0)]
    public void Calculator_Divide_Method_Recieves_TwoOfSameNumbers_Then_Returns_One(double left, double right,  double expected)
    {
        Calculator calculator = new Calculator();
        var ret = calculator.Divide((decimal)left,(decimal)right);
        Assert.AreEqual((decimal)expected, ret);

    }

     [TestMethod]
    public void Calculator_Divide_By_Zero_Throws_Exception()
    {
        Calculator calculator = new Calculator();
        
        // double x = 0;
        // double y = 1/x;
        Assert.ThrowsException<DivideByZeroException>(() => calculator.Divide(4,0));

    }
}