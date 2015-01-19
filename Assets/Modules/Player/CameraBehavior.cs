using UnityEngine;
using System.Collections;

public class CameraBehavior : MonoBehaviour {
	private RaycastHit hit;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Debug.DrawRay (transform.position, transform.forward * 5f, Color.cyan);
		if (Physics.Raycast(transform.position, transform.forward, out hit, 5f)) {
			if (hit.collider.gameObject.transform.GetComponentInParent<VisualLabel>() != null) {
				VisualLabel label = hit.collider.gameObject.transform.GetComponentInParent<VisualLabel>();
				label.setVisible();
			}
		}
	}

	void OnGUI() {
		GUI.Box(new Rect(Screen.width/2-1, Screen.height/2-1, 2, 2),"");
	}
}
