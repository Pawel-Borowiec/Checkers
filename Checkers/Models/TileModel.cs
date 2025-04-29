namespace Checkers.Models;

public class TileModel
{
    public int X { get; set; }
    public int Y { get; set; }
    public Pawn Pawn { get; set; }

    public TileModel(int x, int y)
    {
        X = x;
        Y = y;
    }
}