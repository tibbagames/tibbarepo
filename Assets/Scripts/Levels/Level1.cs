using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Level1 : Level {    
    public GameObject levelComponents;

    private enum LevelState { Play, End, Transition };
    private LevelState levelState = LevelState.Transition;
    private List<GameObject> EnemiesOnScreen;
    private int waveNumber = 1;
    private int stageNumber = 1;   
        
    override
    public void Build () {
        GameObject background_level1 = Instantiate(levelComponents.GetComponent<LevelComponents>().backgroundPrefab, new Vector2(0f, 0f), GetComponent<Transform>().rotation) as GameObject;
        background_level1.GetComponent<SpriteRenderer>().sprite = Resources.LoadAll<Sprite>("Items/backgrounds")[0];
        GameObject garbageBin = Instantiate(levelComponents.GetComponent<LevelComponents>().garbageBinPrefab, new Vector2(-6.5f, 0.6f), GetComponent<Transform>().rotation) as GameObject;
        garbageBin.layer = LayerMask.NameToLayer("NotFriendlyItems");
        GameObject sandBarrier1 = Instantiate(levelComponents.GetComponent<LevelComponents>().sandBarrierPrefab, new Vector2(1.55f, 1.7f), GetComponent<Transform>().rotation) as GameObject;
        sandBarrier1.layer = LayerMask.NameToLayer("NotFriendlyItems");
        GameObject sandBarrier2 = Instantiate(levelComponents.GetComponent<LevelComponents>().sandBarrierPrefab, new Vector2(7f, 1f), GetComponent<Transform>().rotation) as GameObject;
        sandBarrier2.layer = LayerMask.NameToLayer("NotFriendlyItems");
        GameObject woodBox1 = Instantiate(levelComponents.GetComponent<LevelComponents>().woodBoxPrefab, new Vector2(-3.0f, 1.2f), GetComponent<Transform>().rotation) as GameObject;
        woodBox1.layer = LayerMask.NameToLayer("NotFriendlyItems");
        GameObject tiresA1 = Instantiate(levelComponents.GetComponent<LevelComponents>().tiresAPrefab, new Vector2(-8.46f, -3.32f), GetComponent<Transform>().rotation) as GameObject;
        tiresA1.layer = LayerMask.NameToLayer("FriendlyItems");
        GameObject tiresB1 = Instantiate(levelComponents.GetComponent<LevelComponents>().tiresBPrefab, new Vector2(-7.65f, -3.35f), GetComponent<Transform>().rotation) as GameObject;
        tiresB1.layer = LayerMask.NameToLayer("FriendlyItems");
        GameObject tiresA2 = Instantiate(levelComponents.GetComponent<LevelComponents>().tiresAPrefab, new Vector2(-6.86f, -3.29f), GetComponent<Transform>().rotation) as GameObject;
        tiresA2.layer = LayerMask.NameToLayer("FriendlyItems");
        GameObject trafficSignB1 = Instantiate(levelComponents.GetComponent<LevelComponents>().trafficSignBPrefab, new Vector2(-5.54f, -3.32f), GetComponent<Transform>().rotation) as GameObject;
        trafficSignB1.layer = LayerMask.NameToLayer("FriendlyItems");
        GameObject trafficSignA1 = Instantiate(levelComponents.GetComponent<LevelComponents>().trafficSignAPrefab, new Vector2(-2.31f, -3.32f), GetComponent<Transform>().rotation) as GameObject;
        trafficSignA1.layer = LayerMask.NameToLayer("FriendlyItems");
        GameObject policeCar1 = Instantiate(levelComponents.GetComponent<LevelComponents>().policeCarPrefab, new Vector2(1.32f, -2.9f), GetComponent<Transform>().rotation) as GameObject;
        policeCar1.layer = LayerMask.NameToLayer("FriendlyItems");
        GameObject trafficSignA2 = Instantiate(levelComponents.GetComponent<LevelComponents>().trafficSignAPrefab, new Vector2(4.95f, -3.32f), GetComponent<Transform>().rotation) as GameObject;
        trafficSignA2.layer = LayerMask.NameToLayer("FriendlyItems");
        GameObject trafficSignB2 = Instantiate(levelComponents.GetComponent<LevelComponents>().trafficSignBPrefab, new Vector2(8.01f, -3.35f), GetComponent<Transform>().rotation) as GameObject;
        trafficSignB2.layer = LayerMask.NameToLayer("FriendlyItems");  
    }

    // Update is called once per frame
    override
    public void Update ()
    {
        switch (levelState)
        {
            case LevelState.Transition:
                switch (stageNumber)
                {
                    case 1:
                        switch (waveNumber)
                        {
                            case 1:
                                EnemiesOnScreen.Add(Instantiate(levelComponents.GetComponent<LevelComponents>().punkCommonPrefab, new Vector2(8.01f, -3.35f), GetComponent<Transform>().rotation) as GameObject);
                                EnemiesOnScreen.Add(Instantiate(levelComponents.GetComponent<LevelComponents>().punkCommonPrefab, new Vector2(8.01f, -3.35f), GetComponent<Transform>().rotation) as GameObject);
                                levelState = LevelState.Play;
                                break;
                            case 2:
                                EnemiesOnScreen.Add(Instantiate(levelComponents.GetComponent<LevelComponents>().punkCommonPrefab, new Vector2(8.01f, -3.35f), GetComponent<Transform>().rotation) as GameObject);
                                EnemiesOnScreen.Add(Instantiate(levelComponents.GetComponent<LevelComponents>().punkCommonPrefab, new Vector2(8.01f, -3.35f), GetComponent<Transform>().rotation) as GameObject);
                                EnemiesOnScreen.Add(Instantiate(levelComponents.GetComponent<LevelComponents>().punkCommonPrefab, new Vector2(8.01f, -3.35f), GetComponent<Transform>().rotation) as GameObject);
                                levelState = LevelState.Play;
                                break;
                            case 3:
                                EnemiesOnScreen.Add(Instantiate(levelComponents.GetComponent<LevelComponents>().punkCommonPrefab, new Vector2(8.01f, -3.35f), GetComponent<Transform>().rotation) as GameObject);
                                EnemiesOnScreen.Add(Instantiate(levelComponents.GetComponent<LevelComponents>().punkCommonPrefab, new Vector2(8.01f, -3.35f), GetComponent<Transform>().rotation) as GameObject);
                                EnemiesOnScreen.Add(Instantiate(levelComponents.GetComponent<LevelComponents>().punkCommonPrefab, new Vector2(8.01f, -3.35f), GetComponent<Transform>().rotation) as GameObject);
                                EnemiesOnScreen.Add(Instantiate(levelComponents.GetComponent<LevelComponents>().punkCommonPrefab, new Vector2(8.01f, -3.35f), GetComponent<Transform>().rotation) as GameObject);
                                levelState = LevelState.Play;
                                break;
                            case 4:
                                EnemiesOnScreen.Add(Instantiate(levelComponents.GetComponent<LevelComponents>().punkCommonPrefab, new Vector2(8.01f, -3.35f), GetComponent<Transform>().rotation) as GameObject);
                                EnemiesOnScreen.Add(Instantiate(levelComponents.GetComponent<LevelComponents>().punkCommonPrefab, new Vector2(8.01f, -3.35f), GetComponent<Transform>().rotation) as GameObject);
                                EnemiesOnScreen.Add(Instantiate(levelComponents.GetComponent<LevelComponents>().punkCommonPrefab, new Vector2(8.01f, -3.35f), GetComponent<Transform>().rotation) as GameObject);
                                EnemiesOnScreen.Add(Instantiate(levelComponents.GetComponent<LevelComponents>().punkCommonPrefab, new Vector2(8.01f, -3.35f), GetComponent<Transform>().rotation) as GameObject);
                                EnemiesOnScreen.Add(Instantiate(levelComponents.GetComponent<LevelComponents>().punkCommonPrefab, new Vector2(8.01f, -3.35f), GetComponent<Transform>().rotation) as GameObject);
                                levelState = LevelState.Play;
                                break;
                            case 5:
                                EnemiesOnScreen.Add(Instantiate(levelComponents.GetComponent<LevelComponents>().punkCommonPrefab, new Vector2(8.01f, -3.35f), GetComponent<Transform>().rotation) as GameObject);
                                EnemiesOnScreen.Add(Instantiate(levelComponents.GetComponent<LevelComponents>().punkCommonPrefab, new Vector2(8.01f, -3.35f), GetComponent<Transform>().rotation) as GameObject);
                                EnemiesOnScreen.Add(Instantiate(levelComponents.GetComponent<LevelComponents>().punkCommonPrefab, new Vector2(8.01f, -3.35f), GetComponent<Transform>().rotation) as GameObject);
                                EnemiesOnScreen.Add(Instantiate(levelComponents.GetComponent<LevelComponents>().punkCommonPrefab, new Vector2(8.01f, -3.35f), GetComponent<Transform>().rotation) as GameObject);
                                EnemiesOnScreen.Add(Instantiate(levelComponents.GetComponent<LevelComponents>().punkCommonPrefab, new Vector2(8.01f, -3.35f), GetComponent<Transform>().rotation) as GameObject);
                                EnemiesOnScreen.Add(Instantiate(levelComponents.GetComponent<LevelComponents>().punkCommonPrefab, new Vector2(8.01f, -3.35f), GetComponent<Transform>().rotation) as GameObject);
                                levelState = LevelState.Play;
                                break;
                        }
                        break;
                    case 2:
                        switch (waveNumber)
                        {
                            case 1:
                                EnemiesOnScreen.Add(Instantiate(levelComponents.GetComponent<LevelComponents>().punkCommonPrefab, new Vector2(8.01f, -3.35f), GetComponent<Transform>().rotation) as GameObject);
                                EnemiesOnScreen.Add(Instantiate(levelComponents.GetComponent<LevelComponents>().punkCommonPrefab, new Vector2(8.01f, -3.35f), GetComponent<Transform>().rotation) as GameObject);
                                levelState = LevelState.Play;
                                break;
                            case 2:
                                EnemiesOnScreen.Add(Instantiate(levelComponents.GetComponent<LevelComponents>().punkCommonPrefab, new Vector2(8.01f, -3.35f), GetComponent<Transform>().rotation) as GameObject);
                                EnemiesOnScreen.Add(Instantiate(levelComponents.GetComponent<LevelComponents>().punkCommonPrefab, new Vector2(8.01f, -3.35f), GetComponent<Transform>().rotation) as GameObject);
                                levelState = LevelState.Play;
                                break;
                            case 3:
                                EnemiesOnScreen.Add(Instantiate(levelComponents.GetComponent<LevelComponents>().punkCommonPrefab, new Vector2(8.01f, -3.35f), GetComponent<Transform>().rotation) as GameObject);
                                EnemiesOnScreen.Add(Instantiate(levelComponents.GetComponent<LevelComponents>().punkCommonPrefab, new Vector2(8.01f, -3.35f), GetComponent<Transform>().rotation) as GameObject);
                                levelState = LevelState.Play;
                                break;
                            case 4:
                                EnemiesOnScreen.Add(Instantiate(levelComponents.GetComponent<LevelComponents>().punkCommonPrefab, new Vector2(8.01f, -3.35f), GetComponent<Transform>().rotation) as GameObject);
                                EnemiesOnScreen.Add(Instantiate(levelComponents.GetComponent<LevelComponents>().punkCommonPrefab, new Vector2(8.01f, -3.35f), GetComponent<Transform>().rotation) as GameObject);
                                levelState = LevelState.Play;
                                break;
                            case 5:
                                EnemiesOnScreen.Add(Instantiate(levelComponents.GetComponent<LevelComponents>().punkCommonPrefab, new Vector2(8.01f, -3.35f), GetComponent<Transform>().rotation) as GameObject);
                                EnemiesOnScreen.Add(Instantiate(levelComponents.GetComponent<LevelComponents>().punkCommonPrefab, new Vector2(8.01f, -3.35f), GetComponent<Transform>().rotation) as GameObject);
                                levelState = LevelState.Play;
                                break;
                        }
                        break;
                    case 3:
                        switch (waveNumber)
                        {
                            case 1: break;
                            case 2: break;
                            case 3: break;
                            case 4: break;
                            case 5: break;
                        }
                        break;
                    case 4:
                        switch (waveNumber)
                        {
                            case 1: break;
                            case 2: break;
                            case 3: break;
                            case 4: break;
                            case 5: break;
                        }
                        break;
                    case 5:
                        switch (waveNumber)
                        {
                            case 1: break;
                            case 2: break;
                            case 3: break;
                            case 4: break;
                            case 5: break;
                        }
                        break;
                }
                break;
            case LevelState.Play:
                if (waveNumber != 5)
                {
                    if (EnemiesOnScreen.Count <= 1)
                    {
                        levelState = LevelState.Transition;
                        waveNumber++;
                    }
                }
                else
                {
                    if (EnemiesOnScreen.Count == 0)
                    {
                        levelState = LevelState.Transition;
                        stageNumber++;
                    }                    
                }
                break;
            case LevelState.End: break;
        }
    }
}
