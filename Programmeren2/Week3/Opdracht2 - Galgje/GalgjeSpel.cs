using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht2___Galgje
{
    class GalgjeSpel
    {
        public string geheimWoord;
        public string geradenWoord;

        public void Init(string geheimWoord)
        {
            this.geheimWoord = geheimWoord;

            StringBuilder temp = new StringBuilder();
            for (int i = 0; i < geheimWoord.Length; i++)
            {
                temp.Append(".");
            }

            geradenWoord = temp.ToString();
        }

        public bool RaadLetter(char letter)
        {
            if (geheimWoord.Contains(letter))
            {
                StringBuilder temp = new StringBuilder(geradenWoord);

                for (int i = 0; i < geradenWoord.Length; i++)
                {
                    if (geheimWoord[i] == letter)
                        temp[i] = letter;
                }

                geradenWoord = temp.ToString();

                return true;
            }

            return false;
        }

        public bool IsGeraden()
        {
            if (geradenWoord == geheimWoord)
                return true;

            return false;
        }
    }
}
