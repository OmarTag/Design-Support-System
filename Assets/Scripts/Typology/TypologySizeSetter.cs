using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TypologySizeSetter : MonoBehaviour {
    public Slider LengthSlider;
    public Slider WidthSlider;
    //public GameObject Typology;
    public Text finalTypologySize;
    public Button addTypologyButton;
    public GameObject typologyPanel;

    // Use this for initialization
    void Start()
    {
        //set the slider values on initialiaztion of the typology 
        setSliderRangeAccordingtoDensity(PlayerPrefs.GetInt("DensityLevel"));
        //typology add button 

    }

    // Update is called once per frame
    void Update()
    {
        //Typology Display
        //Vector3 typologySize = new Vector3(WidthSlider.value/10, 1, LengthSlider.value/10);
        //Typology.transform.localScale = typologySize;
        //finalTypologySize.text = typologySize.x*10 + " X " + typologySize.z*10;
            
    }
    //onButtonClick method to finalize the typology size
    public void setTypologySize()
    {
        Vector3 typologySize = new Vector3(WidthSlider.value / 10, 1, LengthSlider.value / 10);
        PlayerPrefs.SetInt("TypologyLength", Mathf.RoundToInt(typologySize.z));
        PlayerPrefs.SetInt("TypologyWidth", Mathf.RoundToInt(typologySize.x));
        Debug.Log("Typology Setter Width:" + PlayerPrefs.GetInt("TypologyWidth"));
        Debug.Log("Typology Setter Length:" + PlayerPrefs.GetInt("TypologyLength"));
        typologyPanel.SetActive(false);
     

    }

    public void setSliderRangeAccordingtoDensity(int densityLevel/*1 medium--2 large)*/)
    {
        if(densityLevel==1)
        {
            LengthSlider.minValue = 10;
            LengthSlider.maxValue =40;

            WidthSlider.minValue=10;
            WidthSlider.maxValue=30;
        }
        if (densityLevel == 2)
        {
            LengthSlider.minValue = 10;
            LengthSlider.maxValue = 60;

            WidthSlider.minValue = 10;
            WidthSlider.maxValue = 40;

        }
    
    }

}
