using System;
using System.IO;

namespace PII_Game_Of_Life
{
    public class Board // Cumple con SRP porque tiene una responsabilidad unica y con expert porque la informacion esta relacionada con el tablero
    {
        public bool [,] Tablero { get; set; }

        public Board(bool [,] tablero)
        {
            this.Tablero = tablero;
        }
    }
}
