using Godot;
using System.Collections.Generic;
using System.Text.Json;

[GlobalClass]
public partial class SudokuTable : Node
{
    public List<SudokuGroup> Groups { get; set; }
    public List<SudokuTile> SudokuTiles { get; set; }

    public override void _Ready()
    {
        SudokuTiles =
        new List<SudokuTile>{
            new() { Coord = new(0,0) },
            new() { Coord = new(0,1) },
            new() { Coord = new(0,2) },
            new() { Coord = new(0,3) },
            new() { Coord = new(0,4) },
            new() { Coord = new(0,5) },
            new() { Coord = new(0,6) },
            new() { Coord = new(0,7) },
            new() { Coord = new(0,8) },

            new() { Coord = new(1,0) },
            new() { Coord = new(1,1) },
            new() { Coord = new(1,2) },
            new() { Coord = new(1,3) },
            new() { Coord = new(1,4) },
            new() { Coord = new(1,5) },
            new() { Coord = new(1,6) },
            new() { Coord = new(1,7) },
            new() { Coord = new(1,8) },

            new() { Coord = new(2,0) },
            new() { Coord = new(2,1) },
            new() { Coord = new(2,2) },
            new() { Coord = new(2,3) },
            new() { Coord = new(2,4) },
            new() { Coord = new(2,5) },
            new() { Coord = new(2,6) },
            new() { Coord = new(2,7) },
            new() { Coord = new(2,8) },

            new() { Coord = new(3,0) },
            new() { Coord = new(3,1) },
            new() { Coord = new(3,2) },
            new() { Coord = new(3,3) },
            new() { Coord = new(3,4) },
            new() { Coord = new(3,5) },
            new() { Coord = new(3,6) },
            new() { Coord = new(3,7) },
            new() { Coord = new(3,8) },

            new() { Coord = new(4,0) },
            new() { Coord = new(4,1) },
            new() { Coord = new(4,2) },
            new() { Coord = new(4,3) },
            new() { Coord = new(4,4) },
            new() { Coord = new(4,5) },
            new() { Coord = new(4,6) },
            new() { Coord = new(4,7) },
            new() { Coord = new(4,8) },

            new() { Coord = new(5,0) },
            new() { Coord = new(5,1) },
            new() { Coord = new(5,2) },
            new() { Coord = new(5,3) },
            new() { Coord = new(5,4) },
            new() { Coord = new(5,5) },
            new() { Coord = new(5,6) },
            new() { Coord = new(5,7) },
            new() { Coord = new(5,8) },

            new() { Coord = new(6,0) },
            new() { Coord = new(6,1) },
            new() { Coord = new(6,2) },
            new() { Coord = new(6,3) },
            new() { Coord = new(6,4) },
            new() { Coord = new(6,5) },
            new() { Coord = new(6,6) },
            new() { Coord = new(6,7) },
            new() { Coord = new(6,8) },

            new() { Coord = new(7,0) },
            new() { Coord = new(7,1) },
            new() { Coord = new(7,2) },
            new() { Coord = new(7,3) },
            new() { Coord = new(7,4) },
            new() { Coord = new(7,5) },
            new() { Coord = new(7,6) },
            new() { Coord = new(7,7) },
            new() { Coord = new(7,8) },

            new() { Coord = new(8,0) },
            new() { Coord = new(8,1) },
            new() { Coord = new(8,2) },
            new() { Coord = new(8,3) },
            new() { Coord = new(8,4) },
            new() { Coord = new(8,5) },
            new() { Coord = new(8,6) },
            new() { Coord = new(8,7) },
            new() { Coord = new(8,8) },
        };

		Groups = new List<SudokuGroup>
		{
			GroupTemplate.NineSquareBox1,
			GroupTemplate.NineSquareBox2,
		};
    }

    public void ReadTable(string tableConfig)
    {

    }

    public void Analyse()
    {
        foreach (SudokuTile tile in SudokuTiles)
        {
            //if the tile isn't be appied, remove the possbleNum by the group;
            if (!tile.IsAppied)
            {
                foreach (SudokuGroup group in Groups)
                {
                    List<int> appiedNum = new();
                    bool isFind = false;

                    foreach (SudokuTile tileInGroup in group.SudokuTiles)
                    {
                        if (tile.Coord == tileInGroup.Coord)
                        {
							GD.Print("[Info]: " + "find " + tile.Coord + " in group");
                            isFind = true;
							break;
                        }
                    }

                    if (isFind)
                    {
                        appiedNum = group.GetAppiedNum();
						GD.Print("[Info]: " + "appiedNum in group" + JsonSerializer.Serialize(appiedNum));

                        foreach (int i in appiedNum)
                        {
                            tile.PossibleNum.Remove(i);
                        }
                    }
                }
            }

        }
    }

	public void ApplyTileByCoord(Vector2I Coord, int Num)
	{
		foreach(SudokuTile tile in SudokuTiles)
		{
			if(tile.Coord == Coord)
			{
				tile.Apply(Num);
				break;
			}
		}
	}

    public void Print()
    {
        foreach (SudokuTile tile in SudokuTiles)
        {
            GD.Print("[TileCoord]: " + tile.Coord + "  [TilePossibleNum]: " + JsonSerializer.Serialize(tile.PossibleNum) + "  [IsAppied]: " + tile.IsAppied);
        }
    }
}
