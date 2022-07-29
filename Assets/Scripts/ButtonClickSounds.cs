using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClickSounds : MonoBehaviour
{

    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip clip;

    public void Click()
    {
        audioSource.PlayOneShot(clip);
    }
}
