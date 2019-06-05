using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleProblem : MonoBehaviour
{
    float firstNumber;
    float secondNumber;
    float thirdNumber = 0;
    float symbol;

    void Awake()
    {
    }

    void Start()
    {
    }

    public void GiveProblem()
    {
        thirdNumberSetter();
    }

    void thirdNumberSetter()
    {
        while(thirdNumber <= 0)
        {
            firstNumber = Mathf.Round(Random.Range(1, 9));
            secondNumber = Mathf.Round(Random.Range(1, 9));
            symbol = Mathf.Round(Random.Range(1, 4));

            if (symbol == 1) // +, addition
                thirdNumber = firstNumber + secondNumber;

            else if (symbol == 2 && firstNumber > secondNumber) // -, subtraction
                thirdNumber = firstNumber - secondNumber;

            else if (symbol == 3) // x, multiply
                thirdNumber = firstNumber * secondNumber;

            else if (symbol == 4 && firstNumber % secondNumber == 0) // /, divide
                thirdNumber = firstNumber / secondNumber;

            else
            { }
        }
        showProblem();
    }

    void showProblem()
    {
        if (symbol == 1)
            print(firstNumber + " + " + secondNumber + " =  ?");
        else if (symbol == 2)
            print(firstNumber + " - " + secondNumber + " =  ?");
        else if (symbol == 3)
            print(firstNumber + " x " + secondNumber + " =  ?");
        else if (symbol == 4)
            print(firstNumber + " ÷ " + secondNumber + " =  ?");
        else
        print("Solution is " + thirdNumber);

        //Send the problem text to UI Text
        //SetActive/ActiveSelf InputField of the Canvas + Enter Button
            //Disable problem button clicking
            //Disable raycast

        //Enter Button = SendMessage to problem block
        //Double check answer
        //If it's correct, send the problem block back
    }
}
