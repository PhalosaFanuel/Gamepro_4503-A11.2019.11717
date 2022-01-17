using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2control : MonoBehaviour
{
    Vector3 up;
    Vector3 down;
    Vector3 left;
    Vector3 right;
    float speed = 7;
    // Start is called before the first frame update
    void Start()
    {
        up = new Vector3(0,1,0);
        down = new Vector3(0,-1,0);
        left = new Vector3(-1,0,0);
        right = new Vector3(1,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W)){
            transform.position = transform.position + (up * speed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.S)){
            transform.position = transform.position + (down * speed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.A)){
            transform.position = transform.position + (left * speed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.D)){
            transform.position = transform.position + (right * speed * Time.deltaTime);
        }
    }
}
