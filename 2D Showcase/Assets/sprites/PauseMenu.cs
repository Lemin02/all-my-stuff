using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    bool _gamepaused = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //pause the game on start
        //Time.timeScale = 0;
        GetComponent<Canvas>().enabled = false;
        Time.timeScale = 1.0f;
    }
    void Update()
    {
        //check to see if the escape key was pressed this frame on the keyboard
        if (Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            if (_gamepaused)
            {
                Resume();
            }
            else
            {
                Debug.Log("Pause the game!");
                PauseGame();
            }
        }

    }

    public void Resume()
    {
        //this function, when clicked, will resume the game
        Time.timeScale = 1.0f;
        GetComponent<Canvas>().enabled = false;
        _gamepaused = false;
    }
    public void PauseGame()
    {
        //this function, when called, should pause the game
        Time.timeScale = 0;
        GetComponent<Canvas>().enabled = true;
        _gamepaused = true;
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void LoadMainMenu()
    {
        //how do I load the main menu?
        //first: ensure main menu exists as a level (scene)
        //second: actually load the level
        SceneManager.LoadScene("MainMenu");
    }
    //CHALLENGE:
    //Create buttons for your main menu. Make a button to load level 1

    //Also, make a win scene. Make some sort of trigger to enter the win scene. 
    //On the win scene, make buttons on a canvas to load main menu
    
}
