using UnityEngine;

public class GamePause : MonoBehaviour
{
    public GameObject pauseMenuUI;
    private bool isPaused = false;

    void Update()
    {
        // Check if the player presses the "Escape" key or any other key for pausing
        if (Input.GetKeyDown(KeyCode.P))
        {
            TogglePause();
        }
    }

    public void TogglePause()
    {
        if (isPaused)
        {
            ResumeGame();
        }
        else
        {
            PauseGame();
        }
    }

    void PauseGame()
    {
        Time.timeScale = 0f;  // Freeze the game
        isPaused = true;
        pauseMenuUI.SetActive(true);
        // Optional: Activate the pause UI
    }

    void ResumeGame()
    {
        Time.timeScale = 1f;  // Resume the game
        isPaused = false;
        pauseMenuUI.SetActive(false);
        // Optional: Deactivate the pause UI
    }
}

