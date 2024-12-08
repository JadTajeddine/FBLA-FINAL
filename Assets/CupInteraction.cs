using UnityEngine;

public class CupInteraction : MonoBehaviour
{
    public GameObject water; // Reference to the water GameObject
    private bool isFilled = false; // Track if the cup is filled
    private TrashCollector trashCollector; // Reference to the TrashCollector script

    void Start()
    {
        // Find the TrashCollector component in the scene
        trashCollector = FindObjectOfType<TrashCollector>();
    }

    void Update()
    {
        // Check for the "E" key press
        if (Input.GetKeyDown(KeyCode.E))
        {
            ToggleWater();
        }
    }

    void ToggleWater()
    {
        isFilled = !isFilled; // Toggle the filled state
        water.SetActive(isFilled); // Show or hide the water based on the state

        // If the cup is filled, increase the score in TrashCollector
        if (isFilled && trashCollector != null)
        {
            trashCollector.IncreaseScore(); // Call the method to increase the score
        }
    }
}