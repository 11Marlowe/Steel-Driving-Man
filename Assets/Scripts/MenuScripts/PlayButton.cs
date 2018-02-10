using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    public Button playBtn;
    public Sprite playBtnClicked;

    private void Start()
    {
        playBtn.onClick.AddListener(loadGamePlayScene);
    }

    public void loadGamePlayScene()
    {
        playBtn.GetComponent<Image>().sprite = playBtnClicked;
        SceneManager.LoadScene("GamePlay");
    }
}
