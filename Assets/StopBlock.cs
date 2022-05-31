using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopBlock : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Rigidbody r = other.GetComponent<Rigidbody>();
        if (r != null)
        {
            r.velocity = new Vector3(0, 0, 0);
            r.angularVelocity = new Vector3(0, 0, 0);
        }
    }
}
