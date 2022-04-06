using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainControl : MonoBehaviour
{


    public List<GameObject> firstThreeLetters = new List<GameObject>();
    public List<GameObject> existingLetter = new List<GameObject>();


     void Start()
    {
        firstThreeLetters.Add(GameObject.FindGameObjectWithTag("LeftStation").transform.GetChild(0).gameObject);
        firstThreeLetters.Add(GameObject.FindGameObjectWithTag("MidStation").transform.GetChild(0).gameObject);
        firstThreeLetters.Add(GameObject.FindGameObjectWithTag("RightStation").transform.GetChild(0).gameObject);
    }
    void Update()
    {
        
    }
    public void SpawnNewTrain()
    {

        int randomNumber;
        randomNumber = Random.Range(0, 3);
        GameObject obje = firstThreeLetters[randomNumber];
        var spawnedLetter = Instantiate(obje, new Vector3(0, 0, 20), Quaternion.Euler(0,180,0));
        spawnedLetter.AddComponent<TrainControl>();
        spawnedLetter.AddComponent<Rigidbody>();
        spawnedLetter.GetComponent<Rigidbody>().useGravity = false;
        spawnedLetter.AddComponent<BoxCollider>();
        
        
    }
}
