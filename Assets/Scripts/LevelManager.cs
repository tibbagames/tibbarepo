using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LevelManager : MonoBehaviour {

    private enum enemy { punkCommon, punkGranader, punkMachineGunner, punkShieldCommon, punkShieldGranader, punkShieldMachineGunner };
    
    //Begin Enemies
    public GameObject punkCommonPrefab;
    public GameObject punkGranaderPrefab;

	//public GameObject backgroundPrefab;
	//public GameObject garbageBinPrefab;
	//public GameObject sandBarrierPrefab;
	//public GameObject woodBoxPrefab;
	//public GameObject binBPrefab;
	//public GameObject cabinPrefab;
	//public GameObject policeCarPrefab;
	//public GameObject tiresAPrefab;
	//public GameObject tiresBPrefab;
	//public GameObject trafficSignAPrefab;
	//public GameObject trafficSignBPrefab;
    private int stageNumber = 1;
    private int waveNumber = 1;    
    public Level currentLevel;

	public void LevelSetup(int levelNumber) 
	{        
		switch (levelNumber) 
		{
		case 1:            
            currentLevel = GetComponent<Level1> ();            
            currentLevel.Build();                
            break;
		case 2:
            currentLevel = GetComponent<Level2> ();            
            currentLevel.Build();
            break;
		case 3:
			break;
		case 4:
			break;
		case 5:
			break;
		case 6:
			break;
		case 7:
			break;
		case 8:
			break;
		case 9:
			break;
		case 10:
			break;
		}	
	}

    public void EnemiesWave() //VER UPDATE 
    {
        /*
        switch (currentLevel)
        {
            case 1:
                switch (stageNumber)
                {
                    case 1:
                        switch (waveNumber)
                        {
                            case 1:
                                Enemies.Add(Instantiate(punkCommonPrefab, new Vector2(0f, 0f), GetComponent<Transform>().rotation) as GameObject);
                                Enemies.Add(Instantiate(punkCommonPrefab, new Vector2(0f, 0f), GetComponent<Transform>().rotation) as GameObject);
                                Enemies.Add(Instantiate(punkCommonPrefab, new Vector2(0f, 0f), GetComponent<Transform>().rotation) as GameObject);
                                break;
                            case 2:
                                Enemies.Add(Instantiate(punkCommonPrefab, new Vector2(0f, 0f), GetComponent<Transform>().rotation) as GameObject);
                                Enemies.Add(Instantiate(punkCommonPrefab, new Vector2(0f, 0f), GetComponent<Transform>().rotation) as GameObject);
                                Enemies.Add(Instantiate(punkCommonPrefab, new Vector2(0f, 0f), GetComponent<Transform>().rotation) as GameObject);
                                Enemies.Add(Instantiate(punkGranaderPrefab, new Vector2(0f, 0f), GetComponent<Transform>().rotation) as GameObject);
                                Enemies.Add(Instantiate(punkGranaderPrefab, new Vector2(0f, 0f), GetComponent<Transform>().rotation) as GameObject);
                                break;
                            case 3:
                                Enemies.Add(Instantiate(punkCommonPrefab, new Vector2(0f, 0f), GetComponent<Transform>().rotation) as GameObject);
                                Enemies.Add(Instantiate(punkCommonPrefab, new Vector2(0f, 0f), GetComponent<Transform>().rotation) as GameObject);
                                Enemies.Add(Instantiate(punkCommonPrefab, new Vector2(0f, 0f), GetComponent<Transform>().rotation) as GameObject);
                                Enemies.Add(Instantiate(punkCommonPrefab, new Vector2(0f, 0f), GetComponent<Transform>().rotation) as GameObject);
                                Enemies.Add(Instantiate(punkGranaderPrefab, new Vector2(0f, 0f), GetComponent<Transform>().rotation) as GameObject);
                                Enemies.Add(Instantiate(punkGranaderPrefab, new Vector2(0f, 0f), GetComponent<Transform>().rotation) as GameObject);
                                Enemies.Add(Instantiate(punkGranaderPrefab, new Vector2(0f, 0f), GetComponent<Transform>().rotation) as GameObject);
                                break;
                        }
                        break;                        
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                }
                break;
        }*/
    }
}