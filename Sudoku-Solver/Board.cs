using System;

public class Board
{
    public Cell[,] Cells { get; set; } = new Cell[9, 9];
    public Board(string[,] file)
    {
        for (int i = 0; i < 9; i++)
        {
            for(int j = 0; j < 9; j++)
            {
                Cells[i, j] = new Cell(int.Parse(file[i, j]));
            }
        }
	}

    public void WriteBoard()
    {
        for(int i = 0; i < 9; i++)
        {
            for(int j = 0; j < 9; j++)
            {
                Console.Write(Cells[i, j].Value + " ");
            }
            Console.WriteLine();
        }
    }
}
