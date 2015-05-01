using UnityEngine;
using System.Collections;

public class Utilities : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public Vector2 makeVector2(float x, float y) {
		return new Vector2 (x, y);

	}

	public Vector2 multiplyVector2(Vector2 inputVector, float speed) {
		return inputVector * speed;
	}
}
