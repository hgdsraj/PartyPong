using UnityEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Collections;
using System.IO.Ports;
using System.Threading;


public class paddlecontrol : MonoBehaviour
{
    //Paddle movement speed vars
    private const float STOP = 0.0f;
    private const float SLOW = 1.2f;
    private const float MED = 1.8f;
    private const float FAST = 3.5f;

    public SwingAnimation SwingAnim;
    //Create the port
    SerialPort sp = new SerialPort("COM5", 9600);


    public float speed;
    private float _velocity;
    private float _moveAmount;


    // Use this for initialization
    void Start()
    {

        speed = 6.0f;

        sp.DtrEnable = true;
        sp.Open();
        //sp.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);
        Debug.Log("Is Open : " + sp.IsOpen);

        //Debug.Log(sp.BytesToRead);
        sp.ReadTimeout = 1000;
        Debug.Log("start paddle 2");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPos = GameObject.Find("PaddleController").transform.position;
       /* if (this.transform.rotation.eulerAngles.z <= 35 && this.transform.rotation.eulerAngles.z >= -35)
        {
            transform.Rotate(Vector3.forward, playerPos.x*45/100);
        }*/

       
        if (playerPos.x > 3.5) {
            this.transform.position = new Vector3(playerPos.x - 0.2f, playerPos.y, playerPos.z);
        }
        if (playerPos.x < -3.5)
        {
            this.transform.position = new Vector3(playerPos.x + 0.2f, playerPos.y, playerPos.z);
        }


        //Debug.Log(sp.ReadByte());   
        if (sp.IsOpen)
        {
            try
            {
                //Console.WriteLine("Reading buffer");
                //Console.WriteLine("Bytes to read : " + sp.BytesToRead);
                int aByte = sp.ReadByte();
                if (aByte > 0)
                {
                    MovePaddle(aByte);
                }
            }
            catch (System.Exception)
            {

            }
        }
        else
        {
            Debug.Log("sp not open");
        }
    }

    void MovePaddle(int direction)
    {

 



        //Debug.Log("DIRECTION: " + direction);
        if (direction == 1)
        {
            _velocity = FAST;
            _moveAmount = _velocity * speed * Time.deltaTime;
            transform.Translate(Vector3.left * _moveAmount, Space.World);
        }
        else if (direction == 2)
        {
            _velocity = MED;
            _moveAmount = _velocity * speed * Time.deltaTime;
            transform.Translate(Vector3.left * _moveAmount, Space.World);
        }
        else if (direction == 3)
        {
            _velocity = SLOW;
            _moveAmount = _velocity * speed * Time.deltaTime;
            transform.Translate(Vector3.left * _moveAmount, Space.World);
        }
        else if (direction == 4)
        {
            _velocity = STOP;
            _moveAmount = _velocity * speed * Time.deltaTime;
            transform.Translate(Vector3.right * _moveAmount, Space.World);
        }
        else if (direction == 5)
        {
            _velocity = SLOW;
            _moveAmount = _velocity * speed * Time.deltaTime;
            transform.Translate(Vector3.right * _moveAmount, Space.World);
        }
        else if (direction == 6)
        {
            _velocity = MED;
            _moveAmount = _velocity * speed * Time.deltaTime;
            transform.Translate(Vector3.right * _moveAmount, Space.World);
        }
        else if (direction == 7)
        {
            _velocity = FAST;
            _moveAmount = _velocity * speed * Time.deltaTime;
            transform.Translate(Vector3.right * _moveAmount, Space.World);
        }
        if (direction == 8)
        {
            if (SwingAnim != null)
            {
                Debug.Log("Please swing!");
            }
            Debug.Log("DIRECTION: " + direction);
            SwingAnim.swing();

        }
    }
}


