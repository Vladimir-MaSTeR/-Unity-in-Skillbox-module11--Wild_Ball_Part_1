using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishPanelController : MonoBehaviour
{

    [SerializeField] GameObject finishPlatform;
    [SerializeField] Canvas  canvasFinish;

    // Start is called before the first frame update
    void Start()
    {
        finishPlatform.SetActive(false);
        canvasFinish.gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {

        finishPlatform.SetActive(true);
        canvasFinish.gameObject.SetActive(true);
    }


}
