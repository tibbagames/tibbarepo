using UnityEngine;
using System.Collections;
using System.Collections.Generic;

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
    //Enemy Stage 1
    private List<GameObject> Enemies_Stage1_Wave1;
    private List<GameObject> Enemies_Stage1_Wave2;
    private List<GameObject> Enemies_Stage1_Wave3;
    private List<GameObject> Enemies_Stage1_Wave4;
    private List<GameObject> Enemies_Stage1_Wave5;
    //Enemy Stage 2
    private List<GameObject> Enemies_Stage2_Wave1;
    private List<GameObject> Enemies_Stage2_Wave2;
    private List<GameObject> Enemies_Stage2_Wave3;
    private List<GameObject> Enemies_Stage2_Wave4;
    private List<GameObject> Enemies_Stage2_Wave5;
    //Enemy Stage 3
    private List<GameObject> Enemies_Stage3_Wave1;
    private List<GameObject> Enemies_Stage3_Wave2;
    private List<GameObject> Enemies_Stage3_Wave3;
    private List<GameObject> Enemies_Stage3_Wave4;
    private List<GameObject> Enemies_Stage3_Wave5;
    //Enemy Stage 4
    private List<GameObject> Enemies_Stage4_Wave1;
    private List<GameObject> Enemies_Stage4_Wave2;
    private List<GameObject> Enemies_Stage4_Wave3;
    private List<GameObject> Enemies_Stage4_Wave4;
    private List<GameObject> Enemies_Stage4_Wave5;
    //Enemy Stage 5
    private List<GameObject> Enemies_Stage5_Wave1;
    private List<GameObject> Enemies_Stage5_Wave2;
    private List<GameObject> Enemies_Stage5_Wave3;
    private List<GameObject> Enemies_Stage5_Wave4;
    private List<GameObject> Enemies_Stage5_Wave5;

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
