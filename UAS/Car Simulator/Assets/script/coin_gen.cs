using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin_gen : MonoBehaviour
{
    public GameObject coin;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreateObstacle", 3, 5);
    }
    void CreateObstacle(){
        Instantiate (coin);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
