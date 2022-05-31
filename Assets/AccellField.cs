using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccellField : MonoBehaviour
{
    public float power = 3;
    private void OnTriggerStay(Collider other)
    {
        Rigidbody r = other.GetComponent<Rigidbody>();
        if(r != null)
        {
            r.AddForce(new Vector3(0, 0, 1) * power);
        }
    }
}
