using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public float speed;
    private Rigidbody Rigidbody;
    public int pointValue;

    void Start()
    {
        //get rigidbody of asteroid
        Rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //move asteroid forward
        Rigidbody.AddRelativeForce(Vector3.forward * speed);
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Projectile")
        {
            //if this asteroid collides with a projectile, add the corresponding point value to the total points
            GameObject.Find("PointsTracker").GetComponent<PointsTracker>().UpdatePoints(pointValue);
        }
	}



}
