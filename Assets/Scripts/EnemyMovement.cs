using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    GameObject target;
    float speed;

    // Start is called before the first frame update
    void Start()
    {
        speed = 0.5f;
        target = GameObject.Find("VR Rig");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);

        Vector3 direction = Vector3.RotateTowards(Vector3.forward, target.transform.position, 2f, 0f);
        transform.rotation = Quaternion.LookRotation(direction);

    }
}
