using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{       
    ScoreScript scoreScript;
    [SerializeField] GameObject deathVfx;
    [SerializeField] Transform parent;
    [SerializeField] int enemyScoreValue = 500;
    [SerializeField] int enemyHitpoints = 2;
    // Start is called before the first frame update

    void Start() {
     scoreScript = FindObjectOfType<ScoreScript>();

    }
     void OnParticleCollision(GameObject other) {

         
         ScoreIncrease();
         if(enemyHitpoints <= 0) {

              GameObject vfx = Instantiate(deathVfx,transform.position, Quaternion.identity);
        vfx.transform.parent = parent;
        Destroy(gameObject);
         }
       
    }

    void ScoreIncrease(){
        enemyHitpoints--;
        scoreScript.IncreaseScore(enemyScoreValue);

    }

}
