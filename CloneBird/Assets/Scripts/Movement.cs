using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public float movementSpeed;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        move();
    }

    void move()
    {
        transform.Translate(Vector3.left * movementSpeed * Time.deltaTime);
    }
}
