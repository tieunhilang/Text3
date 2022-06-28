using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuGame : MonoBehaviour
{
    public Button Play;
    public Button Option;

    public void Start()
    {
        Play.onClick.AddListener(LoadPlayGame);
        Option.onClick.AddListener(LoadOption);
    }


    public void LoadPlayGame()
    {
        SceneManager.LoadScene(2);
    }

    public void LoadOption()
    {
        SceneManager.LoadScene(1);
    }
}
