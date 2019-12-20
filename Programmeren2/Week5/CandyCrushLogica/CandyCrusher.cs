using System;
using System.Collections.Generic;
using System.Text;

namespace CandyCrushLogica
{
    public class CandyCrusher
    {
        public static bool ScoreRijAanwezig(Enums.RegularCandies[,] speelveld)
        {
            int rows = speelveld.GetLength(0);
            int columns = speelveld.GetLength(1);

            for (int r = 0; r < rows; r++)
            {
                int counter = 1;
                Enums.RegularCandies prev = new Enums.RegularCandies();

                for (int c = 0; c < columns; c++)
                {
                    Enums.RegularCandies currentCandy = speelveld[r, c];

                    if (c == 0)
                    {
                        prev = currentCandy;
                        continue;
                    }

                    if (currentCandy == prev)
                        counter++;
                    else
                        counter = 1;

                    if (counter == 3)
                        return true;

                    prev = currentCandy;
                }
            }

            return false;
        }

        public static bool ScoreKolomAanwezig(Enums.RegularCandies[,] speelveld)
        {
            int rows = speelveld.GetLength(0);
            int columns = speelveld.GetLength(1);

            for (int c = 0; c < columns; c++)
            {
                int counter = 1;
                Enums.RegularCandies prev = new Enums.RegularCandies();

                for (int r = 0; r < rows; r++)
                {
                    Enums.RegularCandies currentCandy = speelveld[r, c];

                    if (r == 0)
                    {
                        prev = currentCandy;
                        continue;
                    }

                    if (currentCandy == prev)
                        counter++;
                    else
                        counter = 1;

                    if (counter == 3)
                        return true;

                    prev = currentCandy;
                }
            }

            return false;
        }
    }
}
