using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayAgainButtonScript : MonoBehaviour
{
    public Button playAgainBtn;
    public Sprite playPressed;

    // Use this for initialization
    void Start()
    {
        playAgainBtn.onClick.AddListener(playAgain);
    }

    public void playAgain()
    {
        playAgainBtn.GetComponent<Image>().sprite = playPressed;
        SceneManager.LoadScene("GamePlay");
    }
}
