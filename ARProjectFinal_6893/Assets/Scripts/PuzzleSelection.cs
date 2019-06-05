using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleSelection : MonoBehaviour
{
    void Start()
    {
        
    }
    
    void Update()
    {
    }

    public void SelectPuzzle()
    {
        //Send notification to Player, that a button is actually pressed
        print("This button is selected");
        GameObject.FindWithTag("Player").SendMessage("ButtonPress");
    }
}
