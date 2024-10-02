using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    //define inputs
    private float horizontalInput;
    private float verticalInput;
    public GameObject prefab;
    public GameObject gameOver;
    private float lastShot = 0;

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

        //fire projectile if spacebar pressed and a shot hasn't been fired in 0.3 sec
        if (Input.GetKeyDown(KeyCode.Space) && Time.time - lastShot >= 0.3f){
            lastShot = Time.time;    
            Instantiate(prefab, transform.position, transform.localRotation);
        }
    }

    void OnTriggerEnter(Collider other)
    {
      
        if (other.gameObject.tag == "Asteroid")
        {
            Destroy(gameObject);
            //display game over screen and end game
            gameOver.SetActive(true);
			GameObject.Find("Game Over Screen").GetComponent<GameOverPoints>().FinalPoints();
			Time.timeScale = 0;

        }

    }
}
