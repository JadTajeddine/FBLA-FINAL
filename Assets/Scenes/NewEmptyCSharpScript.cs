using UnityEngine;

public class ChecklistToggle : MonoBehaviour
{
    public GameObject checklistPanel; // Reference to the checklist panel

    void Update()
    {
        // Check if the "F" key is pressed
        if (Input.GetKeyDown(KeyCode.F))
        {
            // Toggle the active state of the checklist panel
            checklistPanel.SetActive(!checklistPanel.activeSelf);
        }
    }
}