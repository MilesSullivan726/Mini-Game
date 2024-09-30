using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public float speed;
    private Rigidbody Rigidbody;
    public GameObject projectile;

    void Start()
    {
        gameObject.tag = "Asteroid";
        Rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //transform.Translate(Vector3.forward * Time.deltaTime * speed);
        //Rigidbody.AddForce(Vector3.forward, ForceMode.Force);
        Rigidbody.AddRelativeForce(Vector3.forward * speed);
        
    }

    
}
