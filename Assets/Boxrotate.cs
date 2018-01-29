using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boxrotate : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown() {
		transform.Rotate (Vector3.right, 20f);
	}
}
