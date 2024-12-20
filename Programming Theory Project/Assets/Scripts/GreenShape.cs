using UnityEngine;

public class GreenShape : Shape
{
    private void Start()
    {
        // Set properties for this shape
        ShapeName = "Green Shape";
        ShapeColor = Color.green;
    }

    public override void DisplayText()
    {
        Debug.Log($"The {ShapeName} greets you!");
    }
}
