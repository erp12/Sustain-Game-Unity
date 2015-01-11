using UnityEngine;
using System.Collections;

public class PlotTriggerBehavior : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag.Equals ("Player")) {
			PlayerBehavior p = other.gameObject.GetComponent<PlayerBehavior>();
			p.inPlot = true;
		}
	}

	void OnTriggerExit(Collider other) {
		if (other.gameObject.tag.Equals ("Player")) {
			PlayerBehavior p = other.gameObject.GetComponent<PlayerBehavior>();
			p.inPlot = false;
		}
	}
}
