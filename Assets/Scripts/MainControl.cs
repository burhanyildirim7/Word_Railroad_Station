using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainControl : MonoBehaviour
{
    public int leftStationChild = 0;
    public int midStationChild = 0;
    public int rightStationChild = 0;

    public bool leftStationAvailable = true;
    public bool midStationAvailable = true;
    public bool rightStationAvailable = true;

    public List<GameObject> allLetters = new List<GameObject>();
    public List<string> allLettersHarf = new List<string>();

    public GameObject vagon;
    bool ready = true;

    public List<GameObject> _yollanacakHarfler = new List<GameObject>();
    public List<int> _indexListesi = new List<int>();

    private LevelCanvasScript _levelCanvasScript;

    private int _randomBomba;

    public int _bombaSikligi;

    public GameObject _bombaObject;

    void Start()
    {
        Invoke("GönderilecekHarfListesiOlustur", 0.5f);
        //GönderilecekHarfListesiOlustur();

    }

    void Update()
    {
        if (ready)
        {

            StartCoroutine(SpawnNewTrain());
        }


    }

    public void GönderilecekHarfListesiOlustur()
    {
        _levelCanvasScript = GameObject.FindGameObjectWithTag("LevelCanvas").GetComponent<LevelCanvasScript>();

        if (_levelCanvasScript._level1)
        {

            for (int i = 0; i < _levelCanvasScript._peron1kelimeliste.Count; i++)
            {

                char harf = _levelCanvasScript._peron1kelimeliste[i];
                _indexListesi.Add(allLettersHarf.BinarySearch(harf.ToString()));

            }

            for (int i = 0; i < _levelCanvasScript._peron2kelimeliste.Count; i++)
            {

                char harf = _levelCanvasScript._peron2kelimeliste[i];
                _indexListesi.Add(allLettersHarf.BinarySearch(harf.ToString()));

            }
        }
        else
        {
            for (int i = 0; i < _levelCanvasScript._peron1kelimeliste.Count; i++)
            {

                char harf = _levelCanvasScript._peron1kelimeliste[i];
                _indexListesi.Add(allLettersHarf.BinarySearch(harf.ToString()));

            }

            for (int i = 0; i < _levelCanvasScript._peron2kelimeliste.Count; i++)
            {

                char harf = _levelCanvasScript._peron2kelimeliste[i];
                _indexListesi.Add(allLettersHarf.BinarySearch(harf.ToString()));

            }

            for (int i = 0; i < _levelCanvasScript._peron3kelimeliste.Count; i++)
            {

                char harf = _levelCanvasScript._peron3kelimeliste[i];
                _indexListesi.Add(allLettersHarf.BinarySearch(harf.ToString()));

            }
        }
    }

    public IEnumerator SpawnNewTrain()
    {

        Debug.Log("girdi");

        ready = false;

        yield return new WaitForSeconds(1);

        _randomBomba = Random.Range(0, _bombaSikligi);

        if (_randomBomba == 0)
        {
            //int randomNumber;
            //randomNumber = Random.Range(0, _indexListesi.Count);
            //GameObject obje = allLetters[_indexListesi[randomNumber]];
            //Debug.Log("sayı bu " + _indexListesi[randomNumber]);
            var spawnedLetter = Instantiate(_bombaObject, new Vector3(0, 2, -23), Quaternion.Euler(90, 0, 0));

            var spawnedTrain = Instantiate(vagon, new Vector3(0, 1, -23), Quaternion.identity);
            //spawnedLetter.transform.GetChild(0).GetComponent<MeshRenderer>().material.color = Color.white;
            spawnedLetter.transform.parent = spawnedTrain.transform;
            spawnedTrain.GetComponent<CubeScript>()._bombaMi = true;
            yield return new WaitForSeconds(10);
        }
        else
        {
            int randomNumber;
            randomNumber = Random.Range(0, _indexListesi.Count);
            GameObject obje = allLetters[_indexListesi[randomNumber]];
            //Debug.Log("sayı bu " + _indexListesi[randomNumber]);
            var spawnedLetter = Instantiate(obje, new Vector3(0, 2, -23), Quaternion.Euler(90, 0, 0));

            var spawnedTrain = Instantiate(vagon, new Vector3(0, 1, -23), Quaternion.identity);
            spawnedLetter.transform.GetChild(0).GetComponent<MeshRenderer>().material.color = Color.white;
            spawnedLetter.transform.parent = spawnedTrain.transform;
            spawnedTrain.GetComponent<CubeScript>()._bombaMi = false;
            yield return new WaitForSeconds(10);
        }









        ready = true;
    }


}
