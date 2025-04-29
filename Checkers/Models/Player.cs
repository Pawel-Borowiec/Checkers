using Checkers.Components.Elements;

namespace Checkers.Models;

public class Player
{
    public string Name { get; set; }
    public List<Pawn> Pawns { get; set; }
    public Pawn PickedPawn { get; set; }
    public Color Color { get; set; }

    public Player(Color color)
    {
        Color = color;
        Pawns = new List<Pawn>();

        if (Color == Color.WHITE)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = i % 2 == 0 ? 1 : 0 ; j < 10; j=j+2)
                {
                    Pawns.Add(new Pawn(i,j, color));
                }
            }
        }
        else
        {
            for (int i = 7; i < 10; i++)
            {
                for (int j = i % 2 == 0 ? 1 : 0 ; j < 10; j=j+2)
                {
                    Pawns.Add(new Pawn(i,j, color));
                }
            }
        }
    }
}