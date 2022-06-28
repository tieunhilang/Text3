using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Collider))]

public class MoveBullet : MonoBehaviour
{

    private Rigidbody rb;

    

    private float SpeedBullet = 10f;

    public void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            rb.AddForce(new Vector3(hit.point.x, 1, hit.point.z) * SpeedBullet);
            
        }
    }






}
