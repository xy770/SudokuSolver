using Godot;
using System;
using System.Collections.Generic;

public partial class SudokuGroup : Node
{
    public List<Vector2I> Coords { get; set; }

    //return the appied num in this group
    public List<int> GetAppiedNum(SudokuTable table)
    {
        List<int> appiedNum = new();

        foreach (Vector2I c in Coords)
        {
            SudokuTile tile = table.GetTileByCoord(c);
            if (tile.IsAppied)
            {
                appiedNum.Add(tile.Num);
            }
        }

        return appiedNum;
    }

    public List<int> GetUniqueValueInPossibleNum(SudokuTable table)
    {
        List<int> allValue = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        List<int> cachedValue = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        foreach (Vector2I c in Coords)
        {
            SudokuTile tile = table.GetTileByCoord(c);
			
            if (tile.IsAppied)
            {
                allValue.Remove(tile.Num);
            }
            else
            {
                foreach (int num in tile.PossibleNum)
                {
                    if (cachedValue.Contains(num))
                    {
                        cachedValue.Remove(num);
                    }
                    else
                    {
                        allValue.Remove(num);
                    }
                }
            }
        }

		return allValue;
    }
}
