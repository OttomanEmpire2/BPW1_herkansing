using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playsong : Target
{
    public AudioSource backgroundAudio;
    public AudioClip newBackgroundSong;

    public override void TakeDamage(float amount)
    {
        base.TakeDamage(amount);
        ChangeBackgroundSound();
    }

    public void ChangeBackgroundSound()
    {
        backgroundAudio.clip = newBackgroundSong;
        backgroundAudio.Play();
    }

}