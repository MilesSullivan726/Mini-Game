using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    

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


}
