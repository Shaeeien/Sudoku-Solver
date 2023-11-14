using System;

public class Cell
{
    public List<int> PossibleNumbers { get; set; }
    public int Value { get; set; }
    public Cell()
	{
        Value = 0;
        PossibleNumbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
	}

    public Cell(int value)
    {
        if(value > 0)
        {
            Value = value;
            PossibleNumbers = new List<int>() { value };
        }
        else
        {
            Value = 0;
            PossibleNumbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        }
    }

    public void Remove(int number)
    {
        if (PossibleNumbers.Count > 1)
        {
            PossibleNumbers.Remove(number);
        }
        else
        {
            Value = PossibleNumbers[0];
        }
    }
}
