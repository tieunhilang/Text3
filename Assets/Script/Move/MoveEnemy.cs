using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : MonoBehaviour
{
    protected int SpeedEnemy;

    public int minSpeedEnemy = 2;

    public int maxSpeedEnemy = 5;

    GameObject player;

    public void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        Enemy();
        RandomSpeed();
    }

    public void RandomSpeed()
    {
        SpeedEnemy = Random.Range(minSpeedEnemy, maxSpeedEnemy);

    }
    public void Enemy()
    {

        if (player == null) return;
        transform.LookAt(player.transform.position);
        transform.Translate(Vector3.forward * SpeedEnemy * Time.deltaTime);
    }
    
}
