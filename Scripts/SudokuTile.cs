using Godot;
using System.Collections;
using System.Collections.Generic;

[GlobalClass]
public partial class SudokuTile : Node2D
{
    [Export]
    public Label NumLabel;

    [ExportGroup("TileInfo")]
    [Export]
    public Vector2I Coord { get; set; }
    public List<int> PossibleNum = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    [Export]
    public bool IsAppied = false;
    [Export]
    public int Num { get; set; }

    public override void _Ready()
    {
        PossibleNum = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    }

    public override void _Process(double delta)
    {
        if (IsAppied)
        {
            if(NumLabel.Text != Num.ToString())
            {
                NumLabel.Text = Num.ToString();
            }
        }
        else
        {
            NumLabel.Text = "";
        }
    }

    public void Apply(int num)
    {
        IsAppied = true;
        Num = num;
        PossibleNum = null;
    }
}
