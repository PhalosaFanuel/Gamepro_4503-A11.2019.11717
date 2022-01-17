using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class heart_counter : MonoBehaviour
{
    public GameObject heart1,heart2,heart3,shield;
    public static int health = 3;
    public static bool shield_status = false;
    // Start is called before the first frame update
    void Start()
    {
        heart1.gameObject.SetActive(true);
        heart2.gameObject.SetActive(true);
        heart3.gameObject.SetActive(true);
        shield.gameObject.SetActive(false);
        if (!PlayerPrefs.HasKey("shield")){
            PlayerPrefs.SetInt("shield",0);
        } else {
            int x = PlayerPrefs.GetInt("shield");
            if (x == 1){
                shield.gameObject.SetActive(true);
                shield_status = true;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (health > 3){
            health = 3;
        }
        if (shield_status){
            shield.gameObject.SetActive(true);
        }else{
            shield.gameObject.SetActive(false);
        }

        switch(health){
            case 3:
            heart1.gameObject.SetActive(true);
            heart2.gameObject.SetActive(true);
            heart3.gameObject.SetActive(true);
            break;
            case 2:
            heart1.gameObject.SetActive(true);
            heart2.gameObject.SetActive(true);
            heart3.gameObject.SetActive(false);
            break;
            case 1:
            heart1.gameObject.SetActive(true);
            heart2.gameObject.SetActive(false);
            heart3.gameObject.SetActive(false);
            break;
            case 0:
            heart1.gameObject.SetActive(false);
            heart2.gameObject.SetActive(false);
            heart3.gameObject.SetActive(false);
            PlayerPrefs.SetInt("shield",0);
            scorescript.UpdateHighScore();
            SceneManager.LoadScene("main");
            break;
        }
    }
}
