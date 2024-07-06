using Godot;
using System;
using System.Collections.Generic;

public partial class SudokuGroup : Node
{
    public List<Vector2I> Coords { get; set; }
	public SudokuTable table;

	//return the appied num in this group
	public List<int> GetAppiedNum(SudokuTable table)
	{
		List<int> appiedNum = new();

		foreach(Vector2I c in Coords)
		{
			SudokuTile tile = table.GetTileByCoord(c);
			if(tile.IsAppied)
			{
				appiedNum.Add(tile.Num);
			}
		}

		return appiedNum;
	}
}
