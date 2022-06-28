using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject Enemy;
    public Transform StartPoint;
    public float minSpawnTime = 1f;
    public float maxSpawnTime = 5f;
    private float lastSpawnTime = 0;

    private float spawnTime = 0;


    public void UpdateSpawnTime()
    {
        lastSpawnTime = Time.time;
        spawnTime = Random.Range(minSpawnTime, maxSpawnTime + 1);
    }

    public void Spawn()
    {
        RandomSpawn();
        UpdateSpawnTime();
    }

    public void Update()
    {
        if (Time.time >= lastSpawnTime + spawnTime)
        {
            Spawn()
;        }

    }

    public void Point1()
    {
        Vector3 Point1 = new Vector3(
            Random.Range(StartPoint.position.x + 5, StartPoint.position.x + 25), 0,
            Random.Range(StartPoint.position.z + 5, StartPoint.position.z + 25)
            );

        
        GameObject SpawnEnemy;
        SpawnEnemy = Instantiate(Enemy) as GameObject;
        SpawnEnemy.transform.position = Point1;

    }
    public void Point2()
    {
        Vector3 Point1 = new Vector3(
            Random.Range(StartPoint.position.x - 5, StartPoint.position.x - 25), 0,
            Random.Range(StartPoint.position.z - 5, StartPoint.position.z - 25)
            );

        
        GameObject SpawnEnemy;
        SpawnEnemy = Instantiate(Enemy) as GameObject;
        SpawnEnemy.transform.position = Point1;

    }
    public void Point3()
    {
        Vector3 Point1 = new Vector3(
            Random.Range(StartPoint.position.x - 5, StartPoint.position.x - 25), 0,
            Random.Range(StartPoint.position.z + 5, StartPoint.position.z + 25)
            );

        
        GameObject SpawnEnemy;
        SpawnEnemy = Instantiate(Enemy) as GameObject;
        SpawnEnemy.transform.position = Point1;

    }
    public void Point4()
    {
        Vector3 Point1 = new Vector3(
            Random.Range(StartPoint.position.x + 5, StartPoint.position.x + 25), 0,
            Random.Range(StartPoint.position.z - 5, StartPoint.position.z - 25)
            );

        
        GameObject SpawnEnemy;
        SpawnEnemy = Instantiate(Enemy) as GameObject;
        SpawnEnemy.transform.position = Point1;

    }


    public void RandomSpawn()
    {
        int x;
        x = Random.Range(1, 5);
        if(x == 1)
        {
            Point1();
        }

        if (x == 2)
        {
            Point2();
        }

        if(x == 3)
        {
            Point3();
        }
        if(x == 4)
        {
            Point4();
        }

        
    }


   
}
