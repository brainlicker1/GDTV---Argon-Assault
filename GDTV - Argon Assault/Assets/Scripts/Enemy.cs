using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{       
    ScoreScript scoreScript;
    GameObject spawnPoint;
    [SerializeField] GameObject deathVfx;
     
    [SerializeField] int enemyScoreValue = 500;
    [SerializeField] int enemyHitpoints = 2;
    // Start is called before the first frame update

    void Start()
    {
        scoreScript = FindObjectOfType<ScoreScript>();
        spawnPoint = GameObject.FindWithTag("Spawner");
        RBadd();
    }

    void RBadd()
    {
        Rigidbody rb = gameObject.AddComponent<Rigidbody>();
        rb.useGravity = false;
    }

    void OnParticleCollision(GameObject other) {

         
         ScoreIncrease();
         if(enemyHitpoints <= 0) {

              GameObject vfx = Instantiate(deathVfx,transform.position, Quaternion.identity);
        vfx.transform.parent = spawnPoint.transform;
        Destroy(gameObject);
         }
       
    }

    void ScoreIncrease(){
        enemyHitpoints--;
        scoreScript.IncreaseScore(enemyScoreValue);

    }

}
