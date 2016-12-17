using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public GameObject backgroundPrefab;
	public GameObject garbageBinPrefab;
	public GameObject sandBarrierPrefab;
	public GameObject woodBoxPrefab;
	public GameObject binBPrefab;
	public GameObject cabinPrefab;
	public GameObject policeCarPrefab;
	public GameObject tiresAPrefab;
	public GameObject tiresBPrefab;
	public GameObject trafficSignAPrefab;
	public GameObject trafficSignBPrefab;

	public void LevelSetup(int levelNumber) 
	{
		switch (levelNumber) 
		{
		case 1:
			GameObject background_level1 = Instantiate (backgroundPrefab, new Vector2 (0f, 0f), GetComponent<Transform> ().rotation) as GameObject;
			background_level1.GetComponent<SpriteRenderer> ().sprite = Resources.LoadAll<Sprite>("Items/backgrounds")[0];
			GameObject garbageBin = Instantiate (garbageBinPrefab, new Vector2 (-6.5f, 0.1f), GetComponent<Transform> ().rotation) as GameObject;
			garbageBin.layer = LayerMask.NameToLayer ("NotFriendlyItems");
			GameObject sandBarrier1 = Instantiate (sandBarrierPrefab, new Vector2 (1.55f, 1.7f), GetComponent<Transform> ().rotation) as GameObject;
			sandBarrier1.layer = LayerMask.NameToLayer ("NotFriendlyItems");
			GameObject sandBarrier2 = Instantiate (sandBarrierPrefab, new Vector2 (7f, 0.6f), GetComponent<Transform> ().rotation) as GameObject;
			sandBarrier2.layer = LayerMask.NameToLayer ("NotFriendlyItems");
			GameObject woodBox1 = Instantiate (woodBoxPrefab, new Vector2 (-3.6f, -1.43f), GetComponent<Transform> ().rotation) as GameObject;
			woodBox1.layer = LayerMask.NameToLayer ("NotFriendlyItems");
			GameObject woodBox2 = Instantiate (woodBoxPrefab, new Vector2 (3.56f, -0.38f), GetComponent<Transform> ().rotation) as GameObject;
			woodBox2.layer = LayerMask.NameToLayer ("NotFriendlyItems");
			GameObject tiresA1 = Instantiate (tiresAPrefab, new Vector2 (-8.46f, -3.32f), GetComponent<Transform> ().rotation) as GameObject;
			tiresA1.layer = LayerMask.NameToLayer ("FriendlyItems");
			GameObject tiresB1 = Instantiate (tiresBPrefab, new Vector2 (-7.65f, -3.35f), GetComponent<Transform> ().rotation) as GameObject;
			tiresB1.layer = LayerMask.NameToLayer ("FriendlyItems");
			GameObject tiresA2 = Instantiate (tiresAPrefab, new Vector2 (-6.86f, -3.29f), GetComponent<Transform> ().rotation) as GameObject;
			tiresA2.layer = LayerMask.NameToLayer ("FriendlyItems");
			GameObject trafficSignB1 = Instantiate (trafficSignBPrefab, new Vector2 (-5.54f, -3.32f), GetComponent<Transform> ().rotation) as GameObject;
			trafficSignB1.layer = LayerMask.NameToLayer ("FriendlyItems");
			GameObject trafficSignA1 = Instantiate (trafficSignAPrefab, new Vector2 (-2.31f, -3.32f), GetComponent<Transform> ().rotation) as GameObject;
			trafficSignA1.layer = LayerMask.NameToLayer ("FriendlyItems");
			GameObject policeCar1 = Instantiate (policeCarPrefab, new Vector2 (1.32f, -2.9f), GetComponent<Transform> ().rotation) as GameObject;
			policeCar1.layer = LayerMask.NameToLayer ("FriendlyItems");
			GameObject trafficSignA2 = Instantiate (trafficSignAPrefab, new Vector2 (4.95f, -3.32f), GetComponent<Transform> ().rotation) as GameObject;
			trafficSignA2.layer = LayerMask.NameToLayer ("FriendlyItems");
			GameObject trafficSignB2 = Instantiate (trafficSignBPrefab, new Vector2 (8.01f, -3.35f), GetComponent<Transform> ().rotation) as GameObject;
			trafficSignB2.layer = LayerMask.NameToLayer ("FriendlyItems");
			break;		
		case 2:
            GameObject background_level2 = Instantiate(backgroundPrefab, new Vector2(0f, 0f), GetComponent<Transform>().rotation) as GameObject;
            background_level2.GetComponent<SpriteRenderer>().sprite = Resources.LoadAll<Sprite>("Items/backgrounds")[1];
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