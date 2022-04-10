using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Wrld;

public class HelicopterController : MonoBehaviour
{
    // Start is called before the first frame update

    public Wrld.Space.LatLongAltitude lla;
    public float speed = 0.1f;
    public float updownSpeed = 0.1f;
    public float RotationSpeed = 1f;
    float changePos = 0;
    private Rigidbody myrigidbody;

    enum Directions
    {
        Forward,
        Backward,
        Upward,
        Downward,
        Left,
        Right,
        Stop,
    }

    Directions myDirection;

    void Start()
    {
        myrigidbody = GetComponent<Rigidbody>();
        myDirection = Directions.Stop;
    }

    // Update is called once per frame
    void Update()
    {
        switch (myDirection)
        {
            case Directions.Forward:
                myrigidbody.velocity = transform.forward * speed;
                break;
            case Directions.Backward:
                myrigidbody.velocity = -transform.forward * speed;
                break;
            case Directions.Upward:
                myrigidbody.velocity = transform.up * updownSpeed;
                break;
            case Directions.Downward:
                myrigidbody.velocity = -transform.up * updownSpeed;
                break;
            case Directions.Left:
                transform.Rotate(new Vector3(0, -1, 0) * Time.deltaTime * RotationSpeed, Space.World);
                break;
            case Directions.Right:
                transform.Rotate(new Vector3(0, 1, 0) * Time.deltaTime * RotationSpeed, Space.World);
                break;
        }

    }


    public void isForward()
    {
        myDirection = Directions.Forward;
    }
    public void isBackward()
    {
        myDirection = Directions.Backward;
    }
    public void isUpward()
    {
        myDirection = Directions.Upward;
    }
    public void isDownward()
    {
        myDirection = Directions.Downward;
    }
    public void isLeft()
    {
        myDirection = Directions.Left;
    }
    public void isRight()
    {
        myDirection = Directions.Right;
    }

    public void Stop()
    {
        myrigidbody.velocity = Vector3.zero;
        myrigidbody.angularVelocity = Vector3.zero;
        myDirection = Directions.Stop;
    }
}