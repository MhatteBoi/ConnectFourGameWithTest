using ConnectFour;
using Xunit;
using System.Collections.Generic;
using static ConnectFour.GameState;

namespace TestFourConnect
{
    public class UnitTest1
    {
        [Fact]
        public void CheckForWin_NoWinner_EmptyBoard()
        {
            // Arrange
            var gameState = new GameState(); 
            var expectedResult = gameState.CheckForWin();

            // Act
            var result = WinState.No_Winner;

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void CheckForWin_TieGame()
        {
            // Arrange
            var gameState = new GameState();
            gameState.TheBoard = new List<int>() { //player2 wins?
                    1, 1, 1, 2, 1, 1, 1,
                    2, 1, 2, 1, 2, 1, 2,
                    1, 2, 1, 2, 1, 2, 1,
                    2, 1, 2, 1, 2, 1, 2,
                    1, 2, 1, 2, 1, 2, 1,
                    2, 1, 2, 1, 2, 1, 2
                    //sätt ut olika för att se fall p1,p2 vinner eller om det blir en tie
                };

            var expectedResult = GameState.WinState.Tie;

            // Act
            var result = gameState.CheckForWin();

            // Assert
            Assert.Equal(expectedResult, result);
        }

    }
}