using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HotBar : MonoBehaviour {
	List<Item> slots = new List<Item>(8);
	public int selected = 0;
	private int slotHeight = Screen.height/10;
	private int slotWidth = Screen.width/10;
	private int targetX;
	private int currentX;

	// Use this for initialization
	void Start () {
		for (int i = 0; i < slots.Capacity; i++) {
			slots.Add(ItemList.empty);
		}
		slots[0] = ItemList.CornSeed;
		slots[0] = slots[0].GetSome(4);
		slots[1] = ItemList.Corn;

		targetX = selected*slotWidth;
		currentX = selected*slotWidth;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Alpha1)) { selected = 0;}
		else if(Input.GetKeyDown(KeyCode.Alpha2)) {selected = 1;}
		else if(Input.GetKeyDown(KeyCode.Alpha3)) {selected = 2;}
		else if(Input.GetKeyDown(KeyCode.Alpha4)) {selected = 3;}
		else if(Input.GetKeyDown(KeyCode.Alpha5)) {selected = 4;}
		else if(Input.GetKeyDown(KeyCode.Alpha6)) {selected = 5;}
		else if(Input.GetKeyDown(KeyCode.Alpha7)) {selected = 6;}
		else if(Input.GetKeyDown(KeyCode.Alpha8)) {selected = 7;}
		targetX = selected*slotWidth;
		currentX = GUIutils.IntLerp(currentX, targetX);
	}

	void OnGUI () {
		GUIutils.GUIDrawRect(new Rect(currentX, Screen.height-slotHeight, slotWidth, slotHeight), Color.gray);
		for (int i = 0; i < slots.Capacity; i++) {
			GUI.Box(new Rect(i*slotWidth, Screen.height-slotHeight, slotWidth, slotHeight), string.Concat(i+1, "\n", slots[i].itemName, "\n", slots[i].quantity));
		}
	}
}
