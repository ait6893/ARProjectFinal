using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleDetection : MonoBehaviour
{
    RaycastHit raycastPuzzle;
    public LayerMask targetLayer;
    public float raycastRange = 4;

    GameObject raycastTarget;
    
    void Update()
    {
        if(Physics.Raycast(transform.position, Camera.main.transform.forward, out raycastPuzzle, raycastRange, targetLayer))
        {
            raycastTarget = raycastPuzzle.transform.gameObject;

            //Highlight the Puzzle
            if (raycastTarget.GetComponent<Outline>() != null) // If it has the Component
                if(raycastTarget.GetComponent<Outline>().enabled == false) // If the Component is disabled
                    raycastTarget.GetComponent<Outline>().enabled = true; //Enable the Component
        }

        else
        {
            //Stop Highlight the Puzzle
            if (raycastTarget != null) // if there "is" a raycastTarget
                if (raycastTarget.GetComponent<Outline>() != null) // If it has the Component
                    if (raycastTarget.GetComponent<Outline>().enabled == true) // If the Component is enabled
                        raycastTarget.GetComponent<Outline>().enabled = false; //Disable the Component
        }
    }
}
