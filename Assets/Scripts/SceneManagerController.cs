using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerController : MonoBehaviour
{ 
    public void ClickStageOneButton()
    {
        SceneManager.LoadScene(1);
    }

    public void ClickStageTwoButton()
    {
        SceneManager.LoadScene(2);
    }
}
