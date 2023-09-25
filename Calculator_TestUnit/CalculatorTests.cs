using net_calculator_tester.Classes;

namespace Calculator_TestUnit
{
    [TestFixture]
    public class CalculatorTests
    {
             
        // METHODS TO BE TESTED
        public static float Add(float a, float b)
        {
            return a + b;
        }
        public static float Substract(float a, float b)
        {
            return a - b;
        }
        public static float Divide(float a, float b)
        {
            if (b == 0)
            {
                throw new System.ArgumentException("You can not divide by 0");
            }
            return a / b;
        }
        public static float Multiply(float a, float b)
        {
            return a * b;
        }

        // TESTING
        [Test]
        public void Add_ShouldReturnCorrectSum()
        {
            float result = Add(10.5f, 5.5f);
            Assert.AreEqual(16.0f, result);
        }

        [Test]
        public void Subtract_ShouldReturnCorrectDifference()
        {
            float result = Substract(10.5f, 5.5f);
            Assert.AreEqual(5.0f, result);
        }

        [Test]
        public void Divide_ShouldReturnCorrectQuotient()
        {
            float result = Divide(10.0f, 2.0f);
            Assert.AreEqual(5.0f, result);
        }

        [Test]
        public void Divide_ByZero_ShouldThrowArgumentException()
        {
            Assert.Throws<System.ArgumentException>(() => Divide(10.0f, 0.0f));
        }

        [Test]
        public void Multiply_ShouldReturnCorrectProduct()
        {
            float result = Multiply(10.5f, 5.0f);
            Assert.AreEqual(52.5f, result);
        }

        // BONUS TESTING

        // Addition tests
        [Test]
        public void Add_ShouldReturnCorrectSum_ForPositiveNumbers()
        {
            float result = Calculator.Add(10.5f, 5.5f);
            Assert.AreEqual(16.0f, result);
        }

        [Test]
        public void Add_ShouldReturnCorrectSum_ForNegativeNumbers()
        {
            float result = Calculator.Add(-10.5f, -5.5f);
            Assert.AreEqual(-16.0f, result);
        }

        [Test]
        public void Add_ShouldReturnCorrectSum_ForPositiveAndNegativeNumbers()
        {
            float result = Calculator.Add(-10.5f, 5.5f);
            Assert.AreEqual(-5.0f, result);
        }

        [Test]
        public void Add_ShouldReturnSameNumber_WhenAddingZero()
        {
            float result = Calculator.Add(10.5f, 0.0f);
            Assert.AreEqual(10.5f, result);
        }

        // Subtraction tests
        [Test]
        public void Subtract_ShouldReturnCorrectDifference_ForPositiveNumbers()
        {
            float result = Calculator.Substract(10.5f, 5.5f);
            Assert.AreEqual(5.0f, result);
        }

        [Test]
        public void Subtract_ShouldReturnCorrectDifference_ForNegativeNumbers()
        {
            float result = Calculator.Substract(-10.5f, -5.5f);
            Assert.AreEqual(-5.0f, result);
        }

        [Test]
        public void Subtract_ShouldReturnCorrectDifference_ForPositiveAndNegativeNumbers()
        {
            float result = Substract(10.5f, -5.5f);
            Assert.AreEqual(16.0f, result);
        }

        [Test]
        public void Subtract_ShouldReturnSameNumber_WhenSubtractingZero()
        {
            float result = Substract(10.5f, 0.0f);
            Assert.AreEqual(10.5f, result);
        }

        // Multiplication tests
        [Test]
        public void Multiply_ShouldReturnCorrectProduct_ForPositiveNumbers()
        {
            float result = Multiply(10.5f, 5.0f);
            Assert.AreEqual(52.5f, result);
        }

        [Test]
        public void Multiply_ShouldReturnCorrectProduct_ForNegativeNumbers()
        {
            float result = Multiply(-10.5f, -5.0f);
            Assert.AreEqual(52.5f, result);
        }

        [Test]
        public void Multiply_ShouldReturnCorrectProduct_ForPositiveAndNegativeNumbers()
        {
            float result = Multiply(-10.5f, 5.0f);
            Assert.AreEqual(-52.5f, result);
        }

        [Test]
        public void Multiply_ShouldReturnZero_WhenMultiplyingByZero()
        {
            float result = Multiply(10.5f, 0.0f);
            Assert.AreEqual(0.0f, result);
        }

        // Division tests
        [Test]
        public void Divide_ShouldReturnCorrectQuotient_ForValidDivision()
        {
            float result = Divide(10.0f, 2.0f);
            Assert.AreEqual(5.0f, result);
        }

        [Test]
        public void Divide_ShouldReturnZero_WhenDividingZeroByNumber()
        {
            float result = Divide(0.0f, 10.0f);
            Assert.AreEqual(0.0f, result);
        }

        [Test]
        public void Divide_ShouldReturnCorrectResult_WhenDividingNegativeNumber()
        {
            float result = Divide(-10.0f, 5.0f);
            Assert.AreEqual(-2.0f, result);
        }
    }
}