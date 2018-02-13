using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    // the play button this script is attached to and its sprite
    public Button playBtn;
    public Sprite playBtnClicked;

    private void Start()
    {
        // add a listener for the button
        playBtn.onClick.AddListener(loadGamePlayScene);
    }

    // if the button is clicked then change its sprite and load the main game scene
    public void loadGamePlayScene()
    {
        playBtn.GetComponent<Image>().sprite = playBtnClicked;
        SceneManager.LoadScene("GamePlay");
    }
}
