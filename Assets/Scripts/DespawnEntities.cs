using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DespawnEntities : MonoBehaviour
{
    //script catches any projectiles or asteroids that fly off-screen

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
}
