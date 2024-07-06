using System.Text.RegularExpressions;

public static class GroupTemplate
{
    public static SudokuGroup NineSquareBox1 = 
    new SudokuGroup
    {
        SudokuTiles = 
        new()
        {
            new() { Coord = new(0,0) },
            new() { Coord = new(0,1) },
            new() { Coord = new(0,2) },

            new() { Coord = new(1,0) },
            new() { Coord = new(1,1) },
            new() { Coord = new(1,2) },

            new() { Coord = new(2,0) },
            new() { Coord = new(2,1) },
            new() { Coord = new(2,2) },
        }
    };

    public static SudokuGroup NineSquareBox2 = 
    new SudokuGroup
    {
        SudokuTiles = 
        new()
        {
            new() { Coord = new(0,3) },
            new() { Coord = new(0,4) },
            new() { Coord = new(0,5) },

            new() { Coord = new(1,3) },
            new() { Coord = new(1,4) },
            new() { Coord = new(1,5) },

            new() { Coord = new(2,3) },
            new() { Coord = new(2,4) },
            new() { Coord = new(2,5) },
        }
    };
}