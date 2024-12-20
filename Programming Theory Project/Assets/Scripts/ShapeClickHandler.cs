using UnityEngine;

public class ShapeClickHandler : MonoBehaviour
{
    private void OnMouseDown()
    {
        // Get the Shape component and call its DisplayText method
        Shape shape = GetComponent<Shape>();
        if (shape != null)
        {
            shape.DisplayText();
        }
    }
}
