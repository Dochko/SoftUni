using System.Collections.Generic;

namespace Minesweeper
{
    public class MinesweeperRun
    {
        private static void Main()
        {
            char[,] board = Engine.CreatePlayingField();
            char[,] bombs = Engine.PopulateBombs();
            int counter = 0;
            bool foundBomb = false;
            List<Player> hallOfFame = new List<Player>(6);
            int row = 0;
            int col = 0;
            bool gameStart = true;
            const int counterMax = 35;
            bool gameEnd = false;

            Engine.Run(
                gameStart,
                board,
                row,
                col,
                hallOfFame,
                bombs,
                foundBomb,
                counter,
                counterMax,
                gameEnd);
        }
    }
}