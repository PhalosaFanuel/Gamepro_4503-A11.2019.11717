using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class house_gen : MonoBehaviour
{
        public GameObject[] house;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreateObstacle", 1, 1.5f);
        InvokeRepeating("CreateObstacle", 2, 3);
    }
    void CreateObstacle(){
        int indx = Random.Range(0,house.Length);
        Instantiate(house[indx]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
