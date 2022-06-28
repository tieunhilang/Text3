using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveGun : MonoBehaviour
{
    protected Vector3 target;

    public void Update()
    {
        LookAtMove();
    }

    public void LookAtMove()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;

        if(Physics.Raycast(ray, out hit))
        {
            target = hit.point;
        }

        transform.LookAt(target);
    }
}
