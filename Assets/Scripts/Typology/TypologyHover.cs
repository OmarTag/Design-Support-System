using UnityEngine;
using System.Collections;

public class TypologyHover : MonoBehaviour {
    

    // Use this for initialization
    void Start () {
        

    }
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnMouseOver()
    {
        this.gameObject.GetComponent<Renderer>().material.color = Color.grey;
    }

    void OnMouseExit()
    {
        
        this.gameObject.GetComponent<Renderer>().material.color =Color.white;
    }
}
