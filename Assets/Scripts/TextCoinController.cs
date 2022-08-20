using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextCoinController : MonoBehaviour
{
    [SerializeField] private Text textCoinCount;

    private float coinCount;

    private void Start()
    {
        coinCount = 0f;
        textCoinCount.text = coinCount.ToString();
    }


    public void PlusOneToCoinCount()
    {
        coinCount += 1;
        UpdateTextCoinCount();
    }

    private void UpdateTextCoinCount()
    {
        textCoinCount.text = coinCount.ToString();
    }
}
