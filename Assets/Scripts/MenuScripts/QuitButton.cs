using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuitButton : MonoBehaviour
{

    public Button quitBtn;
    public Sprite quitBtnClicked;

    // Use this for initialization
    void Start ()
    {
        quitBtn.onClick.AddListener(quitGame);
	}
	
    public void quitGame()
    {
        quitBtn.GetComponent<Image>().sprite = quitBtnClicked;
        Application.Quit();
    }
}
