using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCameraController : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform Target;
    //public Vector3 DistanceFromTarget;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = Target.transform.position;
        transform.rotation = Target.parent.rotation;
    }
}
