using UnityEngine;
using UnityEngine.SceneManagement; // Needed for scene reloading

public class PlayerCollision : MonoBehaviour
{
    // This will be triggered when the player collides with a hole
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Deadly")) 
        {
            HandlePlayerDeath();
        }
    }

    // Restart the level when the player falls into a hole
    private void HandlePlayerDeath()
    {
        Debug.Log("Player fell into a hole! Restarting level...");
        RestartLevel();
    }

    // Method to reload the current scene (restart the level)
    private void RestartLevel()
    {
        // Get the active scene (current level) and reload it
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.name);
    }
}
