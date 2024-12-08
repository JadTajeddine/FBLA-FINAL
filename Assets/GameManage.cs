using UnityEngine;
using UnityEngine.UI; // This allows us to use UI elements
using System.Collections;

public class GameManager : MonoBehaviour
{
    public Text timerText; // This will show the timer
    public GameObject winPanel; // This will show the win screen
    public GameObject losePanel; // This will show the lose screen
    public int playerPoints = 0; // This is the player's points
    private float timeRemaining = 300f; // This is 5 minutes in seconds

    void Start()
    {
        winPanel.SetActive(false); // Hide the win panel at the start
        losePanel.SetActive(false); // Hide the lose panel at the start
        StartCoroutine(Timer()); // Start the timer
    }

    IEnumerator Timer()
    {
        while (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime; // Decrease the time remaining
            UpdateTimerText(); // Update the timer text
            yield return null; // Wait for the next frame
        }

        // Time is up, check points
        CheckGameOver();
    }

    void UpdateTimerText()
    {
        // Convert time remaining to minutes and seconds
        float minutes = Mathf.FloorToInt(timeRemaining / 60);
        float seconds = Mathf.FloorToInt(timeRemaining % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds); // Update the timer text
    }

    public void AddPoints(int points)
    {
        playerPoints += points; // Add points to the player
        if (playerPoints >= 5)
        {
            CheckGameOver(); // Check if the player has won
        }
    }

    void CheckGameOver()
    {
        if (playerPoints >= 5)
        {
            WinGame(); // Player wins
        }
        else
        {
            LoseGame(); // Player loses
        }
    }

    void WinGame()
    {
        winPanel.SetActive(true); // Show the Win Panel
        Time.timeScale = 0; // Stop the game
    }

    void LoseGame()
    {
        losePanel.SetActive(true); // Show the Lose Panel
        Time.timeScale = 0; // Stop the game
    }
}