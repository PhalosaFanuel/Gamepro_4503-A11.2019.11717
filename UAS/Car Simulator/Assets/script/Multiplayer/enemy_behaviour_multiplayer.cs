using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_behaviour_multiplayer : MonoBehaviour
{
    public Vector2 veloc = new Vector2(0,-5);
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D> ().velocity = veloc;
        int num = Random.Range(0,2);
        if (num == 0){
            transform.position = new Vector3 (Random.Range(-4,0),10, transform.position.z);
            }
        else{
            transform.position = new Vector3 (Random.Range(4,0),10, transform.position.z);
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
        if (coll.gameObject.tag == "Player1"){
            if(heartcounter2_player1.shield_status == true){
                heartcounter2_player1.shield_status = false;
            }else{
                heartcounter2_player1.health -= 1;
            }
        }else if (coll.gameObject.tag == "Player2"){
            if(heartcounter2_player2.shield_status == true){
                heartcounter2_player2.shield_status = false;
            }else{
                heartcounter2_player2.health -= 1;
            }
            
        }
        Destroy(this.gameObject);
    }
}
