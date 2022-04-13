using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftStationControl : MonoBehaviour
{
    public List<GameObject> varolanHarfler = new List<GameObject>();
    public List<GameObject> eklenenHarfler = new List<GameObject>();

    public GameObject firstLetterColor;
    public GameObject secondLetterColor;
    public GameObject thirdLetterColor;
    void Start()
    {
        
       
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < varolanHarfler.Count; i++)
        {
            if (varolanHarfler[i].gameObject.tag == eklenenHarfler[i].gameObject.tag)
            {
               varolanHarfler[i].transform.GetChild(0).GetComponent<MeshRenderer>().material.color = Color.green;

            }
        }
    }
}
