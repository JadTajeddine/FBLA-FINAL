using UnityEngine;
using UnityEngine.UI;

public class TrashCollector : MonoBehaviour
{
    private int score;
    public Text scoreText;
    public GameObject UI;
    private bool isPlayerNear;
    private bool hasRestocked; // New flag to track restock interaction

    void Start()
    {
        score = 0;
        hasRestocked = false; // Initialize the flag to false
        UpdateScoreText();
        UI.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) // Press E to interact
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit, 2f))
            {
                if (hit.collider.CompareTag("Trash"))
                {
                    hit.collider.gameObject.SetActive(false); // Remove trash
                    score++;
                    UpdateScoreText();
                }
                else if (hit.collider.CompareTag("Restock") && !hasRestocked) // Check if not already restocked
                {
                    ToggleVisibility toggleVisibility = hit.collider.GetComponent<ToggleVisibility>();
                    if (toggleVisibility != null)
                    {
                        toggleVisibility.Toggle(); // Call a method to toggle visibility
                        score++; // Increase score by 1 when interacting with Restock
                        UpdateScoreText(); // Update the score display
                        hasRestocked = true; // Set the flag to true to prevent further interactions
                        Debug.Log("Restocked! Score increased by 1.");
                    }
                }
            }
        }
    }

    void UpdateScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Make sure the player has the "Player" tag
        {
            isPlayerNear = true;
            UI.SetActive(true);
            Debug.Log("entered");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerNear = false;
            UI.SetActive(false);
            Debug.Log("exited");
        }
    }
}