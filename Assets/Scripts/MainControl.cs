using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainControl : MonoBehaviour
{
    public GameObject obje;


    public void SpawnNewTrain()
    {
        Instantiate(obje, new Vector3(0, 0, 20), Quaternion.identity);
       
    }
}
