using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	public LevelManager levelScript;

	private int level = 1;

	// Use this for initialization
	void Awake () {
		levelScript = GetComponent<LevelManager> ();
		InitGame ();
	}

	void InitGame() 
	{
		levelScript.LevelSetup (level); 
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}