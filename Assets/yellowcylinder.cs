using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yellowcylinder : MonoBehaviour {
	Vector3 originalPos;
	// Use this for initialization
	void Start () {
		originalPos = gameObject.transform.position;
	}

	// Update is called once per frame
	void Update () {

	}
	void OnMouseOver ()
	{
		gameObject.transform.position = originalPos;
	}
}
