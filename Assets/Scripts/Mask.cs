using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mask : MonoBehaviour

    
{
    public float speed = 0.1f;
    public Vector3 path;
    //private GameObject maskRB;

    // Start is called before the first frame update
    void Start()
    {
    //maskRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<Rigidbody>().velocity = speed * path;
    }
}
