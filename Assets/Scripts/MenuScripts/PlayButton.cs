using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour {

    private Button btn;

    private void Start()
    {
        btn = this.GetComponent<Button>();
        btn.onClick.AddListener(loadLevel);
    }

    public void loadLevel()
    {
        SceneManager.LoadScene("GamePlay");
    }


}
