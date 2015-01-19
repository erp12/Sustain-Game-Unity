using UnityEngine;
using System.Collections;

public class PlayerBehavior : MonoBehaviour {
	public Rigidbody plotItem;
	public Rigidbody notPlotItem;
	public int throwSpeed = 1;
	public bool inPlot = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Use")) {
			if (inPlot) {
				Rigidbody plant;
				plant = Instantiate(plotItem, 
				                    transform.position + (transform.forward * 2), 
				                    transform.rotation) as Rigidbody;
				plant.velocity = transform.TransformDirection (Vector3.forward * throwSpeed);
			} else {
				Rigidbody seed;
				seed = Instantiate(notPlotItem, 
				                    transform.position + (transform.forward * 2), 
				                    transform.rotation) as Rigidbody;
				seed.velocity = transform.TransformDirection (Vector3.forward * throwSpeed);
			}
		}

	}


}
