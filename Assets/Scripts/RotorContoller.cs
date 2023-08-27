using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotorContoller : MonoBehaviour
{
    public float rot_speed = 50.0f;
    GameObject[] rotors;
    GameObject[] wings;
    GameObject drone;
    // Start is called before the first frame update
    void Start()
    {
        drone = GameObject.FindGameObjectWithTag("Drone"); 
        rotors  = GameObject.FindGameObjectsWithTag("Rotor");
        wings = GameObject.FindGameObjectsWithTag("Wing");
    }

    // Update is called once per frame
    void Update()
    {
        rotors[0].transform.Rotate(Vector3.forward * rot_speed);
        rotors[1].transform.Rotate(Vector3.forward * rot_speed);
        rotors[2].transform.Rotate(Vector3.forward * rot_speed);
        rotors[3].transform.Rotate(Vector3.forward * rot_speed);


        if (Input.GetKey(KeyCode.Q))
        {
            drone.transform.Translate(Vector3.forward * 5.0f * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.E))
        {
            drone.transform.Translate(Vector3.back * 5.0f * Time.deltaTime);
        }


        //Going Front
        if(Input.GetKey(KeyCode.W))
        {
            drone.transform.Translate(Vector3.left * 5.0f * Time.deltaTime);

            for(int i = 0; i < 4; i++) {
                if (wings[i].transform.localEulerAngles.y > 315 || wings[i].transform.localEulerAngles.y == 0)
                {
                    wings[i].transform.Rotate(Vector3.down * 45);
                }
            }
        } 
        if(Input.GetKeyUp(KeyCode.W))
        {

            for (int i = 0; i < 4; i++) {
                wings[i].transform.Rotate(Vector3.up * 45);
            }
        }

        //Going Back
        if (Input.GetKey(KeyCode.S))
        {
            drone.transform.Translate(Vector3.right * 5.0f * Time.deltaTime);

            for (int i = 0; i < 4; i++)
            {
                if (wings[i].transform.localEulerAngles.y < 45 || wings[i].transform.localEulerAngles.y == 0)
                {
                    wings[i].transform.Rotate(Vector3.up * 45);
                }
            }
        }
        if (Input.GetKeyUp(KeyCode.S))
        {

            for (int i = 0; i < 4; i++)
            {
                wings[i].transform.Rotate(Vector3.down * 45);
            }
        }

        //Strafe Left
        if (Input.GetKey(KeyCode.A))
        {
            drone.transform.Translate(Vector3.up * 5.0f * Time.deltaTime);

        }
        if (Input.GetKeyUp(KeyCode.A))
        {

        }

        //Strafe Right
        if (Input.GetKey(KeyCode.D))
        {
            if (drone.transform.localEulerAngles.x < 30 || drone.transform.localEulerAngles.y == 0)
            {
                drone.transform.Rotate(Vector3.left * 30);
            }

            
            drone.transform.Translate(Vector3.down * 5.0f * Time.deltaTime);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {

        }
    }

}
