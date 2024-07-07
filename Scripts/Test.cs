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
        SudokuTable.ApplyTileByCoord(new(3, 1), 3);
        SudokuTable.ApplyTileByCoord(new(3, 2), 6);
        SudokuTable.ApplyTileByCoord(new(3, 3), 4);
        SudokuTable.ApplyTileByCoord(new(3, 7), 9);
        SudokuTable.ApplyTileByCoord(new(4, 1), 8);
        SudokuTable.ApplyTileByCoord(new(4, 3), 2);
        SudokuTable.ApplyTileByCoord(new(4, 4), 6);
        SudokuTable.ApplyTileByCoord(new(4, 5), 3);
        SudokuTable.ApplyTileByCoord(new(4, 7), 5);
        SudokuTable.ApplyTileByCoord(new(5, 1), 1);
        SudokuTable.ApplyTileByCoord(new(5, 5), 8);
        SudokuTable.ApplyTileByCoord(new(5, 6), 4);
        SudokuTable.ApplyTileByCoord(new(5, 7), 3);
        SudokuTable.ApplyTileByCoord(new(6, 1), 7);
        SudokuTable.ApplyTileByCoord(new(6, 4), 4);
        SudokuTable.ApplyTileByCoord(new(6, 5), 2);
        SudokuTable.ApplyTileByCoord(new(6, 7), 1);
        SudokuTable.ApplyTileByCoord(new(7, 5), 9);
        SudokuTable.ApplyTileByCoord(new(7, 7), 7);
        SudokuTable.ApplyTileByCoord(new(7, 8), 3);
        SudokuTable.ApplyTileByCoord(new(8, 3), 5);
        SudokuTable.ApplyTileByCoord(new(8, 4), 3);
        SudokuTable.ApplyTileByCoord(new(8, 6), 2);
        SudokuTable.ApplyTileByCoord(new(8, 7), 8);
        SudokuTable.ApplyTileByCoord(new(8, 8), 4);

        SudokuTable.ApplyTileByCoord(new(4, 6), 1);
        SudokuTable.ApplyTileByCoord(new(5, 0), 2);
        SudokuTable.ApplyTileByCoord(new(6, 0), 5);

        while (SudokuTable.GetUnAppliedCount() != 0)
        {
            SudokuTable.Analyse();
            SudokuTable.Print();
            SudokuTable.ApplyTileByPossibleNum();
            GD.Print("[Info]: " + "UnAppliedCount = " + SudokuTable.GetUnAppliedCount());
            SudokuTable.Print();
        }
    }
}
