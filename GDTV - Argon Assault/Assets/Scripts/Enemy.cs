using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{       
    ScoreScript scoreScript;
    [SerializeField] GameObject deathVfx;
    [SerializeField] Transform parent;
    [SerializeField] int enemyScoreValue = 500;
    // Start is called before the first frame update

    void Start() {
     scoreScript = FindObjectOfType<ScoreScript>();
    }
     void OnParticleCollision(GameObject other) {
         ScoreIncrease();
        GameObject vfx = Instantiate(deathVfx,transform.position, Quaternion.identity);
        vfx.transform.parent = parent;
        Destroy(gameObject);
    }

    void ScoreIncrease(){

scoreScript.IncreaseScore(enemyScoreValue);

    }

}
