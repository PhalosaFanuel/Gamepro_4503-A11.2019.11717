using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class guiManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPlay(){
        SceneManager.LoadScene("howtoplay");
    }
    
    public void ResetScore(){
        highscorescript.ResetHighScore();
        MainMenu();
    }

    public void OnPlay3(){
        SceneManager.LoadScene("game");
        heart_counter.health = 3;
    }

    public void MainMenu(){
        SceneManager.LoadScene("main");
    }

    public void Credit(){
        SceneManager.LoadScene("credit");
    }
}
