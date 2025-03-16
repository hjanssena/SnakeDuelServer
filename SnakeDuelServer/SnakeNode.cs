using System.Numerics;

public class SnakeNode
{
    Vector2 position;
    public float speed { get; set; }
    public Vector2 heading { get; set; }
    public SnakeNode previous { get; set; }
    public SnakeNode next { get; set; }
    public Snake owner { get; set; }
}