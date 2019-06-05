using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuSceneController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void startAR()
    {
        SceneManager.LoadScene("6893PuzzlePieces");
    }

    public void quitGame()
    {
        Application.Quit();
    }
}
