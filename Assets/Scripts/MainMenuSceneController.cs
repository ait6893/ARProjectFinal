using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuSceneController : MonoBehaviour
{

    public static MainMenuSceneController instance;
    void Awake() { instance = this; }
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
        SceneManager.LoadScene("ARScene");
    }
    public void startInstruction()
    {
        SceneManager.LoadScene("InstructionScene");
    }

    public void quitGame()
    {
        Application.Quit();
    }

    public void MainMenuScene()
    {
        SceneManager.LoadScene("MenuScene");

    }

    public IEnumerator puzzleComplete()
    {
        print("finish");
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("FinishScene");
    }
}
