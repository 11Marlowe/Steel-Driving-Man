using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuitButton : MonoBehaviour {

    private Button quitBtn;

    // Use this for initialization
    void Start () {

        quitBtn = GetComponent<Button>();
        quitBtn.onClick.AddListener(quitGame);
	}
	
    public void quitGame()
    {
        Application.Quit();
    }
}
