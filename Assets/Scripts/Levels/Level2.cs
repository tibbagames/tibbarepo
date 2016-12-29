using UnityEngine;
using System.Collections;

public class Level2 : Level {
    
    public GameObject backgroundPrefab;
    /*
    public GameObject garbageBinPrefab;
    public GameObject sandBarrierPrefab;
    public GameObject woodBoxPrefab;
    public GameObject binBPrefab;
    public GameObject cabinPrefab;
    public GameObject policeCarPrefab;
    public GameObject tiresAPrefab;
    public GameObject tiresBPrefab;
    public GameObject trafficSignAPrefab;
    public GameObject trafficSignBPrefab;*/

    override
    public void Build () {
        Debug.Log("Build");
        GameObject background_level2 = Instantiate(backgroundPrefab, new Vector2(0f, 0f), GetComponent<Transform>().rotation) as GameObject;
        background_level2.GetComponent<SpriteRenderer>().sprite = Resources.LoadAll<Sprite>("Items/backgrounds")[1];
    }

    // Update is called once per frame
    override
    public void Update () {
	
	}
}
