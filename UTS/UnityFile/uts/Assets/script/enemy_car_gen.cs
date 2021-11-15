using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_car_gen : MonoBehaviour
{
    public GameObject[] enemy;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreateObstacle", 1, 1.5f);
        InvokeRepeating("CreateObstacle", 2, 3);
    }
    void CreateObstacle(){
        int indx = Random.Range(0,enemy.Length);
        Instantiate(enemy[indx]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
