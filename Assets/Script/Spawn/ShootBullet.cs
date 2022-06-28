using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBullet : MonoBehaviour
{
    public GameObject Bullet;
    public Transform Target;
    private Score score;

    public void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(Bullet, Target.position, Quaternion.identity);
           
            
        }
    }

   
}
