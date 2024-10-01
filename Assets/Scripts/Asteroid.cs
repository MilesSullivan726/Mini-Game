using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public float speed;
    private Rigidbody Rigidbody;
    public GameObject projectile;
    public int pointValue;

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

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Projectile")
        {
            GameObject.Find("PointsTracker").GetComponent<PointsTracker>().UpdatePoints(pointValue);
        }
	}



}
