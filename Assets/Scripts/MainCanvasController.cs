using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainCanvasController : MonoBehaviour
{
    [SerializeField] private Image fonImage;
    [SerializeField] private Sprite fonImageMain;
    [SerializeField] private Sprite fonImageSelect;
    [SerializeField] private Sprite fonImageSettings;
    [SerializeField] private Sprite fonImageAutor;

    [SerializeField] private GameObject mainPanel;
    [SerializeField] private GameObject selectPanel;
    [SerializeField] private GameObject settingsPanel;
    [SerializeField] private GameObject autorPanel;

    private bool startButton = false;
    private bool settingsButton = false;
    private bool autorButton = false;
    private bool exitButton = false;


    private void Start()
    {
        fonImage.sprite = fonImageMain;
    }

    public void ClickOnStartButton()
    {
        startButton = true;

        mainPanel.SetActive(false);
        fonImage.sprite = fonImageSelect;
        selectPanel.SetActive(true);
    }

    public void ClickOnBackSelectMenu()
    {
        selectPanel.SetActive(false);
        fonImage.sprite = fonImageMain;
        mainPanel.SetActive(true);
    }

    public void ClickOnSettingsButton()
    {
        settingsButton = true;
    }


    public void ClickOnAutorButton()
    {
        autorButton = true;

        mainPanel.SetActive(false);
        fonImage.sprite = fonImageAutor;
        autorPanel.SetActive(true);
    }

    public void ClickOnBackAutorMenu()
    {
        autorPanel.SetActive(false);
        fonImage.sprite = fonImageMain;
        mainPanel.SetActive(true);
    }

    public void ClickOnExitButton()
    {
        exitButton = true;
    }

}
