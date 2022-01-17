using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item_behaviour_multiplayer : MonoBehaviour
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
        if (coll.gameObject.tag == "Player1"){
            if(this.gameObject.tag == "Heart"){
                heartcounter2_player1.health += 1;
            }
            if(this.gameObject.tag == "Shield"){
                heartcounter2_player1.shield_status = true;
            }
        }else if(coll.gameObject.tag == "Player2"){
            if(this.gameObject.tag == "Heart"){
                heartcounter2_player2.health += 1;
            }
            if(this.gameObject.tag == "Shield"){
                heartcounter2_player2.shield_status = true;
            }
        }
        Destroy(this.gameObject);
    }
}
