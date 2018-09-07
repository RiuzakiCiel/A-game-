using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementMain : MonoBehaviour {

    float movementSpeed = 4000;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        var y = transform.position.y;
        var x = transform.position.x;

		if (Input.GetKeyDown(KeyCode.D))
        {
            x += movementSpeed;
            Debug.Log("Why doesn't it move");
        }
	}
}
