using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FonMusic : MonoBehaviour
{

    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip[] clip;


    // Start is called before the first frame update
    void Start()
    {
        SelectClipInStage();
    }


    private void SelectClipInStage()
    {
        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            audioSource.clip = clip[0];
        
        } else {
            audioSource.clip = clip[1];    
        }

        audioSource.Play();
        audioSource.loop = true;
    }

    






}
