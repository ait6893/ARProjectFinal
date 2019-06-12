using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleSelect : MonoBehaviour
{
    //The main AR Camera need to have tag "MainCamera" and script "PuzzleProblem.cs" for the following functions to work

    public void answer1()
    {
        //Check whether the target has the script
        //Check whether it's the right condition to do this
        //Check whether it's necessary or not to send message
        if (GameObject.FindWithTag("MainCamera").GetComponent<PuzzleProblem>() != null)
            if (GameObject.FindWithTag("MainCamera").GetComponent<PuzzleProblem>().isAnswering)
                if (GameObject.FindWithTag("MainCamera").GetComponent<PuzzleProblem>().yourAnswer != 1)
                    GameObject.FindWithTag("MainCamera").GetComponent<PuzzleProblem>().SendMessage("AnswerAttempt",1);
    }

    public void answer2()
    {
        if (GameObject.FindWithTag("MainCamera").GetComponent<PuzzleProblem>() != null)
            if (GameObject.FindWithTag("MainCamera").GetComponent<PuzzleProblem>().isAnswering)
                if (GameObject.FindWithTag("MainCamera").GetComponent<PuzzleProblem>().yourAnswer != 2)
                    GameObject.FindWithTag("MainCamera").GetComponent<PuzzleProblem>().SendMessage("AnswerAttempt", 2);
    }

    public void answer3()
    {
        if (GameObject.FindWithTag("MainCamera").GetComponent<PuzzleProblem>() != null)
            if (GameObject.FindWithTag("MainCamera").GetComponent<PuzzleProblem>().isAnswering)
                if (GameObject.FindWithTag("MainCamera").GetComponent<PuzzleProblem>().yourAnswer != 3)
                    GameObject.FindWithTag("MainCamera").GetComponent<PuzzleProblem>().SendMessage("AnswerAttempt", 3);
    }

    public void answer4()
    {
        if (GameObject.FindWithTag("MainCamera").GetComponent<PuzzleProblem>() != null)
            if (GameObject.FindWithTag("MainCamera").GetComponent<PuzzleProblem>().isAnswering)
                if (GameObject.FindWithTag("MainCamera").GetComponent<PuzzleProblem>().yourAnswer != 4)
                    GameObject.FindWithTag("MainCamera").GetComponent<PuzzleProblem>().SendMessage("AnswerAttempt", 4);
    }

    public void answer5()
    {
        if (GameObject.FindWithTag("MainCamera").GetComponent<PuzzleProblem>() != null)
            if (GameObject.FindWithTag("MainCamera").GetComponent<PuzzleProblem>().isAnswering)
                if (GameObject.FindWithTag("MainCamera").GetComponent<PuzzleProblem>().yourAnswer != 5)
                    GameObject.FindWithTag("MainCamera").GetComponent<PuzzleProblem>().SendMessage("AnswerAttempt", 5);
    }

    public void answer6()
    {
        if (GameObject.FindWithTag("MainCamera").GetComponent<PuzzleProblem>() != null)
            if (GameObject.FindWithTag("MainCamera").GetComponent<PuzzleProblem>().isAnswering)
                if (GameObject.FindWithTag("MainCamera").GetComponent<PuzzleProblem>().yourAnswer != 6)
                    GameObject.FindWithTag("MainCamera").GetComponent<PuzzleProblem>().SendMessage("AnswerAttempt", 6);
    }

    public void answer7()
    {
        if (GameObject.FindWithTag("MainCamera").GetComponent<PuzzleProblem>() != null)
            if (GameObject.FindWithTag("MainCamera").GetComponent<PuzzleProblem>().isAnswering)
                if (GameObject.FindWithTag("MainCamera").GetComponent<PuzzleProblem>().yourAnswer != 7)
                    GameObject.FindWithTag("MainCamera").GetComponent<PuzzleProblem>().SendMessage("AnswerAttempt", 7);
    }

    public void answer8()
    {
        if (GameObject.FindWithTag("MainCamera").GetComponent<PuzzleProblem>() != null)
            if (GameObject.FindWithTag("MainCamera").GetComponent<PuzzleProblem>().isAnswering)
                if (GameObject.FindWithTag("MainCamera").GetComponent<PuzzleProblem>().yourAnswer != 8)
                    GameObject.FindWithTag("MainCamera").GetComponent<PuzzleProblem>().SendMessage("AnswerAttempt", 8);
    }

    public void answer9()
    {
        if (GameObject.FindWithTag("MainCamera").GetComponent<PuzzleProblem>() != null)
            if (GameObject.FindWithTag("MainCamera").GetComponent<PuzzleProblem>().isAnswering)
                if (GameObject.FindWithTag("MainCamera").GetComponent<PuzzleProblem>().yourAnswer != 9)
                    GameObject.FindWithTag("MainCamera").GetComponent<PuzzleProblem>().SendMessage("AnswerAttempt", 9);
    }

    public void submitAnswer()
    {
        if (GameObject.FindWithTag("MainCamera").GetComponent<PuzzleProblem>() != null)
            if (GameObject.FindWithTag("MainCamera").GetComponent<PuzzleProblem>().isAnswering)
                if (GameObject.FindWithTag("MainCamera").GetComponent<PuzzleProblem>().yourAnswer != 0)
                    GameObject.FindWithTag("MainCamera").GetComponent<PuzzleProblem>().SendMessage("SubmitAnswer");
    }

    //For the following functions to work
    //You need 16 different Tags, 1 for each Puzzle, child of PuzzlePieces
    //The Tag will be "Puzzle1", "Puzzle2", "Puzzle3", ... etc

    public void askForProblem1()
    {
        //Check whether the target has the script
        //Check whether it's the right condition to do this
        if (GameObject.FindWithTag("MainCamera").GetComponent<PuzzleProblem>() != null)
            if (GameObject.FindWithTag("MainCamera").GetComponent<PuzzleProblem>().isSelectingPuzzle)
                GameObject.FindWithTag("MainCamera").GetComponent<PuzzleProblem>().SendMessage("SetProblem", "Puzzle1");
    }

    public void askForProblem2()
    {
        if (GameObject.FindWithTag("MainCamera").GetComponent<PuzzleProblem>() != null)
            if (GameObject.FindWithTag("MainCamera").GetComponent<PuzzleProblem>().isSelectingPuzzle)
                GameObject.FindWithTag("MainCamera").GetComponent<PuzzleProblem>().SendMessage("SetProblem", "Puzzle2");
    }

    public void askForProblem3()
    {
        if (GameObject.FindWithTag("MainCamera").GetComponent<PuzzleProblem>() != null)
            if (GameObject.FindWithTag("MainCamera").GetComponent<PuzzleProblem>().isSelectingPuzzle)
                GameObject.FindWithTag("MainCamera").GetComponent<PuzzleProblem>().SendMessage("SetProblem", "Puzzle3");
    }

    public void askForProblem4()
    {
        if (GameObject.FindWithTag("MainCamera").GetComponent<PuzzleProblem>() != null)
            if (GameObject.FindWithTag("MainCamera").GetComponent<PuzzleProblem>().isSelectingPuzzle)
                GameObject.FindWithTag("MainCamera").GetComponent<PuzzleProblem>().SendMessage("SetProblem", "Puzzle4");
    }

    public void askForProblem5()
    {
        if (GameObject.FindWithTag("MainCamera").GetComponent<PuzzleProblem>() != null)
            if (GameObject.FindWithTag("MainCamera").GetComponent<PuzzleProblem>().isSelectingPuzzle)
                GameObject.FindWithTag("MainCamera").GetComponent<PuzzleProblem>().SendMessage("SetProblem", "Puzzle5");
    }

    public void askForProblem6()
    {
        if (GameObject.FindWithTag("MainCamera").GetComponent<PuzzleProblem>() != null)
            if (GameObject.FindWithTag("MainCamera").GetComponent<PuzzleProblem>().isSelectingPuzzle)
                GameObject.FindWithTag("MainCamera").GetComponent<PuzzleProblem>().SendMessage("SetProblem", "Puzzle6");
    }

    public void askForProblem7()
    {
        if (GameObject.FindWithTag("MainCamera").GetComponent<PuzzleProblem>() != null)
            if (GameObject.FindWithTag("MainCamera").GetComponent<PuzzleProblem>().isSelectingPuzzle)
                GameObject.FindWithTag("MainCamera").GetComponent<PuzzleProblem>().SendMessage("SetProblem", "Puzzle7");
    }

    public void askForProblem8()
    {
        if (GameObject.FindWithTag("MainCamera").GetComponent<PuzzleProblem>() != null)
            if (GameObject.FindWithTag("MainCamera").GetComponent<PuzzleProblem>().isSelectingPuzzle)
                GameObject.FindWithTag("MainCamera").GetComponent<PuzzleProblem>().SendMessage("SetProblem", "Puzzle8");
    }

    public void askForProblem9()
    {
        if (GameObject.FindWithTag("MainCamera").GetComponent<PuzzleProblem>() != null)
            if (GameObject.FindWithTag("MainCamera").GetComponent<PuzzleProblem>().isSelectingPuzzle)
                GameObject.FindWithTag("MainCamera").GetComponent<PuzzleProblem>().SendMessage("SetProblem", "Puzzle9");
    }

    public void askForProblem10()
    {
        if (GameObject.FindWithTag("MainCamera").GetComponent<PuzzleProblem>() != null)
            if (GameObject.FindWithTag("MainCamera").GetComponent<PuzzleProblem>().isSelectingPuzzle)
                GameObject.FindWithTag("MainCamera").GetComponent<PuzzleProblem>().SendMessage("SetProblem", "Puzzle10");
    }

    public void askForProblem11()
    {
        if (GameObject.FindWithTag("MainCamera").GetComponent<PuzzleProblem>() != null)
            if (GameObject.FindWithTag("MainCamera").GetComponent<PuzzleProblem>().isSelectingPuzzle)
                GameObject.FindWithTag("MainCamera").GetComponent<PuzzleProblem>().SendMessage("SetProblem", "Puzzle11");
    }

    public void askForProblem12()
    {
        if (GameObject.FindWithTag("MainCamera").GetComponent<PuzzleProblem>() != null)
            if (GameObject.FindWithTag("MainCamera").GetComponent<PuzzleProblem>().isSelectingPuzzle)
                GameObject.FindWithTag("MainCamera").GetComponent<PuzzleProblem>().SendMessage("SetProblem", "Puzzle12");
    }

    public void askForProblem13()
    {
        if (GameObject.FindWithTag("MainCamera").GetComponent<PuzzleProblem>() != null)
            if (GameObject.FindWithTag("MainCamera").GetComponent<PuzzleProblem>().isSelectingPuzzle)
                GameObject.FindWithTag("MainCamera").GetComponent<PuzzleProblem>().SendMessage("SetProblem", "Puzzle13");
    }

    public void askForProblem14()
    {
        if (GameObject.FindWithTag("MainCamera").GetComponent<PuzzleProblem>() != null)
            if (GameObject.FindWithTag("MainCamera").GetComponent<PuzzleProblem>().isSelectingPuzzle)
                GameObject.FindWithTag("MainCamera").GetComponent<PuzzleProblem>().SendMessage("SetProblem", "Puzzle14");
    }

    public void askForProblem15()
    {
        if (GameObject.FindWithTag("MainCamera").GetComponent<PuzzleProblem>() != null)
            if (GameObject.FindWithTag("MainCamera").GetComponent<PuzzleProblem>().isSelectingPuzzle)
                GameObject.FindWithTag("MainCamera").GetComponent<PuzzleProblem>().SendMessage("SetProblem", "Puzzle15");
    }

    public void askForProblem16()
    {
        if (GameObject.FindWithTag("MainCamera").GetComponent<PuzzleProblem>() != null)
            if (GameObject.FindWithTag("MainCamera").GetComponent<PuzzleProblem>().isSelectingPuzzle)
                GameObject.FindWithTag("MainCamera").GetComponent<PuzzleProblem>().SendMessage("SetProblem", "Puzzle16");
    }
}
