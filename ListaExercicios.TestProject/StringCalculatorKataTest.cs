using ListaExercicios.ConsoleApp.Entidades;
using System;
using Xunit;

namespace KataCalculator.Test
{
    public class StringCalculatorKataTest
    {
        [Fact]
        public void Add_StringContainingSingleNumber_ReturnsTheNumberItself()
        {
            //AAA

            //Arrange
            var a = "1";
            var add1 = new StringCalculator(); ;

            //Act
            var soma = add1.Add(a);

            //Assert
            Assert.Equal(1, soma);
        }
        [Theory]
        [InlineData("1,2",3)]
        public void Add_TwoNumbersSeparatedByComma_ReturnsTheirSum(string a, int b)
        {
            //AAA

            //Arrange
            var add1 = new StringCalculator(); ;

            //Act
            var soma = add1.Add(a);

            //Assert
            Assert.Equal(b, soma);
        }
        [Theory]
        [InlineData("1,2,0", 3)]
        public void Add_ThreeNumbersSeparatedByComma_ReturnsTheirSum(string a, int b)
        {
            //AAA

            //Arrange
            var add1 = new StringCalculator(); ;

            //Act
            var soma = add1.Add(a);

            //Assert
            Assert.Equal(b, soma);
        }
        [Theory]
        [InlineData("1,2,0,7,4,5", 19)]
        public void Add_MoreThanThreeNumbersSeparatedByComma_ReturnsTheirSum(string a, int b)
        {
            //AAA

            //Arrange
            var add1 = new StringCalculator(); ;

            //Act
            var soma = add1.Add(a);

            //Assert
            Assert.Equal(b, soma);
        }
        [Theory]
        [InlineData("1,2,0,-77,4,-5", "Números negativos não permitidos :")]
        public void Add_StringContainingNegativeNumbers_Throws(string a, string mensagem)
        {
            //AAA

            //Arrange
            var add1 = new StringCalculator(); ;

            //Act
            var ex = Assert.Throws<ArgumentException>(() => add1.Add(a));

            //Assert
            Assert.Contains(mensagem, ex.Message);
        }
        [Theory]
        [InlineData("1,2,0,,4,", "Sequência inválida")]
        public void Add_StringContainingInvalidSequence_Throws(string a, string mensagem)
        {
            //AAA

            //Arrange
            var add1 = new StringCalculator(); ;

            //Act
            var ex = Assert.Throws<FormatException>(() => add1.Add(a));

            //Assert
            Assert.Equal(mensagem, ex.Message);
        }
        [Theory]
        [InlineData("1,2,0,3,4,9,2,0,3,4,4", "Sequência com tamanho inválido")]
        public void Add_StringContainingMoreThan10NumbersInSequence_Throws(string a, string mensagem)
        {
            //AAA

            //Arrange
            var add1 = new StringCalculator(); ;

            //Act
            var ex = Assert.Throws<ArgumentException>(() => add1.Add(a));

            //Assert
            Assert.Equal(mensagem, ex.Message);
        }
    }
}
