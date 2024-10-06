using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision2D : MonoBehaviour
{
    // This method is called when the player enters a trigger collider
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the GameObject has the portal tag
        if (other.CompareTag("portal"))
        {
            SceneManager.LoadScene(1);
        }
    }

}