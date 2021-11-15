using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playercontrol : MonoBehaviour
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
        if(Input.GetKey("up")){
            transform.position = transform.position + (up * speed * Time.deltaTime);
        }
        if(Input.GetKey("down")){
            transform.position = transform.position + (down * speed * Time.deltaTime);
        }
        if(Input.GetKey("left")){
            transform.position = transform.position + (left * speed * Time.deltaTime);
        }
        if(Input.GetKey("right")){
            transform.position = transform.position + (right * speed * Time.deltaTime);
        }
    }
}
