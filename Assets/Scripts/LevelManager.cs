using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LevelManager : MonoBehaviour {

    private enum enemy { punkCommon, punkGranader, punkMachineGunner, punkShieldCommon, punkShieldGranader, punkShieldMachineGunner };
       
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
}