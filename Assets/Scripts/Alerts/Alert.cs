using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Alert : MonoBehaviour {

    public GameObject alert;

    void Start()
    {
        alert.SetActive(false);   
    }
    public Alert(string alertText)
    {
      alert.transform.FindChild("Alert").gameObject.GetComponent<Text>().text =alertText;
        alert.SetActive(true);
       
    }
}
