using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotater : MonoBehaviour {

  float rotation;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
   // var r = transform.rotation;
    rotation += Time.deltaTime * 100;
    transform.rotation = Quaternion.Euler(rotation, 0, -rotation);

	}
}
