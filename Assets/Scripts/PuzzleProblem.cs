using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PuzzleProblem : MonoBehaviour
{
    public bool isSelectingPuzzle = true; //Condition when player is currently selecting problem
    public bool isAnswering = false; //Condition when player is currently trying to answer

    //List of puzzle pieces
    //Drag Canvas "PuzzlePieces", child of this to this
    public GameObject puzzleSelect;

    //List of UIs for answering
    //Drag Canvas "PlayerUI", child of this to this
    public GameObject problemAnswer;

    //if the answer is wrong show the text
    public GameObject wrongMessage;
    public Text Message;

    //List of text UIs for displaying problems and answers
    //Drag UI Text "QText", child of "HeaderBG", child of "PlayerUI" to this
    public Text problemArea;
    //Drag UI Text "AText", child of "HeaderBG", child of "PlayerUI" to this
    public Text answerArea;

    public int firstNumber;
    public int secondNumber;
    public int thirdNumber;
    public int yourAnswer;
    public int completedpieces = 0;

    public string targetPuzzleName;

    

    public void SetProblem(string name)
    {
        //Setting the problem
        firstNumber = Random.Range(1, 4);
        secondNumber = Random.Range(5, 9) - firstNumber;
        thirdNumber = firstNumber + secondNumber;

        //Writing the problem
        problemArea.text = firstNumber + " + " + secondNumber;
        SM.instance.clicksound();

        //Enable answer mode
        if (!isAnswering) isAnswering = true;
        if (isAnswering && !problemAnswer.activeSelf) problemAnswer.SetActive(true);

        //Disable select mode
        if (isSelectingPuzzle) isSelectingPuzzle = true;

        //Setting the target puzzle
        if (name != null)
            if (targetPuzzleName != name)
                targetPuzzleName = name;
    }

    public void AnswerAttempt(int number)
    {
        //Set your answer to the attempt
        yourAnswer = number;
        //Set the text to your answer
        answerArea.text = yourAnswer.ToString();
    }

    public IEnumerator SubmitAnswer()
    {
        //If correct answer do something
        if(yourAnswer == thirdNumber)
        {
            //Find the puzzle piece and disable the button function of that
            //If error happens (like no receiver or null reference exception), check the Tag of the puzzle pieces
            if (GameObject.FindWithTag(targetPuzzleName) != null)
            {
                if (GameObject.FindWithTag(targetPuzzleName).GetComponent<Image>() != null)
                {
                    GameObject.FindWithTag(targetPuzzleName).GetComponent<Image>().color = new Color32(255, 255, 255, 255);
                    if (GameObject.FindWithTag(targetPuzzleName).GetComponent<Button>() != null)
                        if (GameObject.FindWithTag(targetPuzzleName).GetComponent<Button>().enabled)
                            GameObject.FindWithTag(targetPuzzleName).GetComponent<Button>().enabled = false;
                }
            }
            ResetQA();
            completedpieces++;
            SM.instance.rightanswer(); 

            if (completedpieces == 16)
            {
                print("completed");
                yield return new WaitForSeconds(2);
                SceneManager.LoadScene("FinishScene");
            }
        }
        else
        {
            print("wrong");
            SM.instance.wronganswer();
            wrongMessage.SetActive(true);
            yield return new WaitForSeconds(2);
            wrongMessage.SetActive(false);
            
        }
    }

    public void ResetQA()
    {
        firstNumber = 0;
        secondNumber = 0;
        thirdNumber = 0;
        problemArea.text = "";
        answerArea.text = "";
        targetPuzzleName = "";
        isSelectingPuzzle = true;
        isAnswering = false;
        problemAnswer.SetActive(false);
        
    }
}
