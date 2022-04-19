using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreScript : MonoBehaviour
{
    int score;
    [SerializeField] TMP_Text scoreText;

    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Start()
    {
        scoreText = GetComponent<TMP_Text>();
        scoreText.text = "Score: ";
    }
   public void IncreaseScore(int scoreAmmount){

       score += scoreAmmount; 
       scoreText.text = score.ToString();
   }
}
