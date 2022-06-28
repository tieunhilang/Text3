using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public Button gameOver;

    public void Start()
    {
        gameOver.onClick.AddListener(LoadMenuGame);
    }

    private void LoadMenuGame()
    {
        SceneManager.LoadScene(0);
    }

}
