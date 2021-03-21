using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject mask;
    public float speed = 0.05f;


    public void Start()
    {

    }

    public void Update()
    {
 
        GameObject instMask = Instantiate(mask,transform.position,Quaternion.identity) as GameObject;
        Rigidbody instMaskRigidBody = instMask.GetComponent<Rigidbody>();
        instMaskRigidBody.AddForce(Vector3.forward * speed);

    }

}
