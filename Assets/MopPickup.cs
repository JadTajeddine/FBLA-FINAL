using UnityEngine;

public class MopPickup : MonoBehaviour
{
    public GameObject player;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            // Logic to show the mop being held
            // You can add a visual representation here
            Destroy(gameObject); // Remove the mop from the scene
        }
    }
}