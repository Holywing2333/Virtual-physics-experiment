using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderMove : MonoBehaviour
{
	public float cameraMoveSpeed;
	public float camerZoomSpeed;
	public float borderWidth = 50f;
	public Vector2 xClamp;
	public Vector2 yClamp;
	public Vector2 zClamp;
	private void Update()
	{
		Vector2 mousePos = Input.mousePosition;
		//Move Right
			if (mousePos.x > Screen.width - borderWidth)
			{
				transform.Translate(transform.right * cameraMoveSpeed * Time.deltaTime);
			}
			//Move Left
			if (mousePos.x < borderWidth)
			{
				transform.Translate(-transform.right * cameraMoveSpeed * Time.deltaTime);
			}
			//Move Up
			if (mousePos.y > Screen.height - borderWidth)
			{
				transform.Translate(-transform.forward * cameraMoveSpeed * Time.deltaTime);
			}
			//Move Down
			if (mousePos.y < borderWidth)
			{
				transform.Translate(transform.forward * cameraMoveSpeed * Time.deltaTime);
			}
		float scrollWheel = Input.GetAxis("Mouse ScrollWheel");
		transform.Translate(transform.up * scrollWheel * camerZoomSpeed * Time.deltaTime);
		Vector3 CPos = transform.position;
		CPos .x=Mathf .Clamp (CPos.x,xClamp.x,xClamp .y );
		CPos .y=Mathf .Clamp (CPos.y,yClamp .x,yClamp .y );
		CPos .z=Mathf .Clamp (CPos.z,zClamp.x,zClamp .y );
		transform.position = CPos;
	}
}
