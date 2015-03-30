using UnityEngine;
using System.Collections;

public class control : MonoBehaviour {
	public float speed;
	public float jump;
	public bool grounded;
	// Use this for initialization
	void Start () {
		
		jump = jump * 100;
	}
	
	// Update is called once per frame
	void Update () {
		
		
		
		if (GetComponent<Rigidbody2D>().velocity.y == 0) {
			grounded = true;
		} else {
			grounded = false;
		}
		
		if(Input.GetKey(KeyCode.D)){
			
			GetComponent<Rigidbody2D>().velocity = new Vector2(speed,GetComponent<Rigidbody2D>().velocity.y);
			this.transform.localScale = new Vector3(1,1,1);
		}else if(Input.GetKey(KeyCode.A)){
			
			GetComponent<Rigidbody2D>().velocity = new Vector2(-speed,GetComponent<Rigidbody2D>().velocity.y);
			this.transform.localScale = new Vector3(-1,1,1);;
			
		}else{
			
			GetComponent<Rigidbody2D>().velocity = new Vector2(0,GetComponent<Rigidbody2D>().velocity.y);
			
		}
		
		if(Input.GetKeyDown(KeyCode.W) && grounded == true){
			
			GetComponent<Rigidbody2D>().AddForce(new Vector2(GetComponent<Rigidbody2D>().velocity.x,jump));
			
		}



	}
}
