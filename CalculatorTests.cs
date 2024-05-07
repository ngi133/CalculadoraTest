using Calculadora; // Asumiendo que la clase Calculator está en el espacio de nombres "Calculadora"

namespace CalculadoraTests
{
    public class CalculatorTests
    {
        public Calculator _calculator;

        public CalculatorTests()
        {
            _calculator = new Calculator();
        }

        // Prueba para el método Add
        [Fact]
        public void Add_ShouldReturnCorrectResult()
        {
            // Arrange
            double a = 3;
            double b = 4;
            double expected = 7;

            // Act
            double result = _calculator.Add(a, b);

            // Assert
            Assert.Equal(expected, result);
        }

        // Prueba para el método Subtract
        [Fact]
        public void Subtract_ShouldReturnCorrectResult()
        {
            // Arrange
            double a = 10;
            double b = 3;
            double expected = 7;

            // Act
            double result = _calculator.Subtract(a, b);

            // Assert
            Assert.Equal(expected, result);
        }

        // Prueba para el método Multiply
        [Fact]
        public void Multiply_ShouldReturnCorrectResult()
        {
            // Arrange
            double a = 2;
            double b = 6;
            double expected = 12;

            // Act
            double result = _calculator.Multiply(a, b);

            // Assert
            Assert.Equal(expected, result);
        }

        // Prueba para el método Divide
        [Fact]
        public void Divide_ShouldReturnCorrectResult()
        {
            // Arrange
            double a = 10;
            double b = 2;
            double expected = 5;

            // Act
            double result = _calculator.Divide(a, b);

            // Assert
            Assert.Equal(expected, result);
        }

        // Prueba para el caso de división por cero
        [Fact]
        public void Divide_ShouldThrowDivideByZeroException()
        {
            // Arrange
            double a = 10;
            double b = 0;

            // Act & Assert
            Assert.Throws<DivideByZeroException>(() => _calculator.Divide(a, b));
        }
    }
}