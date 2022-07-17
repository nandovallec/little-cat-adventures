using UnityEngine;
using System.Collections;

public class RotateObject : MonoBehaviour {
	
	public float vitesseRotation = 3.0f;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.Rotate(Vector3.up * vitesseRotation * Time.deltaTime);
	}
}
