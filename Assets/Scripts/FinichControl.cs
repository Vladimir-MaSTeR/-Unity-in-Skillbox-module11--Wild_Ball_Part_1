using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinichControl : MonoBehaviour
{
    [SerializeField] private GameObject finishPanel;
    [SerializeField] private Canvas finishCanfas;


    // Start is called before the first frame update
    void Start()
    {
        finishPanel.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        Time.timeScale = 0;
        finishCanfas.gameObject.SetActive(false);
        finishPanel.SetActive(true);
    }
}
