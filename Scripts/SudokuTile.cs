using Godot;
using System.Collections;
using System.Collections.Generic;

[GlobalClass]
public partial class SudokuTile : Node2D
{
    public Vector2I Coord { get; set; }
    public List<int> PossibleNum = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    public bool IsAppied = false;
    public int Num { get; set; }

    public override void _Ready()
    {
        PossibleNum = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    }

    public void Apply(int num)
    {
        IsAppied = true;
        Num = num;
        PossibleNum = null;
    }
}
