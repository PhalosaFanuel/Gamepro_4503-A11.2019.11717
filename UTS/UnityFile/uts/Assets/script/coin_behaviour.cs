using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin_behaviour : MonoBehaviour
{
    public Vector2 veloc = new Vector2(0,-5);
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D> ().velocity = veloc;
        // float range = 7.5f;
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
        if(coll.gameObject.tag == "Player"){
            scorescript.scoreValue += 1;
            Destroy(this.gameObject);
        }
    }
}
