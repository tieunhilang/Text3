using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CheckDead : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Enemy")
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
