using UnityEngine;

public class BlueShape : Shape
{
    private void Start()
    {
        // Set properties for this shape
        ShapeName = "Blue Shape";
        ShapeColor = Color.blue;
    }

    public override void DisplayText()
    {
        Debug.Log($"Behold the majestic {ShapeName}!");
    }
}
