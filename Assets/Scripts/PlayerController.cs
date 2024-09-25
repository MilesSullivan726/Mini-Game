using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    //define inputs
    private float horizontalInput;
    private float verticalInput;
    public GameObject prefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //get input axis
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        //Move player forward
        transform.Translate(Vector3.back * verticalInput * Time.deltaTime * 2);

        //Turn player left or right
        transform.Rotate(Vector3.up * horizontalInput * Time.deltaTime * 200);

        //Keep player on screen
        //left and right bounds
        if (transform.position.x < -5.5f){
            transform.position = new Vector3(-5.5f, transform.position.y, transform.position.z);
        }

        else if (transform.position.x > 3){
            transform.position = new Vector3(3, transform.position.y, transform.position.z);
        }

        //top and bottom bounds
        if (transform.position.z > -2){
            transform.position = new Vector3(transform.position.x, transform.position.y, -2f);
        }

        else if (transform.position.z < -6.7f){
            transform.position = new Vector3(transform.position.x, transform.position.y, -6.7f);
        }

        //fire projectile
        if (Input.GetKeyDown(KeyCode.Space)){
            Instantiate(prefab, transform.position, transform.localRotation);
            
        }
    }
}
