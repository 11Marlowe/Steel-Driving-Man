using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayAgainButtonScript : MonoBehaviour
{
    public Button playAgainBtn;

    // Use this for initialization
    void Start()
    {
        playAgainBtn.onClick.AddListener(playAgain);
    }

    public void playAgain()
    {
        SceneManager.LoadScene("GamePlay");
    }
}
