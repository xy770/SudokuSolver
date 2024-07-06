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

    public readonly static SudokuGroup NineSquareBox3 = 
    new()
    {
        Coords = 
        new()
        {
            new(0,6),
            new(0,7),
            new(0,8),

            new(1,6),
            new(1,7),
            new(1,8),

            new(2,6),
            new(2,7),
            new(2,8),
        }
    };

    public readonly static SudokuGroup NineSquareBox4 = 
    new()
    {
        Coords = 
        new()
        {
            new(3,0),
            new(3,1),
            new(3,2),

            new(4,0),
            new(4,1),
            new(4,2),

            new(5,0),
            new(5,1),
            new(5,2),
        }
    };

    public readonly static SudokuGroup NineSquareBox5 = 
    new()
    {
        Coords = 
        new()
        {
            new(3,3),
            new(3,4),
            new(3,5),

            new(4,3),
            new(4,4),
            new(4,5),

            new(5,3),
            new(5,4),
            new(5,5),
        }
    };

    public readonly static SudokuGroup NineSquareBox6 = 
    new()
    {
        Coords = 
        new()
        {
            new(3,6),
            new(3,7),
            new(3,8),

            new(4,6),
            new(4,7),
            new(4,8),

            new(5,6),
            new(5,7),
            new(5,8),
        }
    };

    public readonly static SudokuGroup NineSquareBox7 = 
    new()
    {
        Coords = 
        new()
        {
            new(6,0),
            new(6,1),
            new(6,2),

            new(7,0),
            new(7,1),
            new(7,2),

            new(8,0),
            new(8,1),
            new(8,2),
        }
    };

    public readonly static SudokuGroup NineSquareBox8 = 
    new()
    {
        Coords = 
        new()
        {
            new(6,3),
            new(6,4),
            new(6,5),

            new(7,3),
            new(7,4),
            new(7,5),

            new(8,3),
            new(8,4),
            new(8,5),
        }
    };

    public readonly static SudokuGroup NineSquareBox9 = 
    new()
    {
        Coords = 
        new()
        {
            new(6,6),
            new(6,7),
            new(6,8),

            new(7,6),
            new(7,7),
            new(7,8),

            new(8,6),
            new(8,7),
            new(8,8),
        }
    };

    public readonly static SudokuGroup VerticalLine1 = 
    new()
    {
        Coords = 
        new()
        {
            new(0,0),
            new(0,1),
            new(0,2),
            new(0,3),
            new(0,4),
            new(0,5),
            new(0,6),
            new(0,7),
            new(0,8),
        }
    };

    public readonly static SudokuGroup VerticalLine2 = 
    new()
    {
        Coords = 
        new()
        {
            new(1,0),
            new(1,1),
            new(1,2),
            new(1,3),
            new(1,4),
            new(1,5),
            new(1,6),
            new(1,7),
            new(1,8),
        }
    };

    public readonly static SudokuGroup VerticalLine3 = 
    new()
    {
        Coords = 
        new()
        {
            new(2,0),
            new(2,1),
            new(2,2),
            new(2,3),
            new(2,4),
            new(2,5),
            new(2,6),
            new(2,7),
            new(2,8),
        }
    };

    public readonly static SudokuGroup VerticalLine4 = 
    new()
    {
        Coords = 
        new()
        {
            new(3,0),
            new(3,1),
            new(3,2),
            new(3,3),
            new(3,4),
            new(3,5),
            new(3,6),
            new(3,7),
            new(3,8),
        }
    };

    public readonly static SudokuGroup VerticalLine5 = 
    new()
    {
        Coords = 
        new()
        {
            new(4,0),
            new(4,1),
            new(4,2),
            new(4,3),
            new(4,4),
            new(4,5),
            new(4,6),
            new(4,7),
            new(4,8),
        }
    };

    public readonly static SudokuGroup VerticalLine6 = 
    new()
    {
        Coords = 
        new()
        {
            new(5,0),
            new(5,1),
            new(5,2),
            new(5,3),
            new(5,4),
            new(5,5),
            new(5,6),
            new(5,7),
            new(5,8),
        }
    };

    public readonly static SudokuGroup VerticalLine7 = 
    new()
    {
        Coords = 
        new()
        {
            new(6,0),
            new(6,1),
            new(6,2),
            new(6,3),
            new(6,4),
            new(6,5),
            new(6,6),
            new(6,7),
            new(6,8),
        }
    };

    public readonly static SudokuGroup VerticalLine8 = 
    new()
    {
        Coords = 
        new()
        {
            new(7,0),
            new(7,1),
            new(7,2),
            new(7,3),
            new(7,4),
            new(7,5),
            new(7,6),
            new(7,7),
            new(7,8),
        }
    };

    public readonly static SudokuGroup VerticalLine9 = 
    new()
    {
        Coords = 
        new()
        {
            new(8,0),
            new(8,1),
            new(8,2),
            new(8,3),
            new(8,4),
            new(8,5),
            new(8,6),
            new(8,7),
            new(8,8),
        }
    };

    public readonly static SudokuGroup HorizontalLine1 = 
    new()
    {
        Coords = 
        new()
        {
            new(0,0),
            new(1,0),
            new(2,0),
            new(3,0),
            new(4,0),
            new(5,0),
            new(6,0),
            new(7,0),
            new(8,0),
        }
    };

    public readonly static SudokuGroup HorizontalLine2 = 
    new()
    {
        Coords = 
        new()
        {
            new(0,1),
            new(1,1),
            new(2,1),
            new(3,1),
            new(4,1),
            new(5,1),
            new(6,1),
            new(7,1),
            new(8,1),
        }
    };

    public readonly static SudokuGroup HorizontalLine3 = 
    new()
    {
        Coords = 
        new()
        {
            new(0,2),
            new(1,2),
            new(2,2),
            new(3,2),
            new(4,2),
            new(5,2),
            new(6,2),
            new(7,2),
            new(8,2),
        }
    };

    public readonly static SudokuGroup HorizontalLine4 = 
    new()
    {
        Coords = 
        new()
        {
            new(0,3),
            new(1,3),
            new(2,3),
            new(3,3),
            new(4,3),
            new(5,3),
            new(6,3),
            new(7,3),
            new(8,3),
        }
    };

    public readonly static SudokuGroup HorizontalLine5 = 
    new()
    {
        Coords = 
        new()
        {
            new(0,4),
            new(1,4),
            new(2,4),
            new(3,4),
            new(4,4),
            new(5,4),
            new(6,4),
            new(7,4),
            new(8,4),
        }
    };

    public readonly static SudokuGroup HorizontalLine6 = 
    new()
    {
        Coords = 
        new()
        {

            new(0,5),
            new(1,5),
            new(2,5),
            new(3,5),
            new(4,5),
            new(5,5),
            new(6,5),
            new(7,5),
            new(8,5),
        }
    };

    public readonly static SudokuGroup HorizontalLine7 = 
    new()
    {
        Coords = 
        new()
        {
            new(0,6),
            new(1,6),
            new(2,6),
            new(3,6),
            new(4,6),
            new(5,6),
            new(6,6),
            new(7,6),
            new(8,6),
        }
    };

    public readonly static SudokuGroup HorizontalLine8 = 
    new()
    {
        Coords = 
        new()
        {
            new(0,7),
            new(1,7),
            new(2,7),
            new(3,7),
            new(4,7),
            new(5,7),
            new(6,7),
            new(7,7),
            new(8,7),
        }
    };

    public readonly static SudokuGroup HorizontalLine9 = 
    new()
    {
        Coords = 
        new()
        {
            new(0,8),
            new(1,8),
            new(2,8),
            new(3,8),
            new(4,8),
            new(5,8),
            new(6,8),
            new(7,8),
            new(8,8),
        }
    };
}