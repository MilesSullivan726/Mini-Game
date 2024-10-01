using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Projectile : MonoBehaviour
{
    //public GameObject pointsTracker;

    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(Vector3.right, 90);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * Time.deltaTime * 10);
        
    }

    void OnTriggerEnter(Collider other)
    {
        //Debug.Log("triggered");
        if (other.gameObject.tag == "Asteroid")
        {
            //Debug.Log("Detected Projectile");
            //GameObject.Find("PointsTracker").GetComponent<PointsTracker>().UpdatePoints(1);
            Destroy(gameObject);
            Destroy(other.gameObject);
            //Debug.Log("Destroyed");
        }

    }

}
