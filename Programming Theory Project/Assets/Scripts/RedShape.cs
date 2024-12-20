using UnityEngine;

public class RedShape : Shape
{
    private void Start()
    {
        // Set properties for this shape
        ShapeName = "Red Shape";
        ShapeColor = Color.red;
    }

    // Override DisplayText for specific behavior
    public override void DisplayText()
    {
        Debug.Log($"This is a {ShapeName}!");
    }
}
