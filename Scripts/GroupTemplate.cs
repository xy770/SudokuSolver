using System.Text.RegularExpressions;

public static class GroupTemplate
{
    public readonly static SudokuGroup NineSquareBox1 = 
    new()
    {
        Coords = 
        new()
        {
            new(0,0),
            new(0,1),
            new(0,2),

            new(1,0),
            new(1,1),
            new(1,2),

            new(2,0),
            new(2,1),
            new(2,2),
        }
    };

    public readonly static SudokuGroup NineSquareBox2 = 
    new()
    {
        Coords = 
        new()
        {
            new(0,3),
            new(0,4),
            new(0,5),

            new(1,3),
            new(1,4),
            new(1,5),

            new(2,3),
            new(2,4),
            new(2,5),
        }
    };
}