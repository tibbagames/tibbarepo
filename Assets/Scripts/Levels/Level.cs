using UnityEngine;
using System.Collections;

public class Level : MonoBehaviour {
    
    // Use this for initialization
    public virtual void Build () { /*Class overrided by de current level class*/ }
	
	// Update is called once per frame
	public virtual void Update () { /*Class overrided by de current level class*/ }
}
