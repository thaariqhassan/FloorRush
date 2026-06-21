using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement playerMovement; // Reference to the PlayerMovement script

    void OnCollisionEnter(Collision collision) // function's name should be this itself(this is a fn made by unity)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            playerMovement.enabled = false;
            Debug.Log("Game Over!");
            
        }
    }
}

