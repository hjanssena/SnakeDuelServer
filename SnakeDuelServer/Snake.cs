using System.Numerics;


public class Snake
{
    public enum Direction { up, down, left, right };
    public Vector2 position { get; set; }
    public Direction currentDir { get; set; }
    SnakeNode head;
    bool dead;

}

