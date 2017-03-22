using UnityEngine;
using System.Collections;

public class Density : MonoBehaviour
{

    public GameObject densityCanvas;
   public GameObject typologySizeSetterClass;
    public static int densityValue;

    public GameObject typologyPanel;
    // Use this for initialization
    void Start()
    {
        densityCanvas.SetActive(false);
        typologySizeSetterClass.SetActive(false);
        typologySizeSetterClass.GetComponent<TypologySizeSetter>().enabled = false;
        typologyPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void showDensityCanvas()
    {
        densityCanvas.SetActive(true);
       
    }

    //when the user chooses medium density
    public void mediumDensity()
    {
        densityValue = 1;
        PlayerPrefs.SetInt("DensityLevel",1);
        Debug.Log("Density level is : " + PlayerPrefs.GetInt("DensityLevel"));
        typologyPanel.SetActive(true);
        densityCanvas.SetActive(false);
        typologySizeSetterClass.SetActive(true);
        typologySizeSetterClass.GetComponent<TypologySizeSetter>().enabled = true;
    }
    //when the user chooses large density
    public void largeDensity()
    {
        densityValue = 2;
        PlayerPrefs.SetInt("DensityLevel", 2);
        Debug.Log("Density level is : " + PlayerPrefs.GetInt("DensityLevel"));
        typologyPanel.SetActive(true);
        densityCanvas.SetActive(false);
        typologySizeSetterClass.SetActive(true);
        typologySizeSetterClass.GetComponent<TypologySizeSetter>().enabled = true;

    }
}
