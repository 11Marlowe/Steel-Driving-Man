using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GotBackToMenuButtonScript : MonoBehaviour
{

    public Button goBackToMenuBtn;

	// Use this for initialization
	void Start ()
    {
        goBackToMenuBtn.onClick.AddListener(goBackToMenu);
	}

    public void goBackToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
