using Godot;
using System;
using System.Collections.Generic;

public partial class SudokuGroup : Node
{
    public List<SudokuTile> SudokuTiles { get; set; }

	//return the appied num in this group
	public List<int> GetAppiedNum()
	{
		List<int> appiedNum = new();

		foreach(SudokuTile tile in SudokuTiles)
		{
			if(tile.IsAppied)
			{
				appiedNum.Add(tile.Num);
			}
		}

		return appiedNum;
	}
}
