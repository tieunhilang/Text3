using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour
{
    private Score scoreClone;
    private void Start()
    {
        scoreClone = GameObject.Find("Score").GetComponent<Score>();
    }
    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Bullet")
        {
            Destroy(gameObject);
            scoreClone.addScore(1);
        }


    }

}
