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

        SudokuTable.ApplyTileByCoord(new(0, 0), 1);
        SudokuTable.ApplyTileByCoord(new(0, 1), 2);
        SudokuTable.ApplyTileByCoord(new(0, 2), 7);
        SudokuTable.ApplyTileByCoord(new(0, 4), 8);
        SudokuTable.ApplyTileByCoord(new(0, 5), 4);
        SudokuTable.ApplyTileByCoord(new(1, 0), 3);
        SudokuTable.ApplyTileByCoord(new(1, 1), 5);
        SudokuTable.ApplyTileByCoord(new(1, 3), 1);
        SudokuTable.ApplyTileByCoord(new(2, 1), 9);
        SudokuTable.ApplyTileByCoord(new(2, 3), 3);
        SudokuTable.ApplyTileByCoord(new(2, 4), 2);
        SudokuTable.ApplyTileByCoord(new(2, 7), 4);
        SudokuTable.Analyse();
        SudokuTable.Print();
    }
}
