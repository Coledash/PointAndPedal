using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{
    public static GameManagerScript instance;

    public float highScore = 0;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        // ESC to quit game
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

        // R to restart
        if (Input.GetKeyUp(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        // P to clear high score
        if(Input.GetKeyDown(KeyCode.P))
        {
            highScore = 0;
        }
    }

}
