using System;

StreamReader reader = new StreamReader("F:\\dotNETProjekty\\Sudoku-Solver\\Sudoku-Solver\\sudoku.txt");
string[,] sudoku = new string[9, 9];

int lineNum = -1;
string line;
while ((line = reader.ReadLine()) != null)
{
    //Console.WriteLine(line);
    lineNum++;
    string[] numbers = line.Split(' ');
    for(int i = 0; i < numbers.Length; i++)
    {
        sudoku[lineNum, i] = numbers[i];
    }
}

Board board = new Board(sudoku);
board.WriteBoard();
board.Solve();
Console.WriteLine();
board.WriteBoard();
    
reader.Close();
Console.ReadKey();
