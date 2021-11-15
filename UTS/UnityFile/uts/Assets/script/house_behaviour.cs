using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class house_behaviour : MonoBehaviour
{
    public Vector2 veloc = new Vector2(0,-5);
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D> ().velocity = veloc;
        int num = Random.Range(0,2);
        if (num == 0){
            transform.position = new Vector3 (Random.Range(-8,-6),10, transform.position.z);
            }
        else{
            transform.position = new Vector3 (Random.Range(8,6),10, transform.position.z);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y <= -7){
            Destroy(this.gameObject);
        }
    }
    void OnCollisionEnter2D(Collision2D coll){
        if (coll.gameObject.tag == "Player"){
            if(heart_counter.shield_status == true){
                heart_counter.shield_status = false;
            }else{
                heart_counter.health -= 1;
            }
        }
        Destroy(this.gameObject);
    }
}
