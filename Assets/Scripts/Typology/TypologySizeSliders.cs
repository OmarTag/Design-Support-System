using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TypologySizeSliders : MonoBehaviour {
    public Text LengthText;
    public Text WidthText;
    


    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void changeLengthText(float value)
    {
        LengthText.text = "" + value;
       
    }
    public void changeWidthText(float value)
    {
        WidthText.text = "" + value;
    }
}
