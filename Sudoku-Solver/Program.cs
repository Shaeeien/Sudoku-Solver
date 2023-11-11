using System;

StreamReader reader = new StreamReader("F:\\dotNETProjekty\\Sudoku-Solver\\Sudoku-Solver\\sudoku.txt");
int[,] sudoku = new int[9, 9];
for (int i = 0; i < 9; i++)
{
    for (int j = 0; j < 9; j++)
    {
        sudoku[i, j] = -1;
    }
}
int lineNum = -1;
string line;
while ((line = reader.ReadLine()) != null)
{
    //Console.WriteLine(line);
    lineNum++;
    string[] numbers = line.Split(' ');
    for(int i = 0; i < numbers.Length; i++)
    {
        sudoku[lineNum, i] = int.Parse(numbers[i]);
    }
}

for(int i = 0; i < 9; i++)
{
    for (int j = 0; j < 9; j++)
    {
        if (sudoku[i, j] != -1)
            Console.Write(sudoku[i, j] + " ");
        else
            Console.Write("  ");
    }
    Console.WriteLine();
}
    
reader.Close();
Console.ReadKey();
