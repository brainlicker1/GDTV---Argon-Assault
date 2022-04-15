using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CollisionHandler : MonoBehaviour
{       [SerializeField] float loadDelay =1f;
        [SerializeField] ParticleSystem crashSFX;
     void OnCollisionEnter(Collision other) {
        Debug.Log("BANG BITCH " + other.gameObject.name);
        
        

    }

    void OnTriggerEnter(Collider other) {
        Debug.Log("GetTriggered Bitch " + other.gameObject.name);
        StartCrashSequence();
       
    }

    void StartCrashSequence(){
        GetComponent<PlayerController>().enabled = false;
        
        Invoke("ReloadLevel" ,loadDelay);
    }
    void ReloadLevel(){
        
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<BoxCollider>().enabled = false;
        crashSFX.Play();
        SceneManager.LoadScene(currentSceneIndex);

    }
}
