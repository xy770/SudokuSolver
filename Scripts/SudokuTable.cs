using Godot;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

[Icon("res://Assets/Icon/SudokuTable.png")]
[GlobalClass]
public partial class SudokuTable : Node2D
{
    [Export]
    public GridContainer GridContainer;

    public List<SudokuGroup> Groups { get; set; }
    public List<SudokuTile> SudokuTiles { get; set; }

    PackedScene SudokuTilePanel = GD.Load<PackedScene>("res://Scene/SudokuTilePanel.tscn");
    PackedScene SudokuTileComponent = GD.Load<PackedScene>("res://Scene/SudokuTileComponent.tscn");

    public override void _Ready()
    {
        // init data
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
            GroupTemplate.NineSquareBox3,
            GroupTemplate.NineSquareBox4,
            GroupTemplate.NineSquareBox5,
            GroupTemplate.NineSquareBox6,
            GroupTemplate.NineSquareBox7,
            GroupTemplate.NineSquareBox8,
            GroupTemplate.NineSquareBox9,

            GroupTemplate.VerticalLine1,
            GroupTemplate.VerticalLine2,
            GroupTemplate.VerticalLine3,
            GroupTemplate.VerticalLine4,
            GroupTemplate.VerticalLine5,
            GroupTemplate.VerticalLine6,
            GroupTemplate.VerticalLine7,
            GroupTemplate.VerticalLine8,
            GroupTemplate.VerticalLine9,

            GroupTemplate.HorizontalLine1,
            GroupTemplate.HorizontalLine2,
            GroupTemplate.HorizontalLine3,
            GroupTemplate.HorizontalLine4,
            GroupTemplate.HorizontalLine5,
            GroupTemplate.HorizontalLine6,
            GroupTemplate.HorizontalLine7,
            GroupTemplate.HorizontalLine8,
            GroupTemplate.HorizontalLine9,
        };

        // init ui
        if (GridContainer != null)
        {
            int count = 0;
            foreach (SudokuTile tile in SudokuTiles)
            {
                count++;

                var panelInstance = SudokuTilePanel.Instantiate();
                var tileComponentInstance = SudokuTileComponent.Instantiate();

                panelInstance.Name = "Panel" + count.ToString();
                GridContainer.AddChild(panelInstance);
                panelInstance.AddChild(tile);

                tile.AddChild(tileComponentInstance);
                tile.NumLabel = tileComponentInstance.GetNode<Label>("Num");
                tile.Area2D = tileComponentInstance.GetNode<Area2D>("Area2D");
                tile.Area2D.MouseEntered += tile.MouseEnter;
                tile.Area2D.MouseExited += tile.MouseExit;
            }
        }
    }

    public void Analyse()
    {
        // part1 :remove possible num by simple detect
        foreach (SudokuTile tile in SudokuTiles)
        {
            //if the tile isn't be appied, remove the possibleNum by the group;
            if (!tile.IsAppied)
            {
                foreach (SudokuGroup group in Groups)
                {
                    List<int> appiedNum = new();
                    bool isFind = false;

                    foreach (Vector2I CoordInGroup in group.Coords)
                    {
                        if (tile.Coord == CoordInGroup)
                        {
                            isFind = true;
                            break;
                        }
                    }

                    if (isFind)
                    {
                        appiedNum = group.GetAppiedNum(this);

                        foreach (int i in appiedNum)
                        {
                            tile.PossibleNum.Remove(i);
                        }
                    }
                }
            }
        }

        // part2 :remove possible num by the mutual exclusivity of each group
        foreach (SudokuGroup group in Groups)
        {
            List<int> uniqueNums = group.GetUniqueValueInPossibleNum(this);

            foreach (Vector2I coord in group.Coords)
            {
                var tile = GetTileByCoord(coord);

                if (!tile.IsAppied)
                {
                    foreach (int uniqueNum in uniqueNums)
                    {
                        if (tile.PossibleNum.Contains(uniqueNum))
                        {
                            tile.PossibleNum = new() { uniqueNum };
                        }
                    }
                }
            }
        }
    }

    public void ApplyTileByPossibleNum()
    {
        foreach (SudokuTile tile in SudokuTiles)
        {
            if (!tile.IsAppied)
            {
                if (tile.PossibleNum.Count == 1)
                {
                    tile.Apply(tile.PossibleNum.Last());
                }
            }
        }
    }

    public void ApplyTileByCoord(Vector2I Coord, int Num)
    {
        foreach (SudokuTile tile in SudokuTiles)
        {
            if (tile.Coord == Coord)
            {
                tile.Apply(Num);
                break;
            }
        }
    }

    public SudokuTile GetTileByCoord(Vector2I coord)
    {
        foreach (SudokuTile tile in SudokuTiles)
        {
            if (tile.Coord == coord)
            {
                return tile;
            }
        }

        GD.PushError("Fail to get tile, return null");
        return null;
    }

    public int GetUnAppliedCount()
    {
        int count = 0;

        foreach (SudokuTile tile in SudokuTiles)
        {
            if (!tile.IsAppied)
            {
                count++;
            }
        }

        return count;
    }

    public void Print()
    {
        foreach (SudokuTile tile in SudokuTiles)
        {
            GD.Print("[TileCoord]: " + tile.Coord + "  [TilePossibleNum]: " + JsonSerializer.Serialize(tile.PossibleNum) + "  [IsAppied]: " + tile.IsAppied + "  [Num]: " + tile.Num);
        }
    }

    public void GuessTile(Vector2I Coord)
    {
        SudokuTile tile = GetTileByCoord(Coord);

        tile?.Apply(tile.PossibleNum.Last());
    }

    public Vector2I GetFirstUnApplyTileCoord()
    {
        foreach (SudokuTile tile in SudokuTiles)
        {
            if (!tile.IsAppied)
            {
                return tile.Coord;
            }
        }

        return new Vector2I(-1, -1);
    }
}
