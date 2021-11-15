using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scorescript : MonoBehaviour
{
    public static int scoreValue = 0;
    Text score;
    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
        scoreValue = 0;
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Score : "+scoreValue;
    }

    public static void UpdateHighScore(){
        int old_score = highscorescript.LoadHighscore();
        if (old_score < scoreValue){
            highscorescript.SaveHighScore(scoreValue);
        }
    }
}
