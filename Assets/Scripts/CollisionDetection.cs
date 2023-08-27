using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    Rigidbody drone;
    // Start is called before the first frame update
    void Start()
    {
        drone = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Floor")) {
            drone.constraints = RigidbodyConstraints.FreezeAll;
        }
    }
}
