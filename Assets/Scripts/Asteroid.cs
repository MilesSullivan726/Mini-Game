using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public float speed;
    public GameObject projectile;

    void Start()
    {
        gameObject.tag = "Asteroid";
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Projectile"){
            Destroy(gameObject);
            
        }
        
    }
}
