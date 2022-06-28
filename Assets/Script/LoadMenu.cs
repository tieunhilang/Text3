using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadMenu : MonoBehaviour
{
    public Button loadMenu;

    public void Start()
    {
        loadMenu.onClick.AddListener(LoadMenuGame);
    }

    private void LoadMenuGame()
    {
        SceneManager.LoadScene(0);
    }
}
