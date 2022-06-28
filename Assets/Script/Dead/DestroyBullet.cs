using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBullet : MonoBehaviour
{
    public void Start()
    {
        Destroy(gameObject, 2f);
    }
}
