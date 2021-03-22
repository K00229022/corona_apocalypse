using System.Collections;
using System.Collections.Generic;
using PathCreation;
using UnityEngine;

public class Shooter : MonoBehaviour
{

    public float speed = 0.1f;
    public GameObject mask;
    public Transform barrel;
    // public AudioSource audioSource;
    // public AudioClip audioClip;
    public PathCreator pathCreator;
    float distanceTravelled;

    public void Start()
    {
       // Fire(); // use this to test in unity without having to build for quest
    }
    public void Fire()
    {
        //GameObject spawnedMask = Instantiate(mask, barrel.position, barrel.rotation);
        // spawnedMask.GetComponent<Rigidbody>().velocity = speed * barrel.forward;
        //distanceTravelled += speed * Time.deltaTime;
        // transform.position += pathCreator.path.GetPointAtDistance(distanceTravelled);
        // audioSource.PlayOneShot(audioClip);
        //Destroy(spawnedMask, 2);

        GameObject instMask = Instantiate(mask, this.transform.position, this.transform.rotation) as GameObject;
        instMask.gameObject.transform.TransformDirection(this.transform.right);
        instMask.GetComponent<Mask>().path = -this.transform.right;  // set correct direction of line of fire for mask 
        instMask.GetComponent<Mask>().speed = this.speed; // set speed of mask from shooter
        //Rigidbody instMaskRigidBody = instMask.GetComponent<Rigidbody>();
        //instMaskRigidBody.AddForce(transform.forward * speed);

    }
    
}
