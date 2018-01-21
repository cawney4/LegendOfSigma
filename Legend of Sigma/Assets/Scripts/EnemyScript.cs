using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {

    private Vector3 speed;

	// Use this for initialization
	void Start () {
        IntRange ir = new IntRange(-1, 1);
        speed = new Vector3(ir.Random, ir.Random, 0);
        while (speed.magnitude == 0)
        {
            speed = new Vector3(ir.Random, ir.Random, 0);
        }
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        //gameObject.GetComponent<Rigidbody2D>().AddForce(speed * Time.deltaTime);
        gameObject.transform.Translate(speed * Time.deltaTime);

    }

    void OnCollisionEnter2D(Collision2D other)
    {
        
        if (other.gameObject.tag == "Player")
        {
            CharacterScript ps = other.gameObject.GetComponent<CharacterScript>();
            ps.hurt(5);
        } else
        {
            speed = -speed;
        }

    }
}
