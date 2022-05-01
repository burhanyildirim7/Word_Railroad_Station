using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainControl : MonoBehaviour
{

    public static MainControl instance;

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

    //public List<GameObject> _yollanacakHarfler = new List<GameObject>();
    public List<int> _indexListesi = new List<int>();

    private LevelCanvasScript _levelCanvasScript;

    private int _randomBomba;

    public int _bombaSikligi;

    public GameObject _bombaObject;

    public List<GameObject> _sahnedekiVagonListesi = new List<GameObject>();

    public List<GameObject> _level1VagonListesi = new List<GameObject>();

    public static int _level1AsamaSayisi;

    public int _level1KacAsama;

    private void Awake()
    {
        if (instance == null) instance = this;
        //else Destroy(this);
    }

    void Start()
    {
        Invoke("GonderilecekHarfListesiOlustur", 0.5f);
        _level1AsamaSayisi = 0;
        //GönderilecekHarfListesiOlustur();

    }

    void Update()
    {
        if (GameController.instance.isContinue)
        {
            if (ready)
            {

                StartCoroutine(SpawnNewTrain());

            }
            BosYeriTemizle();
        }
        else
        {

        }



    }

    public void SahneyiTemizle()
    {
        for (int i = 0; i < _sahnedekiVagonListesi.Count; i++)
        {
            Destroy(_sahnedekiVagonListesi[i]);

        }

        for (int i = 0; i < _sahnedekiVagonListesi.Count; i++)
        {
            if (_sahnedekiVagonListesi[i] == null)
            {
                _sahnedekiVagonListesi.RemoveAt(i);
            }
            else
            {

            }
        }

        for (int i = 0; i < _indexListesi.Count; i++)
        {
            _indexListesi.RemoveAt(i);
        }

        _level1AsamaSayisi = 0;

        //LevelCanvasScript.instance._peron1Bitti = false;
        //LevelCanvasScript.instance._peron2Bitti = false;
        //LevelCanvasScript.instance._peron3Bitti = false;

        //LevelCanvasScript.instance._peron1Yanlis = false;
        //LevelCanvasScript.instance._peron2Yanlis = false;
        //LevelCanvasScript.instance._peron3Yanlis = false;
    }

    public void BosYeriTemizle()
    {
        for (int i = 0; i < _sahnedekiVagonListesi.Count; i++)
        {
            if (_sahnedekiVagonListesi[i] == null)
            {
                _sahnedekiVagonListesi.RemoveAt(i);
            }
            else
            {

            }
        }


    }

    public void GonderilecekHarfListesiOlustur()
    {
        _levelCanvasScript = GameObject.FindGameObjectWithTag("LevelCanvas").GetComponent<LevelCanvasScript>();

        if (_levelCanvasScript._level1)
        {
            /*
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
            */
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

        _levelCanvasScript = GameObject.FindGameObjectWithTag("LevelCanvas").GetComponent<LevelCanvasScript>();

        if (_levelCanvasScript._level1)
        {
            var spawnedLetter = Instantiate(_level1VagonListesi[_level1AsamaSayisi], new Vector3(0, 2, -23), Quaternion.Euler(90, 0, 0));

            var spawnedTrain = Instantiate(vagon, new Vector3(0, 1, -23), Quaternion.identity);
            spawnedLetter.transform.GetChild(0).GetComponent<MeshRenderer>().material.color = Color.white;
            spawnedLetter.transform.parent = spawnedTrain.transform;
            spawnedTrain.GetComponent<CubeScript>()._bombaMi = false;

            _level1AsamaSayisi++;

            if (_level1AsamaSayisi == _level1KacAsama)
            {
                _level1AsamaSayisi = 0;
            }
            else
            {

            }
            yield return new WaitForSeconds(8);
        }
        else
        {
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
                yield return new WaitForSeconds(8);
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
                yield return new WaitForSeconds(8);
            }




        }







        ready = true;
    }


}
