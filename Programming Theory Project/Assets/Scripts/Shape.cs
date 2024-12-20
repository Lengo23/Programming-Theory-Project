using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    // Shared property: Name of the shape
    public string ShapeName { get; set; }

    // Shared property: Color of the shape
    public Color ShapeColor { get; set; }

    // Abstract method to display text (will be overridden by subclasses)
    public abstract void DisplayText();
}
