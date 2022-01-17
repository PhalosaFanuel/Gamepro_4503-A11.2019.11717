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
        bool multiplier_status = false;
        if (PlayerPrefs.HasKey("multiplier")){
            int mul = PlayerPrefs.GetInt("multiplier");
            if (mul == 1){
                multiplier_status = true;
                PlayerPrefs.SetInt("multiplier",0);
            }
        }
        if (!PlayerPrefs.HasKey("coins")){
            if (multiplier_status){
                PlayerPrefs.SetInt("coins",scoreValue*2);
            }else{
                PlayerPrefs.SetInt("coins",scoreValue);
            }
        } else {
            int coins = PlayerPrefs.GetInt("coins");
            if (multiplier_status){
                PlayerPrefs.SetInt("coins",coins + (scoreValue*2));
            }else{
                PlayerPrefs.SetInt("coins",scoreValue+coins);
            }
        }
        if (old_score < scoreValue){
            highscorescript.SaveHighScore(scoreValue);
        }
    }
}
