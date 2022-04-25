using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayerSingleton : MonoBehaviour
{       
   void Awake() {
        
      int numAudio = FindObjectsOfType<AudioPlayerSingleton>().Length;

        if (numAudio >= 1){

            Destroy(gameObject);
        }
        else {

            DontDestroyOnLoad(gameObject);
        }
    }
    
    
}
