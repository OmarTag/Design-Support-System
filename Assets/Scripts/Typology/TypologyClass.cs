using UnityEngine;
using System.Collections;

public class TypologyClass : MonoBehaviour {



    public TypologyClass(GameObject typology ,Vector3 _position, int width,int length, float height)
    {

        Instantiate(typology);
        typology.transform.position = _position;
        typology.transform.localScale = new Vector3(width, height, length);
       // typology.GetComponent<Material>().color = Color.white;

    }


}
