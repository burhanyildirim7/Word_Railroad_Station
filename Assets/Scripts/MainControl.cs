using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainControl : MonoBehaviour
{
    public int leftStationChild = 0;
    public int midStationChild = 0;
    public int rightStationChild = 0;

    public bool leftStationAvailable = true;
    public bool midStationAvailable = true;
    public bool rightStationAvailable = true;

    public List<GameObject> allLetters = new List<GameObject>();
    public List<GameObject> existingLetter = new List<GameObject>();


    bool ready = true;

     void Start()
    {
       

        
    }
    void Update()
    {
        if (leftStationChild==GameObject.FindGameObjectWithTag("LeftStation").transform.childCount)
        {
            leftStationAvailable = false;
        }

        if (midStationChild == GameObject.FindGameObjectWithTag("MidStation").transform.childCount)
        {
            midStationAvailable = false;
        }

        if (rightStationChild == GameObject.FindGameObjectWithTag("RightStation").transform.childCount)
        {
            rightStationAvailable = false;
        }
        if (ready)
        {
            StartCoroutine(SpawnNewTrain());
        }
       

    }
    IEnumerator  SpawnNewTrain()
    {
        ready = false;
        int randomNumber;
        randomNumber = Random.Range(0, 9);
        GameObject obje = allLetters[randomNumber];
        var spawnedLetter = Instantiate(obje, new Vector3(0, 0, 20), Quaternion.Euler(90,180,0));
        spawnedLetter.AddComponent<TrainControl>();
        spawnedLetter.AddComponent<Rigidbody>();
        spawnedLetter.GetComponent<Rigidbody>().useGravity = false;
        spawnedLetter.AddComponent<BoxCollider>();
        yield return new WaitForSeconds(6);
        ready = true;
    }

    
}
