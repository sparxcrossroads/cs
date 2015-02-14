using UnityEngine;
using System.Collections;

public class cubemoving : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	public int movedSpeed=10;
	public int rotation=20;

	public bool isUP=false;
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.W)) 
		{
			transform.Translate (Vector3.forward * Time.deltaTime * movedSpeed);				
		}
		else if(Input.GetKey(KeyCode.S))
		{
			transform.Translate (Vector3.back * Time.deltaTime * movedSpeed);				
		}
	    if(Input.GetKey(KeyCode.A))
		{
			transform.Rotate(Vector3.down*Time.deltaTime*rotation,Space.World);
		}
		else if(Input.GetKey(KeyCode.D))
		{
			transform.Rotate(Vector3.up*Time.deltaTime*rotation,Space.World);
		}
		if (isUP)
		{
			transform.Translate(Vector3.up*Time.deltaTime*movedSpeed*movedSpeed);
		}
	}
}
