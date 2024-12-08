using UnityEngine;

public class ToggleVisibility : MonoBehaviour
{
    private Renderer objectRenderer;
    private bool isVisible = false;

    void Start()
    {
        // Get the Renderer component of the object
        objectRenderer = GetComponent<Renderer>();
        
        // Initially set the object to be invisible
        objectRenderer.enabled = false;
    }

    public void Toggle()
    {
        // Toggle visibility
        isVisible = !isVisible;
        objectRenderer.enabled = isVisible;
    }
}