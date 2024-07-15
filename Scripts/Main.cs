using Godot;
using System;
using System.Collections.Generic;

public partial class Main : Node2D
{
    [Export]
    public SudokuTable SudokuTable;

    private readonly int _maxCalculateTime = 10;

    public void Calculate()
    {
        var count = 0;
        while (SudokuTable.GetUnAppliedCount() != 0 && count <= _maxCalculateTime)
        {
            count++;

            SudokuTable.Analyse();
            SudokuTable.ApplyTileByPossibleNum();

            SudokuTable.Print();
        }
    }

    public void Guess()
    {
        SudokuTable.GuessTile();
    }

	public void Clean()
	{
		GetTree().ReloadCurrentScene();
	}
}
