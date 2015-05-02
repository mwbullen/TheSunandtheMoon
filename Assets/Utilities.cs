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

	public Vector3 getRandomPointInObject(GameObject g) {
		Renderer r =  g.GetComponent<Renderer>();
		float x = Random.Range (r.bounds.min.x, r.bounds.max.x);
		float y = Random.Range (r.bounds.min.y, r.bounds.max.y);

		return new Vector3(x, y,0);
	}

}
