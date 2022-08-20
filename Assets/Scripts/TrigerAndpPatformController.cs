using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrigerAndpPatformController : MonoBehaviour
{
    [SerializeField] private GameObject[] platforms;

    [SerializeField] private GameObject[] platformsFalse;
    

    private Camera oldCamera;



    private void Start()
    {
        ActiveAndNoPlatform(platforms, false);
    }

    private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                ActiveAndNoPlatform(platforms, true);
                ActiveAndNoPlatform(platformsFalse, false);

            }

        }

     private void ActiveAndNoPlatform(GameObject[] plat, bool active)
        {
            foreach (var item in plat)
            {
                item.SetActive(active);

            }
        }
    
}