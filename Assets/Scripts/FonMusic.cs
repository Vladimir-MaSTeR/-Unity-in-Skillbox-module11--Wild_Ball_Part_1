using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FonMusic : MonoBehaviour
{

    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip clip;

    // Start is called before the first frame update
    void Start()
    {
        audioSource.clip = clip;
        audioSource.Play();
        audioSource.playOnAwake = true;
        audioSource.loop = true;
    }



}
