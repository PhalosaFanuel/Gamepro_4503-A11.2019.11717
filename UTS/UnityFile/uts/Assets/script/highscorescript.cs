using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class highscorescript : MonoBehaviour
{
    public Text teksHighScore;
    // Start is called before the first frame update
    void Start()
    {
        teksHighScore.text = "Highscore = "+ LoadHighscore().ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static int LoadHighscore(){
        int hg = 0;
        if (!PlayerPrefs.HasKey("highscore")){
            PlayerPrefs.SetInt("highscore",0);
        } else {
            hg = PlayerPrefs.GetInt("highscore");
        }
        return hg;
    }
    public static void SaveHighScore(int score){
        // int hg = 0;
        if (!PlayerPrefs.HasKey("highscore")){
            PlayerPrefs.SetInt("highscore",0);
        } else {
            PlayerPrefs.SetInt ("highscore", score);
        }
    }

    public static void ResetHighScore(){
        PlayerPrefs.SetInt("highscore",0);
    }
}
