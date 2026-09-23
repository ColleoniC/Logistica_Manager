using System;

namespace Progetto_GPO
{
    internal class Griglia
    {
        public int[][] Grid { get; private set; }

        public int Columns { get; private set; }

        public int Rows { get; private set; }

        public Griglia(int columns, int rows)
        {
            Columns = columns;
            Rows = rows;

            Grid = new int[Rows][];

            for (int i = 0; i < Rows; i++)
            {
                Grid[i] = new int[Columns];
            }
        }

        public void ImpostaValore(int riga, int colonna, int valore)
        {
            if (riga >= 0 && riga < Rows &&
                colonna >= 0 && colonna < Columns)
            {
                Grid[riga][colonna] = valore;
            }
        }

        public int LeggiValore(int riga, int colonna)
        {
            if (riga >= 0 && riga < Rows &&
                colonna >= 0 && colonna < Columns)
            {
                return Grid[riga][colonna];
            }

            return 0;
        }
    }
}