using UnityEngine;
using System.Collections;

public class PlayerBehavior : MonoBehaviour {
	public Rigidbody selectedItem;
	public int throwSpeed = 1;
	public bool inPlot = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Use")) {
			Rigidbody plant;
			plant = Instantiate(selectedItem, 
			                    transform.position + (transform.forward * 2), 
			                    transform.rotation) as Rigidbody;
			plant.velocity = transform.TransformDirection (Vector3.forward * throwSpeed);
		}
	}


}
