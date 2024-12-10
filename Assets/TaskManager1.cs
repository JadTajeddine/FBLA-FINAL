using UnityEngine;

using UnityEngine.UI;


public class ActivateApples : MonoBehaviour
{
    public GameObject apples;
    public GameObject Coffee1;
    public GameObject Coffee2;
    public GameObject AshTray;
    public GameObject Plates;
    public int Score;
    private bool isActivated = false;
    public GameObject youWin;
    public GameObject youlose;

    void Start()
    {
        // Find the GameObject named "apples"
       

    }

    void Update()
    {
        // Check if the "E" key is pressed and the apples GameObject is not activated yet
        if (Input.GetKeyDown(KeyCode.E))
        {
            ActivateApplesObject();
            if (Score == 4)
            {
            
            }

        }
    }

    private void ActivateApplesObject()
    {
        // Set the apples GameObject to active
        Coffee1.SetActive(true);
        Coffee2.SetActive(true);
        AshTray.SetActive(true);
        Plates.SetActive(true);
        apples.SetActive(true);
        Score = Score + 4;
        isActivated = true; // Prevent further activation
        Debug.Log("Apples activated!");
    }
}
