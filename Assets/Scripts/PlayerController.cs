using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    //define inputs
    private float horizontalInput;
    private float verticalInput;
    public GameObject prefab;
    private Rigidbody Rigidbody;
    public GameObject gameOver;

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody = GetComponent<Rigidbody>();
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
        transform.Rotate(Vector3.up * horizontalInput * Time.deltaTime * 250);

        //Keep player on screen
        //left and right bounds
        if (transform.position.x < -4.5f){
            transform.position = new Vector3(-4.5f, transform.position.y, transform.position.z);
        }

        else if (transform.position.x > 2){
            transform.position = new Vector3(2, transform.position.y, transform.position.z);
        }

        //top and bottom bounds
        if (transform.position.z > -2.5){
            transform.position = new Vector3(transform.position.x, transform.position.y, -2.5f);
        }

        else if (transform.position.z < -6.1f){
            transform.position = new Vector3(transform.position.x, transform.position.y, -6.1f);
        }

        //fire projectile
        if (Input.GetKeyDown(KeyCode.Space)){
            Instantiate(prefab, transform.position, transform.localRotation);
            
        }
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("triggered");
        if (other.gameObject.tag == "Asteroid")
        {
            Debug.Log("Detected Projectile");
            Destroy(gameObject);
            Debug.Log("Game Over");
            gameOver.SetActive(true);
            Time.timeScale = 0;

        }

    }
}
