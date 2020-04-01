using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;



public class SCR_SteeringScript : MonoBehaviour
{

    SerialPort serial = new SerialPort("COM3", 9600);
    private int Heading;
    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    // Update is called once per frame
    void Update()
    {
        if (!serial.IsOpen)
        {
            serial.Open();
        }

        Heading = int.Parse(serial.ReadLine());

       /* if (Heading == 0 )
        {
            rb.AddTorque(Vector3.left * 100 * Input.GetAxis("Vertical") * Time.deltaTime);
            Debug.Log("Turing Left");
        }
        if (Heading == 359)
        {
            rb.AddTorque(Vector3.right * 100 * Input.GetAxis("Vertical") * Time.deltaTime);
            Debug.Log("Turing Right");
        }*/
        transform.localEulerAngles = new Vector3(0, Heading, 0);
    }
}
