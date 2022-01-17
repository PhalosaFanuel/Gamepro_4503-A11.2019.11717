using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FuelCounter : MonoBehaviour
{
    public static float timer = 100;
    float fuel;
    public Text text;

    // Start is called before the first frame update
    void Start()
    {
        timer = 100;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > 100){
            timer = 100;
        }
        if (timer > 0){
            timer -= Time.deltaTime;
            fuel = Mathf.Round(timer);
            text.text = "Fuel : "+fuel;
        }else{
            heart_counter.health = 0;
        }
    }
}
