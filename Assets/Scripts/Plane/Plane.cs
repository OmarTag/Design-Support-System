using UnityEngine;
using System.Collections;

public class Plane : MonoBehaviour {
    
	// Use this for initialization
	void Start () {

        Vector3 planeSize = new Vector3(PlayerPrefs.GetInt("PlaneWidth"),1, PlayerPrefs.GetInt("PlaneLength"));
        this.transform.localScale =planeSize;
        Debug.Log(planeSize);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
