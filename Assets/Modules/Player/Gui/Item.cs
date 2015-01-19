using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public static class ItemList {
	public static Item empty = new Item ("(Empty)", 0, 0);
	public static Item CornSeed = new Item("Corn Seed", 1, 1);
	public static Item Corn = new Item("Corn", 1, 5);
}

public class Item {

	public string itemName = "";
	public int quantity = 1;
	public int sellPrice = 0;

	public Item(string name, int q, int p) {
		itemName = name;
		quantity = q;
		sellPrice = p;
	}

	public Item TakeOne() {
		if (quantity > 1) {
			return new Item(itemName, (quantity - 1), sellPrice);
		} else {
			return ItemList.empty;
		}
	}

	public Item GetOne() {
		return new Item(itemName, (quantity + 1), sellPrice);
	}

	public Item GetSome(int n) {
		return new Item(itemName, (quantity + n), sellPrice);
	}

}
