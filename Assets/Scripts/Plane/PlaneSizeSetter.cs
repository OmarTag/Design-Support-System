using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlaneSizeSetter : MonoBehaviour {
    public Slider LengthSlider;
    public Slider WidthSlider;
    public GameObject Plane;
    public Text finalPlaneSize;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 planeSize = new Vector3(WidthSlider.value/10, 1, LengthSlider.value/10);
        Plane.transform.localScale = planeSize;
        finalPlaneSize.text = planeSize.x*10 + " X " + planeSize.z*10;
            
    }
    public void setPlaneSize()
    {
        Vector3 planeSize = new Vector3(WidthSlider.value/10, 1, LengthSlider.value/10);
        PlayerPrefs.SetInt("PlaneLength", Mathf.RoundToInt(planeSize.z));
        PlayerPrefs.SetInt("PlaneWidth", Mathf.RoundToInt(planeSize.x));
        Application.LoadLevel(1);
    }

}
