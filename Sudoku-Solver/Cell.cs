using System;

public class Cell
{
    public List<int> PossibleNumbers { get; set; }
    public int Value { get; set; }
    public Cell()
	{
        Value = -1;
        PossibleNumbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
	}

    public Cell(int value)
    {

    }

    public void Remove(int number)
    {
        PossibleNumbers.Remove(number);
    }
}
