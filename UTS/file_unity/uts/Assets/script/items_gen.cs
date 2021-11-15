using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class items_gen : MonoBehaviour
{
    public GameObject[] items;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreateObstacle", 10, 10);
    }
    void CreateObstacle(){
        int indx = Random.Range(0,items.Length);
        Instantiate(items[indx]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
