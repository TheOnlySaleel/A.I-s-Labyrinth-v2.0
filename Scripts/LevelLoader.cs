using UnityEngine;
using System.Collections;

public class LevelLoader : MonoBehaviour {

	public int nextLevel; //Number of the next scene/level to load;
	
	// Update is called once per frame
	void OnTriggerEnter (Collider col) {
		Application.LoadLevel(nextLevel);
	}
}
