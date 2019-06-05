using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.Playables;

public class onimagetrigger : MonoBehaviour, Vuforia.ITrackableEventHandler
{
    private TrackableBehaviour mTrackableBehaviour;
    public static int st = 0;

    public GameObject puzzle;
    

    void Start()
    {
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (mTrackableBehaviour)
        {
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
        }
    }

    public void OnTrackableStateChanged(TrackableBehaviour.Status newStatus)
    {
        OnTrackableStateChanged(default(TrackableBehaviour.Status), newStatus);
    }

    public void OnTrackableStateChanged(
        TrackableBehaviour.Status previousStatus,
        TrackableBehaviour.Status newStatus)
    {
        if (newStatus == null)
            throw new System.ArgumentNullException("newStatus");
        if (newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED ||
            newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
            //TRACKINNG FOUND
            puzzle.SetActive(true);

        }
        else if (newStatus == TrackableBehaviour.Status.NO_POSE)
        {
            //TRACKING LOST
            puzzle.SetActive(false);
        }
    }
    static void print()
    {
        Debug.Log("st :" + st);
        print("st :" + st);
    }
}

