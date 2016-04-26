using UnityEngine;
using System.Collections;

public class Sphere : MonoBehaviour {
	
	public float speed;

	// Use this for initialization
	void Start () {
		speed = 0.06F;
	}
	
	// Update is called once per frame
	void Update () {
		
		float leftRight = Input.GetAxis("Horizontal");
		float upDown = Input.GetAxis("Vertical");
		
		//Debug.Log("leftRight: " + leftRight);
		
		transform.Translate(Vector3.right*leftRight*speed,Space.World);
		transform.Translate(Vector3.up*upDown*speed, Space.World);
	
	}
}
