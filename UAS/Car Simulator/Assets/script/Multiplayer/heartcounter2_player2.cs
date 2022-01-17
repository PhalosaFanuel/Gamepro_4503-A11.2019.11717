using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class heartcounter2_player2 : MonoBehaviour
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
            SceneManager.LoadScene("main");
            break;
        }
    }
}
