using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrigerController : MonoBehaviour
{
    [SerializeField] private GameObject[] platforms;
    //[SerializeField] private GameObject platform2;


    private void Start()
    {
        ActiveAndNoPlatform(false);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ActiveAndNoPlatform(true);
        }
    }

    private void ActiveAndNoPlatform(bool active)
    {
        foreach (var item in platforms)
        {
            item.SetActive(active);
        }
    }


}
