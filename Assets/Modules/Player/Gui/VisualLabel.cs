using UnityEngine;
using System.Collections;

public class VisualLabel : MonoBehaviour {

	public bool visible;
	public string label;
	public string status;
	public Color statusColor;
	private Vector3 ScreenPos;
	private GUIStyle GUIlabel;
	private GUIStyle GUIstatus;

	// Use this for initialization
	void Start () {
		GUIlabel = new GUIStyle ();
		GUIstatus = new GUIStyle ();
		GUIlabel.normal.textColor = Color.white;
		GUIlabel.alignment = TextAnchor.UpperCenter;

		GUIstatus.normal.textColor = statusColor;
		GUIstatus.alignment = TextAnchor.UpperCenter;
		GUIstatus.fontStyle = FontStyle.Bold;
		Texture2D texture = new Texture2D(1, 1);
		Color boxBGcolor = Color.black;
		boxBGcolor.a = 0.5F;
		texture.SetPixel(0,0,boxBGcolor);
		texture.Apply ();
		GUIlabel.normal.background = texture;
	}
	
	// Update is called once per frame
	void Update () {
		ScreenPos = Camera.main.WorldToScreenPoint (transform.position);
		ScreenPos.y = (Screen.height - ScreenPos.y) - 80;
		ScreenPos.x = ScreenPos.x - 60;
	}

	void OnGUI () {
		if (visible) {

			GUI.Box(new Rect(ScreenPos.x, ScreenPos.y, 120, 40), label, GUIlabel);
			GUI.Label(new Rect(ScreenPos.x, ScreenPos.y+20, 120, 20), status, GUIstatus);
		}
	}
}
