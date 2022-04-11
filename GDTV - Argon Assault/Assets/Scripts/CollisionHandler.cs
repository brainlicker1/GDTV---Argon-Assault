using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
     void OnCollisionEnter(Collision other) {
        Debug.Log("BANG BITCH " + other.gameObject.name);
    }

    void OnTriggerEnter(Collider other) {
        Debug.Log("GetTriggered Bitch " + other.gameObject.name);
    }
}
