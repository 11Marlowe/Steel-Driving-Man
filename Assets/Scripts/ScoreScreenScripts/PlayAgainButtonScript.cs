using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayAgainButtonScript : MonoBehaviour
{
    // variables representing the retry button and it's sprite
    public Button playAgainBtn;
    public Sprite playPressed;

    // Use this for initialization
    void Start()
    { 
        // add a listener for when the button is clicked
        playAgainBtn.onClick.AddListener(playAgain);
    }

    // change the button's sprite to the pressed sprite and go back to the main game
    public void playAgain()
    {
        playAgainBtn.GetComponent<Image>().sprite = playPressed;
        SceneManager.LoadScene("GamePlay");
    }
}
