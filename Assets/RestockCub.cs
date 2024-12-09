using UnityEngine;
using UnityEngine.UI;

public class RestockCube : MonoBehaviour
{
    public Text scoreText; // Reference to the UI Text
    private int score = 1; // Player's score
    private bool isClicked = false; // To check if the cube has been clicked

    void Update()
    {
        // Check for input
        if (Input.GetKeyDown(KeyCode.E) && !isClicked)
        {
            GivePoint(); // Call the method to give a point
        }
    }

    void GivePoint()
    {
        score++; // Increase the score by 1
        scoreText.text = "Score: " + score; // Update the score text
        isClicked = true; // Set isClicked to true to prevent further clicks
        gameObject.SetActive(false); // Make the cube invisible
    }
}