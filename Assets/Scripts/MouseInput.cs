using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseInput : MonoBehaviour
{
	//Public Float speed
	public float speed = 50.0f;

	void Update()
	{

	}
	void OnMouseDrag()
	{
		////TRY:
		//// Get the horizontal and vertical axis.
		//// By default they are mapped to the arrow keys.
		//// The value is in the range -1 to 1
		//float transX = Input.GetAxis("Mouse X") * speed;
		//float transZ = Input.GetAxis("Mouse Y") * speed;

		//// Make it move 10 meters per second instead of 10 meters per frame...
		//transX *= Time.deltaTime;
		//transZ *= Time.deltaTime;

		//// Move translation along the object's x and z-axis
		//transform.Translate(transX, 0, transZ);

		//USE:
		//Mouse in is screen space, not world space!
		//Get new Z Distance from Camera to Object in the Screen to select object
		float distance_to_screen = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;

		//Get new Vector3 for Mouse Input X,Y (Unused), Z(Camera-Object Screen space distance variable)
		Vector3 pos_move = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance_to_screen));

		//Object transform is Vector3 of Mouse Input X and Screen Move Z, Y is Static
		transform.position = new Vector3(pos_move.x, transform.position.y, pos_move.z);

		//From: https://answers.unity.com/questions/12322/drag-gameobject-with-mouse.html
		//Better Version https://www.patreon.com/posts/unity-3d-drag-22917454

	}
}

//From: https://docs.unity3d.com/ScriptReference/Input.GetAxis.html
