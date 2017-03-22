using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Recommendations : MonoBehaviour {
    public GameObject recommendations;
    Text[] recommendationsParentTexts;
 

	// Use this for initialization
	void Start () {

       recommendationsParentTexts = recommendations.GetComponentsInChildren<Text>();
       changeRecommendationText();

    }
	
    void changeRecommendationText()
    {
        int planeLength = PlayerPrefs.GetInt("PlaneLength");
        int planeWidth = PlayerPrefs.GetInt("PlaneWidth");

        if (planeLength < 70 && planeWidth < 70)
        {
            recommendationsParentTexts[1].text = "Shop";
            recommendationsParentTexts[2].text = "Bakery";
            recommendationsParentTexts[3].text = "Park";
            recommendationsParentTexts[4].text = "Mosque";
        
        }
     if(planeLength >= 70 && planeWidth >= 70)
        {
            recommendationsParentTexts[1].text = "Shop";
            recommendationsParentTexts[2].text = "Bakery";
            recommendationsParentTexts[3].text = "Park";
            recommendationsParentTexts[4].text = "Mosque";
            recommendationsParentTexts[5].text = "Clinic";
            recommendationsParentTexts[6].text = "Primary School";
            recommendationsParentTexts[7].text = "Community Center";
        }


    }

    public void closeRecommendationBox()
    {
        recommendations.SetActive(false);
       
    }

}
