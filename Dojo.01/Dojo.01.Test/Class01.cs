using System;
using Xunit;

namespace Dojo._01.Test
{
    public class Class1
    {

        [Fact]
        public void Given_Jogada_When_Player1_Pedra_Player2_Pedra_Then_Empate()
        {
            //Arrange
            var jogador1 = "pedra";
            var jogador2 = "pedra";

            //Act
            var result = Jogar.Start(jogador1, jogador2);

            //Assert
            Assert.Equal("Foi um empate", result);
        }

        [Fact]
        public void Given_Jogar_When_Player1_Pedra_Player2_Tesoura_Then_Player1Ganha()
        {
            //Arrange
            var jogador1 = "pedra";
            var jogador2 = "tesoura";

            //Act
            var result = Jogar.Start(jogador1, jogador2);
            
                //Assert
                Assert.Equal("Pedra venceu ! ", result);
        }

        [Fact]
        public void Given_Jogar_When_Player1_Pedra_Player2_Papel_Then_Player2Ganha()
        {
            //Arrange
            var jogador1 = "pedra";
            var jogador2 = "papel";

            //Act
            var result = Jogar.Start(jogador1, jogador2);

            //Assert
            Assert.Equal("Papel venceu!", result);
        }
    }










}