using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {
	private Vector3 offset;
	private Vector3 depth;

	// Update is called once per frame
	private void OnMouseDown()
	{
		depth=Camera.main.WorldToScreenPoint(transform.position);
		Vector3 mousePosition=Input.mousePosition;
		mousePosition=new Vector3(mousePosition.x, mousePosition.y,depth .z );
		offset = Camera.main.ScreenToWorldPoint(mousePosition) - transform.position;
		GetComponent<Rigidbody>().isKinematic = true;
	}

	private void OnMouseDrag () 
	{
	Vector3 mousePosition=Input.mousePosition;
		mousePosition = new Vector3(mousePosition.x,mousePosition.y,depth .z );
	transform.position=Camera.main.ScreenToWorldPoint(mousePosition)-offset;
	}

	private void OnMouseUp()
	{
		GetComponent<Rigidbody>().isKinematic = false;
	}

}
