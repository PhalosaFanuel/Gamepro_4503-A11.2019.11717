using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class shopGUI : MonoBehaviour
{
    public Text teksCoin;
    public Button shield_button;
    public Button multiplier_button;
    public Text teks_shield;
    public Text teks_multiplier;
    bool shield;
    bool multi;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        teksCoin.text = "Coins = "+ loadCoins().ToString();
        shield = loadShield();
        multi = loadMulti();
        if (shield){
            shield_button.interactable = false;
            teks_shield.text = "Purchased";
        }
        if (multi){
            multiplier_button.interactable = false;
            teks_multiplier.text = "Purchased";
        }
    }

    public int loadCoins(){
        int hg = 0;
        if (!PlayerPrefs.HasKey("coins")){
            PlayerPrefs.SetInt("coins",0);
        } else {
            hg = PlayerPrefs.GetInt("coins");
        }
        return hg;
    }

    public bool loadShield(){
        bool found = false;
        int key = 0;
        if (PlayerPrefs.HasKey("shield")){
            key = PlayerPrefs.GetInt("shield");
            if (key == 1){
                found = true;
            }
        }
        return found;
    }

    public bool loadMulti(){
        bool found = false;
        int key = 0;
        if (PlayerPrefs.HasKey("multiplier")){
            key = PlayerPrefs.GetInt("multiplier");
            if (key == 1){
                found = true;
            }
        }
        return found;
    }
    
    public void buyShield(){
        int buy = loadCoins();
        if (buy >= 10){
            PlayerPrefs.SetInt("coins",buy-10);
            PlayerPrefs.SetInt("shield",1);
            
        }
    }

    public void buyMultiplier(){
        int buy = loadCoins();
        if (buy >= 30){
            PlayerPrefs.SetInt("coins",buy-30);
            PlayerPrefs.SetInt("multiplier",1);
        }
    }
}
