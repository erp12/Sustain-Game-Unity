using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlantStageBehavior : MonoBehaviour {
	public string cropType;
	public PlantStageBehavior nextStage;
	public int secondsUntilNextStage;
	public List<GameObject> dropOnHarvest;
	public GameObject particles;

	// Use this for initialization
	void Start () {
		//Particle System to indicate plant has been planted or has grown
		GameObject p = (GameObject)Instantiate(particles, transform.position, Quaternion.identity);
		p.particleSystem.Play ();
		Destroy (p, 3f);

		if (nextStage != null)
			Invoke ("SpawnNextStage", secondsUntilNextStage);
	}
	
	// Update is called once per frame
	void Update () {
	}

	void SpawnNextStage () {
		Instantiate(nextStage, transform.position + new Vector3(0f, 0.1f, 0f), Quaternion.identity);
		Destroy (gameObject);
	}



}
