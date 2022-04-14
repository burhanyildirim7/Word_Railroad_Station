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

    public GameObject vagon;
    bool ready = true;

    void Start()
    {



    }

    void Update()
    {
        if (ready)
        {
            StartCoroutine(SpawnNewTrain());
        }


    }

    public IEnumerator SpawnNewTrain()
    {

        ready = false;

        int randomNumber;
        randomNumber = Random.Range(0, allLetters.Count);
        GameObject obje = allLetters[randomNumber];
        var spawnedLetter = Instantiate(obje, new Vector3(0, 2, -23), Quaternion.Euler(90, 0, 0));


        var spawnedTrain = Instantiate(vagon, new Vector3(0, 1, -23), Quaternion.identity);
        spawnedLetter.transform.GetChild(0).GetComponent<MeshRenderer>().material.color = Color.white;
        spawnedLetter.transform.parent = spawnedTrain.transform;
        yield return new WaitForSeconds(10);




        ready = true;
    }


}
