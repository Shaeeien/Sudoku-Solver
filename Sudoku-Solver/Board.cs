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

    private bool TestCell(int rowNum, int colNum, int value)
    {
        int centerX = (rowNum / 3) * 3 + 1;
        int centerY = (colNum / 3) * 3 + 1;
        for(int i = -1; i <= 1; i++)
        {
            for(int j = -1; j <= 1; j++)
            {
                if (Cells[centerX + i, centerY + j].Value == value)
                    return false;
            }
        }
        return true;
    }

    private (int, int) FindUnassigned()
    {
        for(int i = 0; i < 9;i++)
        {
            for(int j = 0; j < 9; j++)
            {
                if (Cells[i, j].Value == 0)
                    return (i, j);
            }
        }
        return (-1, -1);
    }

    private bool TestRow(int rowNum, int value)
    {
        for(int i = 0; i < 9; i++)
        {
            if (Cells[rowNum, i].Value == value)
            {
                return false;
            }
        }
        return true;
    }

    private bool TestCol(int colNum, int value) 
    {
        for (int i = 0; i < 9; i++)
        {
            if (Cells[i, colNum].Value == value)
            {
                return false;
            }
        }
        return true;
    }

    /*
      (0,0)(0,1)(0,2)(0,3)(0,4)(0,5)(0,6)(0,7)(0,8)
      (1,0)(1,1)(1,2)(1,3)(1,4)(1,5)(1,6)(1,7)(1,8)
      (2,0)(2,1)(2,2)(2,3)(2,4)(2,5)(2,6)(2,7)(2,8)
      (3,0)(3,1)(3,2)(3,3)(3,4)(3,5)(3,6)(3,7)(3,8)
      (4,0)(4,1)(4,2)(4,3)(4,4)(4,5)(4,6)(4,7)(4,8)
      (5,0)(5,1)(5,2)(5,3)(5,4)(5,5)(5,6)(5,7)(5,8)
      (6,0)(6,1)(6,2)(6,3)(6,4)(6,5)(6,6)(6,7)(6,8)
      (7,0)(7,1)(7,2)(7,3)(7,4)(7,5)(7,6)(7,7)(7,8)
      (8,0)(8,1)(8,2)(8,3)(8,4)(8,5)(8,6)(8,7)(8,8)
    */
    public bool Solve()
    {
        (int i, int j) unassigned  = FindUnassigned();
        if (unassigned.i == -1 && unassigned.j == -1)
            return true;
        for(int num = 1; num <= 9; num++)
        {
            if(TestRow(unassigned.i, num) && TestCol(unassigned.j, num) && TestCell(unassigned.i, unassigned.j, num))
            {
                Cells[unassigned.i, unassigned.j].Value = num;
                if (Solve())
                    return true;
                Cells[unassigned.i, unassigned.j].Value = 0;
            }
        }
        return false;
    }

    public bool IsSolved()
    {
        
        for(int i = 0;i < 9;i++)
        {
            for(int j = 0; j < 9; j++)
            {
                if (Cells[i, j].Value == 0)
                {
                    return false;
                }
            }
        }
        return true;
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
