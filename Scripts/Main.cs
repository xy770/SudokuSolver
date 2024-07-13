using Godot;
using System;

public partial class Main : Node2D
{
    [Export]
    public SudokuTable SudokuTable;

	private readonly int _maxCaculateTime = 10;

	public void Caculate()
	{
		var count = 0;
		while(SudokuTable.GetUnAppliedCount() != 0 && count <= _maxCaculateTime)
		{
			count++;

            SudokuTable.Analyse();
            SudokuTable.ApplyTileByPossibleNum();

			SudokuTable.Print();
		}
	}

	public void Guess()
	{
		SudokuTable.GuessTile(SudokuTable.GetFirstUnApplyTileCoord());
	}
}
