using Godot;
using System;
using System.Text.Json;

public partial class Test : Node
{
    [Export]
    public SudokuTable SudokuTable;

    public override async void _Ready()
    {
        await ToSignal(SudokuTable, "ready");

        SudokuTable.ApplyTileByCoord(new(2, 1), 7);
        SudokuTable.Analyse();
        SudokuTable.Print();
    }
}
