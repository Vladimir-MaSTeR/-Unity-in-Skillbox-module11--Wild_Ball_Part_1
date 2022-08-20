using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinController : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip clip;

    [SerializeField] private GameObject destroyObject;

    [SerializeField] private TextCoinController textCoinController;


    // Start is called before the first frame update
    void Start()
    {
        destroyObject.SetActive(true);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            audioSource.PlayOneShot(clip);
            destroyObject.SetActive(false);
            textCoinController.PlusOneToCoinCount();
        }
    }


}
