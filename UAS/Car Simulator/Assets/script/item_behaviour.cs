using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item_behaviour : MonoBehaviour
{
    public Vector2 veloc = new Vector2(0,-5);
    void Start()
    {
        GetComponent<Rigidbody2D> ().velocity = veloc;

        transform.position = new Vector3 (Random.Range(-7,7),10, transform.position.z);
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
            if(this.gameObject.tag == "Heart"){
                heart_counter.health += 1;
            }
            if(this.gameObject.tag == "Shield"){
                heart_counter.shield_status = true;
            }
            if(this.gameObject.tag == "Gasoline"){
                FuelCounter.timer = FuelCounter.timer + 30;
            }
            Destroy(this.gameObject);
        }
        
    }
}
