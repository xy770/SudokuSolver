using Godot;
using System.Collections;
using System.Collections.Generic;

[GlobalClass]
public partial class SudokuTile : Node2D
{
    [Export]
    public Label NumLabel;
    public Area2D Area2D;

    [ExportGroup("TileInfo")]
    [Export]
    public Vector2I Coord { get; set; }
    public List<int> PossibleNum = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    [Export]
    public bool IsAppied = false;
    [Export]
    public int Num { get; set; }

    private bool _isMouseIn = false;

    public override void _Ready()
    {
        PossibleNum = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    }

    public override void _Process(double delta)
    {
        if (IsAppied)
        {
            if (NumLabel.Text != Num.ToString())
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

    public void MouseEnter()
    {
        _isMouseIn = true;
    }

    public void MouseExit()
    {
        _isMouseIn = false;
    }

    public override void _UnhandledInput(InputEvent @event)
    {
        if (_isMouseIn)
        {
            if (@event.IsActionPressed("1"))
            {
                Apply(1);
            }
            else if (@event.IsActionPressed("2"))
            {
                Apply(2);
            }
            else if (@event.IsActionPressed("3"))
            {
                Apply(3);
            }
            else if (@event.IsActionPressed("4"))
            {
                Apply(4);
            }
            else if (@event.IsActionPressed("5"))
            {
                Apply(5);
            }
            else if (@event.IsActionPressed("6"))
            {
                Apply(6);
            }
            else if (@event.IsActionPressed("7"))
            {
                Apply(7);
            }
            else if (@event.IsActionPressed("8"))
            {
                Apply(8);
            }
            else if (@event.IsActionPressed("9"))
            {
                Apply(9);
            }
        }
    }
}
