namespace Checkers.Models;

public class Pawn
{
    public int X { get; set; }
    public int Y { get; set; }
    public Color Color { get; set; }
    public bool IsActive { get; set; } = false;
    public bool IsCrowned { get; set; }

    public Pawn(int x, int y)
    {
        X = x;
        Y = y;
    }

    public Pawn(int x, int y, Color color)
    {
        X = x;
        Y = y;
        Color = color;
    }
}