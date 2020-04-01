using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;



public class SCR_SteeringScript : MonoBehaviour
{

    SerialPort serial = new SerialPort("COM3", 9600);
    public int Heading;

    // Update is called once per frame
    void Update()
    {
        if (!serial.IsOpen)
        {
            serial.Open();
        }

        Heading = int.Parse(serial.ReadLine());
        transform.localEulerAngles = new Vector3(0, Heading, 0);
    }
}
