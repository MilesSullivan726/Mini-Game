using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Projectile : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        //object spawns facing wrong way, so rotate after being spawned
        transform.Rotate(Vector3.right, 90);
    }

    // Update is called once per frame
    void Update()
    {
        //projectile moves forward after being spawned
        transform.Translate(Vector3.down * Time.deltaTime * 10);
        
    }

    void OnTriggerEnter(Collider other)
    {
        //Debug.Log("triggered");
        if (other.gameObject.tag == "Asteroid")
        {
            //destroy both projectile and asteroid when the two come into contact
            Destroy(gameObject);
            Destroy(other.gameObject);

        }

    }

}
