using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleDetection : MonoBehaviour
{
    RaycastHit raycastPuzzle;
    public LayerMask targetLayer;
    public float raycastRange = 4;

    bool isPressed = false;
    bool isFoundPuzzle = false;

    GameObject raycastTarget;
    
    void Update()
    {
        if(Physics.Raycast(transform.position, Camera.main.transform.forward, out raycastPuzzle, raycastRange, targetLayer))
        {
            raycastTarget = raycastPuzzle.transform.gameObject;

            if (raycastTarget.name == "PuzzlePiece" || raycastTarget.name == "PuzzlePiece(Clone)")
            {
                if(!isFoundPuzzle)
                {
                    isFoundPuzzle = true;
                    print("There's a puzzle");
                }
            }

            //Highlight the Puzzle
            if (raycastTarget.GetComponent<Outline>() != null) // If it has the Component
                if(raycastTarget.GetComponent<Outline>().enabled == false) // If the Component is disabled
                    raycastTarget.GetComponent<Outline>().enabled = true; //Enable the Component

        }

        else
        {
            if (isFoundPuzzle)
                isFoundPuzzle = false;
            //Stop Highlight the Puzzle
            if (raycastTarget != null) // if there "is" a raycastTarget
                if (raycastTarget.GetComponent<Outline>() != null) // If it has the Component
                    if (raycastTarget.GetComponent<Outline>().enabled == true) // If the Component is enabled
                        raycastTarget.GetComponent<Outline>().enabled = false; //Disable the Component
        }
    }

    public void ButtonPress()
    {
        //Checking whether a button is pressed or not
        if(!isPressed)
        {
            isPressed = true;

            if(isFoundPuzzle)
            {
                print("Ask the puzzle for a problem");
                //Notif the object that it is being selected
                if (raycastTarget != null)
                    if (raycastTarget.name == "PuzzlePiece" || raycastTarget.name == "PuzzlePiece(Clone)")
                        raycastTarget.SendMessage("GiveProblem");
            }

            isPressed = false;
        }
    }
}
