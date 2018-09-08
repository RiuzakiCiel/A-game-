using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementMain : MonoBehaviour {

    public float movementSpeed = 6;
    bool canJump = true; 
    public Vector2 jumpHight;

	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey(KeyCode.D)) { //Walk right
            Vector3 tmpPos = transform.position;
            tmpPos.x += movementSpeed * Time.deltaTime;
            transform.position = tmpPos;
        }
        if (Input.GetKey(KeyCode.A)) { //Walk left
            Vector3 tmpPos = transform.position;
            tmpPos.x -= movementSpeed * Time.deltaTime;
            transform.position = tmpPos;
        }
        if (Input.GetKeyDown(KeyCode.Space) && canJump == true) { //Jumping
            GetComponent<Rigidbody2D>().AddForce(jumpHight * Time.deltaTime * 10, ForceMode2D.Impulse);
        }
    }

    void OnCollisionEnter2D(Collision2D theCollision) { //Check if the player is on the ground
        if (theCollision.gameObject.tag == "floor") {
            canJump = true;
        }
    }

    void OnCollisionExit2D(Collision2D theCollision) {
        if (theCollision.gameObject.tag == "floor") {
            canJump = false;
        }
    }
}
