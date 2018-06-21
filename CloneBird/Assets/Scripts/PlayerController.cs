using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float flightPower;
    private Rigidbody2D rigidBody;
    public bool gameStarted;
    public bool gameEnded;

	// Use this for initialization
	void Start () {
        rigidBody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1") && !gameEnded)
        {
            if (!gameStarted)
            {
                rigidBody.gravityScale = 1;
                gameStarted = true;
            }
            Fly();
        }
	}

    void Fly()
    {
        rigidBody.velocity = Vector2.zero;
        rigidBody.AddForce(new Vector2(0,flightPower));

    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "DeathZone")
        {
            gameEnded = true;
        }

    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.tag == "DeathZone")
        {
            gameEnded = true;
        }

    }

}
