using System.Collections;
using System.Collections.Generic;
using PathCreation;
using UnityEngine;

public class Shooter : MonoBehaviour
{

    public float speed = 40f;
    public GameObject mask;
    public Transform barrel;
    // public AudioSource audioSource;
    // public AudioClip audioClip;
    public PathCreator pathCreator;
    float distanceTravelled;

    
    public void Fire()
    {
        //GameObject spawnedMask = Instantiate(mask, barrel.position, barrel.rotation);
        // spawnedMask.GetComponent<Rigidbody>().velocity = speed * barrel.forward;
        //distanceTravelled += speed * Time.deltaTime;
        // transform.position += pathCreator.path.GetPointAtDistance(distanceTravelled);
        // audioSource.PlayOneShot(audioClip);
        //Destroy(spawnedMask, 2);

        GameObject instMask = Instantiate(mask, transform.position, Quaternion.identity) as GameObject;
        Rigidbody instMaskRigidBody = instMask.GetComponent<Rigidbody>();
        instMaskRigidBody.AddForce(Vector3.forward * speed);

    }
    
}
