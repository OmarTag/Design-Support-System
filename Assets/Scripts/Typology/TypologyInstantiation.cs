using UnityEngine;
using System.Collections;

public class TypologyInstantiation : MonoBehaviour {

   public  GameObject typologyPrefab;

    Vector3 screenPoint;
    Vector3 offset;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    public void InstantiateTypologyOnClick()

    {
        //screenPoint = Camera.main.WorldToScreenPoint(transform.position);
        //offset = transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
        //Instantiate(typologyPrefab);
        //typologyPrefab.transform.position = new Vector3(0, 0, 0) ;
        Debug.Log("Width From ButtonClick: " + PlayerPrefs.GetInt("TypologyWidth")*10);
        Debug.Log("Lenggth From ButtonClick: " + PlayerPrefs.GetInt("TypologyLength")*10);
        typologyPrefab.transform.position = new Vector3(0, 0, 0);
        typologyPrefab.transform.localScale = new Vector3(PlayerPrefs.GetInt("TypologyWidth") * 10, 0.3f, PlayerPrefs.GetInt("TypologyLength") * 10);
        Instantiate(typologyPrefab);
        //typologyPrefab.transform.localScale = new Vector3(PlayerPrefs.GetInt("TypologyWidth"), 0.3f, PlayerPrefs.GetInt("TypologyLength"));
    }
}
