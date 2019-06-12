using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SM : MonoBehaviour
{
    public AudioSource sfxsrc;

    public AudioClip[] sound;

    public static SM instance;

    void Awake()
    {
        instance = this;
    }

    public void clicksound()
    {
        sfxsrc.PlayOneShot(sound[0]);
    }


    public void wronganswer()
    {
        sfxsrc.PlayOneShot(sound[2]);
    }



    public void rightanswer()
    {
        sfxsrc.PlayOneShot(sound[1]);
    }
}
