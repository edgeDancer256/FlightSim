using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneFollower : MonoBehaviour
{
    GameObject drone;
    Vector3 offset = new Vector3(-10, 10, 0);
    // Start is called before the first frame update
    void Start()
    {
        drone = GameObject.FindGameObjectWithTag("Drone");
    }

    // Update is called once per frame
    
    void FixedUpdate()
    {
        transform.position = drone.transform.position + offset;
    }
}
