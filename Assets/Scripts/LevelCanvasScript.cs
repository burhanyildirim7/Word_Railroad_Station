using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelCanvasScript : MonoBehaviour
{

    public static LevelCanvasScript instance;

    public bool _level1;

    private KelimeListesi _kelimeListesi;

    public int _peron1HarfSayisi;
    public int _peron2HarfSayisi;
    public int _peron3HarfSayisi;

    public char[] _peron1kelime;
    public char[] _peron2kelime;
    public char[] _peron3kelime;

    public List<char> _peron1gelenkelime = new List<char>();
    public List<char> _peron2gelenkelime = new List<char>();
    public List<char> _peron3gelenkelime = new List<char>();


    public List<char> _peron1kelimeliste = new List<char>();
    public List<char> _peron2kelimeliste = new List<char>();
    public List<char> _peron3kelimeliste = new List<char>();

    public GameObject _peron1Bariyer;
    public GameObject _peron2Bariyer;
    public GameObject _peron3Bariyer;

    public bool _peron1Bitti;
    public bool _peron2Bitti;
    public bool _peron3Bitti;

    public bool _peron1Yanlis;
    public bool _peron2Yanlis;
    public bool _peron3Yanlis;







    private void Awake()
    {
        if (instance == null) instance = this;
        //else Destroy(this);
    }


    [System.Obsolete]
    void Start()
    {
        _kelimeListesi = GameObject.FindGameObjectWithTag("KelimeListesi").GetComponent<KelimeListesi>();

        if (_level1)
        {
            _peron1Bariyer.SetActive(false);
            _peron2Bariyer.SetActive(false);

            _peron1Bitti = false;
            _peron2Bitti = false;

            _peron1Yanlis = false;
            _peron2Yanlis = false;
        }
        else
        {
            _peron1Bariyer.SetActive(false);
            _peron2Bariyer.SetActive(false);
            _peron3Bariyer.SetActive(false);

            _peron1Bitti = false;
            _peron2Bitti = false;
            _peron3Bitti = false;

            _peron1Yanlis = false;
            _peron2Yanlis = false;
            _peron3Yanlis = false;
        }


        PeronaKelimeYazdır();

    }





    //--------------PERON 1 KELIME KONTROL ETME------------------------------------------------------------------------------------------------------------------------------------------------------


    public void Peron1KelimeleriKontrolEt()
    {
        if (_peron1gelenkelime.Count == 1 && _peron1kelimeliste.Count >= 3)
        {
            if (_peron1kelime[0].ToString() == _peron1gelenkelime[0].ToString())
            {
                transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().color = Color.green;
            }
            else
            {
                transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().color = Color.red;
            }
        }
        else
        {
            if (_peron1gelenkelime.Count == 0)
            {
                transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().color = Color.white;
            }
            else
            {

            }

        }

        if (_peron1gelenkelime.Count == 2 && _peron1kelimeliste.Count >= 3)
        {
            if (_peron1kelime[1].ToString() == _peron1gelenkelime[1].ToString())
            {
                transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().color = Color.green;
            }
            else
            {
                transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().color = Color.red;
            }
        }
        else
        {
            if (_peron1gelenkelime.Count == 1)
            {
                transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().color = Color.white;
            }
            else
            {

            }

        }


        if (_peron1gelenkelime.Count == 3 && _peron1kelimeliste.Count >= 3)
        {
            if (_peron1kelime[2].ToString() == _peron1gelenkelime[2].ToString())
            {
                transform.GetChild(0).gameObject.transform.GetChild(2).gameObject.GetComponent<Text>().color = Color.green;

                if (_peron1gelenkelime.Count == 3 && _peron1kelimeliste.Count == 3)
                {
                    if (transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().color == Color.green && transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().color == Color.green && transform.GetChild(0).gameObject.transform.GetChild(2).gameObject.GetComponent<Text>().color == Color.green)
                    {
                        Debug.Log("ILK PERON TAMAMLANDI");
                        _peron1Bariyer.SetActive(true);
                        _peron1Bitti = true;
                    }
                    else
                    {
                        _peron1Yanlis = true;
                        Debug.Log("ILK PERON YANLIS");
                    }
                }
                else
                {

                }

            }
            else
            {
                transform.GetChild(0).gameObject.transform.GetChild(2).gameObject.GetComponent<Text>().color = Color.red;

                if (_peron1gelenkelime.Count == 3 && _peron1kelimeliste.Count == 3)
                {
                    _peron1Yanlis = true;
                    Debug.Log("ILK PERON YANLIS");

                }
                else
                {

                }

            }
        }
        else
        {
            if (_peron1gelenkelime.Count == 2 && _peron1kelimeliste.Count >= 3)
            {
                transform.GetChild(0).gameObject.transform.GetChild(2).gameObject.GetComponent<Text>().color = Color.white;
                _peron1Yanlis = false;
            }
            else
            {

            }

        }

        if (_peron1gelenkelime.Count == 4 && _peron1kelimeliste.Count >= 4)
        {
            if (_peron1kelime[3].ToString() == _peron1gelenkelime[3].ToString())
            {
                transform.GetChild(0).gameObject.transform.GetChild(3).gameObject.GetComponent<Text>().color = Color.green;

                if (_peron1gelenkelime.Count == 4 && _peron1kelimeliste.Count == 4)
                {
                    if (transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().color == Color.green && transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().color == Color.green && transform.GetChild(0).gameObject.transform.GetChild(2).gameObject.GetComponent<Text>().color == Color.green && transform.GetChild(0).gameObject.transform.GetChild(3).gameObject.GetComponent<Text>().color == Color.green)
                    {
                        Debug.Log("ILK PERON TAMAMLANDI");
                        _peron1Bariyer.SetActive(true);
                        _peron1Bitti = true;
                    }
                    else
                    {
                        _peron1Yanlis = true;
                        Debug.Log("ILK PERON YANLIS");
                    }
                }
                else
                {

                }
            }
            else
            {
                transform.GetChild(0).gameObject.transform.GetChild(3).gameObject.GetComponent<Text>().color = Color.red;

                if (_peron1gelenkelime.Count == 4 && _peron1kelimeliste.Count == 4)
                {
                    _peron1Yanlis = true;
                    Debug.Log("ILK PERON YANLIS");

                }
                else
                {

                }
            }
        }
        else
        {
            if (_peron1gelenkelime.Count == 3 && _peron1kelimeliste.Count >= 4)
            {
                transform.GetChild(0).gameObject.transform.GetChild(3).gameObject.GetComponent<Text>().color = Color.white;
                _peron1Yanlis = false;
            }
            else
            {

            }

        }

        if (_peron1gelenkelime.Count == 5 && _peron1kelimeliste.Count >= 5)
        {
            if (_peron1kelime[4].ToString() == _peron1gelenkelime[4].ToString())
            {
                transform.GetChild(0).gameObject.transform.GetChild(4).gameObject.GetComponent<Text>().color = Color.green;

                if (_peron1gelenkelime.Count == 5 && _peron1kelimeliste.Count == 5)
                {
                    if (transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().color == Color.green && transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().color == Color.green && transform.GetChild(0).gameObject.transform.GetChild(2).gameObject.GetComponent<Text>().color == Color.green && transform.GetChild(0).gameObject.transform.GetChild(3).gameObject.GetComponent<Text>().color == Color.green && transform.GetChild(0).gameObject.transform.GetChild(4).gameObject.GetComponent<Text>().color == Color.green)
                    {
                        Debug.Log("ILK PERON TAMAMLANDI");
                        _peron1Bariyer.SetActive(true);
                        _peron1Bitti = true;
                    }
                    else
                    {
                        _peron1Yanlis = true;
                        Debug.Log("ILK PERON YANLIS");
                    }
                }
                else
                {

                }
            }
            else
            {
                transform.GetChild(0).gameObject.transform.GetChild(4).gameObject.GetComponent<Text>().color = Color.red;

                if (_peron1gelenkelime.Count == 5 && _peron1kelimeliste.Count == 5)
                {
                    _peron1Yanlis = true;
                    Debug.Log("ILK PERON YANLIS");

                }
                else
                {

                }
            }
        }
        else
        {
            if (_peron1gelenkelime.Count == 4 && _peron1kelimeliste.Count >= 5)
            {
                transform.GetChild(0).gameObject.transform.GetChild(4).gameObject.GetComponent<Text>().color = Color.white;
                _peron1Yanlis = false;
            }
            else
            {

            }

        }

        if (_peron1gelenkelime.Count == 6 && _peron1kelimeliste.Count >= 6)
        {
            if (_peron1kelime[5].ToString() == _peron1gelenkelime[5].ToString())
            {
                transform.GetChild(0).gameObject.transform.GetChild(5).gameObject.GetComponent<Text>().color = Color.green;

                if (_peron1gelenkelime.Count == 6 && _peron1kelimeliste.Count == 6)
                {
                    if (transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().color == Color.green && transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().color == Color.green && transform.GetChild(0).gameObject.transform.GetChild(2).gameObject.GetComponent<Text>().color == Color.green && transform.GetChild(0).gameObject.transform.GetChild(3).gameObject.GetComponent<Text>().color == Color.green && transform.GetChild(0).gameObject.transform.GetChild(4).gameObject.GetComponent<Text>().color == Color.green && transform.GetChild(0).gameObject.transform.GetChild(5).gameObject.GetComponent<Text>().color == Color.green)
                    {
                        Debug.Log("ILK PERON TAMAMLANDI");
                        _peron1Bariyer.SetActive(true);
                        _peron1Bitti = true;
                    }
                    else
                    {
                        _peron1Yanlis = true;
                        Debug.Log("ILK PERON YANLIS");
                    }
                }
                else
                {

                }
            }
            else
            {
                transform.GetChild(0).gameObject.transform.GetChild(5).gameObject.GetComponent<Text>().color = Color.red;

                if (_peron1gelenkelime.Count == 6 && _peron1kelimeliste.Count == 6)
                {
                    _peron1Yanlis = true;
                    Debug.Log("ILK PERON YANLIS");

                }
                else
                {

                }
            }
        }
        else
        {
            if (_peron1gelenkelime.Count == 5 && _peron1kelimeliste.Count >= 6)
            {
                transform.GetChild(0).gameObject.transform.GetChild(5).gameObject.GetComponent<Text>().color = Color.white;
                _peron1Yanlis = false;
            }
            else
            {

            }

        }

        if (_level1)
        {
            if (_peron1Bitti && _peron2Bitti)
            {
                GameController.instance.isContinue = false;
                GameController.instance.SetScore(100);
                GameController.instance.ScoreCarp(2);
                UIController.instance.ActivateWinScreen();
            }
            else if (_peron1Bitti && _peron2Yanlis)
            {
                GameController.instance.isContinue = false;
                GameController.instance.SetScore(100);
                GameController.instance.ScoreCarp(1);
                UIController.instance.ActivateWinScreen();
            }
            else if (_peron1Yanlis && _peron2Bitti)
            {
                GameController.instance.isContinue = false;
                GameController.instance.SetScore(100);
                GameController.instance.ScoreCarp(1);
                UIController.instance.ActivateWinScreen();
            }
            else if (_peron1Yanlis && _peron2Yanlis)
            {
                GameController.instance.isContinue = false;
                GameController.instance.SetScore(0);
                UIController.instance.ActivateLooseScreen();
            }
            else
            {

            }
        }
        else
        {
            if (_peron1Bitti && _peron2Bitti && _peron3Bitti)
            {
                GameController.instance.isContinue = false;
                GameController.instance.SetScore(100);
                GameController.instance.ScoreCarp(3);
                UIController.instance.ActivateWinScreen();
            }
            else if (_peron1Bitti && _peron2Bitti && _peron3Yanlis)
            {
                GameController.instance.isContinue = false;
                GameController.instance.SetScore(100);
                GameController.instance.ScoreCarp(2);
                UIController.instance.ActivateWinScreen();
            }
            else if (_peron1Bitti && _peron2Yanlis && _peron3Yanlis)
            {
                GameController.instance.isContinue = false;
                GameController.instance.SetScore(100);
                GameController.instance.ScoreCarp(2);
                UIController.instance.ActivateWinScreen();
            }
            else if (_peron1Yanlis && _peron2Bitti && _peron3Bitti)
            {
                GameController.instance.isContinue = false;
                GameController.instance.SetScore(100);
                GameController.instance.ScoreCarp(2);
                UIController.instance.ActivateWinScreen();
            }
            else if (_peron1Yanlis && _peron2Yanlis && _peron3Bitti)
            {
                GameController.instance.isContinue = false;
                GameController.instance.SetScore(100);
                GameController.instance.ScoreCarp(2);
                UIController.instance.ActivateWinScreen();
            }
            else if (_peron1Yanlis && _peron2Bitti && _peron3Yanlis)
            {
                GameController.instance.isContinue = false;
                GameController.instance.SetScore(100);
                GameController.instance.ScoreCarp(2);
                UIController.instance.ActivateWinScreen();
            }
            else if (_peron1Bitti && _peron2Yanlis && _peron3Bitti)
            {
                GameController.instance.isContinue = false;
                GameController.instance.SetScore(100);
                GameController.instance.ScoreCarp(2);
                UIController.instance.ActivateWinScreen();
            }
            else if (_peron1Yanlis && _peron2Yanlis && _peron3Yanlis)
            {
                GameController.instance.isContinue = false;
                GameController.instance.SetScore(0);
                UIController.instance.ActivateLooseScreen();
            }
            else
            {

            }
        }


    }


    //--------------PERON 2 KELIME KONTROL ETME------------------------------------------------------------------------------------------------------------------------------------------------------



    public void Peron2KelimeleriKontrolEt()
    {
        if (_peron2gelenkelime.Count == 1 && _peron2kelimeliste.Count >= 3)
        {
            if (_peron2kelime[0].ToString() == _peron2gelenkelime[0].ToString())
            {
                transform.GetChild(1).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().color = Color.green;
            }
            else
            {
                transform.GetChild(1).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().color = Color.red;
            }
        }
        else
        {
            if (_peron2gelenkelime.Count == 0)
            {
                transform.GetChild(1).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().color = Color.white;
            }
            else
            {

            }

        }

        if (_peron2gelenkelime.Count == 2 && _peron2kelimeliste.Count >= 3)
        {
            if (_peron2kelime[1].ToString() == _peron2gelenkelime[1].ToString())
            {
                transform.GetChild(1).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().color = Color.green;
            }
            else
            {
                transform.GetChild(1).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().color = Color.red;
            }
        }
        else
        {
            if (_peron2gelenkelime.Count == 1)
            {
                transform.GetChild(1).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().color = Color.white;
            }
            else
            {

            }

        }


        if (_peron2gelenkelime.Count == 3 && _peron2kelimeliste.Count >= 3)
        {
            if (_peron2kelime[2].ToString() == _peron2gelenkelime[2].ToString())
            {
                transform.GetChild(1).gameObject.transform.GetChild(2).gameObject.GetComponent<Text>().color = Color.green;

                if (_peron2gelenkelime.Count == 3 && _peron2kelimeliste.Count == 3)
                {
                    if (transform.GetChild(1).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().color == Color.green && transform.GetChild(1).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().color == Color.green && transform.GetChild(1).gameObject.transform.GetChild(2).gameObject.GetComponent<Text>().color == Color.green)
                    {
                        Debug.Log("IKINCI PERON TAMAMLANDI");
                        _peron2Bariyer.SetActive(true);
                        _peron2Bitti = true;
                    }
                    else
                    {
                        _peron2Yanlis = true;
                        Debug.Log("IKINCI PERON YANLIS");
                    }
                }
                else
                {

                }
            }
            else
            {
                transform.GetChild(1).gameObject.transform.GetChild(2).gameObject.GetComponent<Text>().color = Color.red;

                if (_peron2gelenkelime.Count == 3 && _peron2kelimeliste.Count == 3)
                {
                    _peron2Yanlis = true;
                    Debug.Log("IKINCI PERON YANLIS");

                }
                else
                {

                }
            }
        }
        else
        {
            if (_peron2gelenkelime.Count == 2 && _peron2kelimeliste.Count >= 3)
            {
                transform.GetChild(1).gameObject.transform.GetChild(2).gameObject.GetComponent<Text>().color = Color.white;
                _peron2Yanlis = false;
            }
            else
            {

            }

        }

        if (_peron2gelenkelime.Count == 4 && _peron2kelimeliste.Count >= 4)
        {
            if (_peron2kelime[3].ToString() == _peron2gelenkelime[3].ToString())
            {
                transform.GetChild(1).gameObject.transform.GetChild(3).gameObject.GetComponent<Text>().color = Color.green;

                if (_peron2gelenkelime.Count == 4 && _peron2kelimeliste.Count == 4)
                {
                    if (transform.GetChild(1).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().color == Color.green && transform.GetChild(1).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().color == Color.green && transform.GetChild(1).gameObject.transform.GetChild(2).gameObject.GetComponent<Text>().color == Color.green && transform.GetChild(1).gameObject.transform.GetChild(3).gameObject.GetComponent<Text>().color == Color.green)
                    {
                        Debug.Log("IKINCI PERON TAMAMLANDI");
                        _peron2Bariyer.SetActive(true);
                        _peron2Bitti = true;
                    }
                    else
                    {
                        _peron2Yanlis = true;
                        Debug.Log("IKINCI PERON YANLIS");
                    }
                }
                else
                {

                }
            }
            else
            {
                transform.GetChild(1).gameObject.transform.GetChild(3).gameObject.GetComponent<Text>().color = Color.red;

                if (_peron2gelenkelime.Count == 4 && _peron2kelimeliste.Count == 4)
                {
                    _peron2Yanlis = true;
                    Debug.Log("IKINCI PERON YANLIS");

                }
                else
                {

                }
            }
        }
        else
        {
            if (_peron2gelenkelime.Count == 3 && _peron2kelimeliste.Count >= 4)
            {
                transform.GetChild(1).gameObject.transform.GetChild(3).gameObject.GetComponent<Text>().color = Color.white;
                _peron2Yanlis = false;
            }
            else
            {

            }

        }

        if (_peron2gelenkelime.Count == 5 && _peron2kelimeliste.Count >= 5)
        {
            if (_peron2kelime[4].ToString() == _peron2gelenkelime[4].ToString())
            {
                transform.GetChild(1).gameObject.transform.GetChild(4).gameObject.GetComponent<Text>().color = Color.green;

                if (_peron2gelenkelime.Count == 5 && _peron2kelimeliste.Count == 5)
                {
                    if (transform.GetChild(1).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().color == Color.green && transform.GetChild(1).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().color == Color.green && transform.GetChild(1).gameObject.transform.GetChild(2).gameObject.GetComponent<Text>().color == Color.green && transform.GetChild(1).gameObject.transform.GetChild(3).gameObject.GetComponent<Text>().color == Color.green && transform.GetChild(1).gameObject.transform.GetChild(4).gameObject.GetComponent<Text>().color == Color.green)
                    {
                        Debug.Log("IKINCI PERON TAMAMLANDI");
                        _peron2Bariyer.SetActive(true);
                        _peron2Bitti = true;
                    }
                    else
                    {
                        _peron2Yanlis = true;
                        Debug.Log("IKINCI PERON YANLIS");
                    }
                }
                else
                {

                }
            }
            else
            {
                transform.GetChild(1).gameObject.transform.GetChild(4).gameObject.GetComponent<Text>().color = Color.red;

                if (_peron2gelenkelime.Count == 5 && _peron2kelimeliste.Count == 5)
                {
                    _peron2Yanlis = true;
                    Debug.Log("IKINCI PERON YANLIS");

                }
                else
                {

                }
            }
        }
        else
        {
            if (_peron2gelenkelime.Count == 4 && _peron2kelimeliste.Count >= 5)
            {
                transform.GetChild(1).gameObject.transform.GetChild(4).gameObject.GetComponent<Text>().color = Color.white;
                _peron2Yanlis = false;
            }
            else
            {

            }

        }

        if (_peron2gelenkelime.Count == 6 && _peron2kelimeliste.Count >= 6)
        {
            if (_peron2kelime[5].ToString() == _peron2gelenkelime[5].ToString())
            {
                transform.GetChild(1).gameObject.transform.GetChild(5).gameObject.GetComponent<Text>().color = Color.green;

                if (_peron2gelenkelime.Count == 6 && _peron2kelimeliste.Count == 6)
                {
                    if (transform.GetChild(1).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().color == Color.green && transform.GetChild(1).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().color == Color.green && transform.GetChild(1).gameObject.transform.GetChild(2).gameObject.GetComponent<Text>().color == Color.green && transform.GetChild(1).gameObject.transform.GetChild(3).gameObject.GetComponent<Text>().color == Color.green && transform.GetChild(1).gameObject.transform.GetChild(4).gameObject.GetComponent<Text>().color == Color.green && transform.GetChild(1).gameObject.transform.GetChild(5).gameObject.GetComponent<Text>().color == Color.green)
                    {
                        Debug.Log("IKINCI PERON TAMAMLANDI");
                        _peron2Bariyer.SetActive(true);
                        _peron2Bitti = true;
                    }
                    else
                    {
                        _peron2Yanlis = true;
                        Debug.Log("IKINCI PERON YANLIS");
                    }
                }
                else
                {

                }
            }
            else
            {
                transform.GetChild(1).gameObject.transform.GetChild(5).gameObject.GetComponent<Text>().color = Color.red;

                if (_peron2gelenkelime.Count == 6 && _peron2kelimeliste.Count == 6)
                {
                    _peron2Yanlis = true;
                    Debug.Log("IKINCI PERON YANLIS");

                }
                else
                {

                }
            }
        }
        else
        {
            if (_peron2gelenkelime.Count == 5 && _peron2kelimeliste.Count >= 6)
            {
                transform.GetChild(1).gameObject.transform.GetChild(5).gameObject.GetComponent<Text>().color = Color.white;
                _peron2Yanlis = false;
            }
            else
            {

            }

        }

        if (_level1)
        {
            if (_peron1Bitti && _peron2Bitti)
            {
                GameController.instance.isContinue = false;
                GameController.instance.SetScore(100);
                GameController.instance.ScoreCarp(2);
                UIController.instance.ActivateWinScreen();
            }
            else if (_peron1Bitti && _peron2Yanlis)
            {
                GameController.instance.isContinue = false;
                GameController.instance.SetScore(100);
                GameController.instance.ScoreCarp(1);
                UIController.instance.ActivateWinScreen();
            }
            else if (_peron1Yanlis && _peron2Bitti)
            {
                GameController.instance.isContinue = false;
                GameController.instance.SetScore(100);
                GameController.instance.ScoreCarp(1);
                UIController.instance.ActivateWinScreen();
            }
            else if (_peron1Yanlis && _peron2Yanlis)
            {
                GameController.instance.isContinue = false;
                GameController.instance.SetScore(0);
                UIController.instance.ActivateLooseScreen();
            }
            else
            {

            }
        }
        else
        {
            if (_peron1Bitti && _peron2Bitti && _peron3Bitti)
            {
                GameController.instance.isContinue = false;
                GameController.instance.SetScore(100);
                GameController.instance.ScoreCarp(3);
                UIController.instance.ActivateWinScreen();
            }
            else if (_peron1Bitti && _peron2Bitti && _peron3Yanlis)
            {
                GameController.instance.isContinue = false;
                GameController.instance.SetScore(100);
                GameController.instance.ScoreCarp(2);
                UIController.instance.ActivateWinScreen();
            }
            else if (_peron1Bitti && _peron2Yanlis && _peron3Yanlis)
            {
                GameController.instance.isContinue = false;
                GameController.instance.SetScore(100);
                GameController.instance.ScoreCarp(2);
                UIController.instance.ActivateWinScreen();
            }
            else if (_peron1Yanlis && _peron2Bitti && _peron3Bitti)
            {
                GameController.instance.isContinue = false;
                GameController.instance.SetScore(100);
                GameController.instance.ScoreCarp(2);
                UIController.instance.ActivateWinScreen();
            }
            else if (_peron1Yanlis && _peron2Yanlis && _peron3Bitti)
            {
                GameController.instance.isContinue = false;
                GameController.instance.SetScore(100);
                GameController.instance.ScoreCarp(2);
                UIController.instance.ActivateWinScreen();
            }
            else if (_peron1Yanlis && _peron2Bitti && _peron3Yanlis)
            {
                GameController.instance.isContinue = false;
                GameController.instance.SetScore(100);
                GameController.instance.ScoreCarp(2);
                UIController.instance.ActivateWinScreen();
            }
            else if (_peron1Bitti && _peron2Yanlis && _peron3Bitti)
            {
                GameController.instance.isContinue = false;
                GameController.instance.SetScore(100);
                GameController.instance.ScoreCarp(2);
                UIController.instance.ActivateWinScreen();
            }
            else if (_peron1Yanlis && _peron2Yanlis && _peron3Yanlis)
            {
                GameController.instance.isContinue = false;
                GameController.instance.SetScore(0);
                UIController.instance.ActivateLooseScreen();
            }
            else
            {

            }
        }

    }


    //--------------PERON 3 KELIME KONTROL ETME------------------------------------------------------------------------------------------------------------------------------------------------------



    public void Peron3KelimeleriKontrolEt()
    {
        if (_peron3gelenkelime.Count == 1 && _peron3kelimeliste.Count >= 3)
        {
            if (_peron3kelime[0].ToString() == _peron3gelenkelime[0].ToString())
            {
                transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().color = Color.green;
            }
            else
            {
                transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().color = Color.red;
            }
        }
        else
        {
            if (_peron3gelenkelime.Count == 0)
            {
                transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().color = Color.white;
            }
            else
            {

            }

        }

        if (_peron3gelenkelime.Count == 2 && _peron3kelimeliste.Count >= 3)
        {
            if (_peron3kelime[1].ToString() == _peron3gelenkelime[1].ToString())
            {
                transform.GetChild(2).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().color = Color.green;
            }
            else
            {
                transform.GetChild(2).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().color = Color.red;
            }
        }
        else
        {
            if (_peron3gelenkelime.Count == 1)
            {
                transform.GetChild(2).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().color = Color.white;
            }
            else
            {

            }

        }


        if (_peron3gelenkelime.Count == 3 && _peron3kelimeliste.Count >= 3)
        {
            if (_peron3kelime[2].ToString() == _peron3gelenkelime[2].ToString())
            {
                transform.GetChild(2).gameObject.transform.GetChild(2).gameObject.GetComponent<Text>().color = Color.green;

                if (_peron3gelenkelime.Count == 3 && _peron3kelimeliste.Count == 3)
                {
                    if (transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().color == Color.green && transform.GetChild(2).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().color == Color.green && transform.GetChild(2).gameObject.transform.GetChild(2).gameObject.GetComponent<Text>().color == Color.green)
                    {
                        Debug.Log("UCUNCU PERON TAMAMLANDI");
                        _peron3Bariyer.SetActive(true);
                        _peron3Bitti = true;
                    }
                    else
                    {
                        _peron3Yanlis = true;
                        Debug.Log("UCUNCU PERON YANLIS 1");
                    }
                }
                else
                {

                }
            }
            else
            {
                transform.GetChild(2).gameObject.transform.GetChild(2).gameObject.GetComponent<Text>().color = Color.red;

                if (_peron3gelenkelime.Count == 3 && _peron3kelimeliste.Count == 3)
                {
                    _peron3Yanlis = true;
                    Debug.Log("UCUNCU PERON YANLIS 2");

                }
                else
                {

                }
            }
        }
        else
        {
            if (_peron3gelenkelime.Count == 2 && _peron3kelimeliste.Count >= 3)
            {
                transform.GetChild(2).gameObject.transform.GetChild(2).gameObject.GetComponent<Text>().color = Color.white;
                _peron3Yanlis = false;
            }
            else
            {

            }

        }

        if (_peron3gelenkelime.Count == 4 && _peron3kelimeliste.Count >= 4)
        {
            if (_peron3kelime[3].ToString() == _peron3gelenkelime[3].ToString())
            {
                transform.GetChild(2).gameObject.transform.GetChild(3).gameObject.GetComponent<Text>().color = Color.green;

                if (_peron3gelenkelime.Count == 4 && _peron3kelimeliste.Count == 4)
                {
                    if (transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().color == Color.green && transform.GetChild(2).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().color == Color.green && transform.GetChild(2).gameObject.transform.GetChild(2).gameObject.GetComponent<Text>().color == Color.green && transform.GetChild(2).gameObject.transform.GetChild(3).gameObject.GetComponent<Text>().color == Color.green)
                    {
                        Debug.Log("UCUNCU PERON TAMAMLANDI");
                        _peron3Bariyer.SetActive(true);
                        _peron3Bitti = true;
                    }
                    else
                    {
                        _peron3Yanlis = true;
                        Debug.Log("UCUNCU PERON YANLIS 3");
                    }
                }
                else
                {

                }
            }
            else
            {
                transform.GetChild(2).gameObject.transform.GetChild(3).gameObject.GetComponent<Text>().color = Color.red;

                if (_peron3gelenkelime.Count == 4 && _peron3kelimeliste.Count == 4)
                {
                    _peron3Yanlis = true;
                    Debug.Log("UCUNCU PERON YANLIS 4");

                }
                else
                {

                }
            }
        }
        else
        {
            if (_peron3gelenkelime.Count == 3 && _peron3kelimeliste.Count >= 4)
            {
                transform.GetChild(2).gameObject.transform.GetChild(3).gameObject.GetComponent<Text>().color = Color.white;
                _peron3Yanlis = false;
            }
            else
            {

            }

        }

        if (_peron3gelenkelime.Count == 5 && _peron3kelimeliste.Count >= 5)
        {
            if (_peron3kelime[4].ToString() == _peron3gelenkelime[4].ToString())
            {
                transform.GetChild(2).gameObject.transform.GetChild(4).gameObject.GetComponent<Text>().color = Color.green;

                if (_peron3gelenkelime.Count == 5 && _peron3kelimeliste.Count == 5)
                {
                    if (transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().color == Color.green && transform.GetChild(2).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().color == Color.green && transform.GetChild(2).gameObject.transform.GetChild(2).gameObject.GetComponent<Text>().color == Color.green && transform.GetChild(2).gameObject.transform.GetChild(3).gameObject.GetComponent<Text>().color == Color.green && transform.GetChild(2).gameObject.transform.GetChild(4).gameObject.GetComponent<Text>().color == Color.green)
                    {
                        Debug.Log("UCUNCU PERON TAMAMLANDI");
                        _peron3Bariyer.SetActive(true);
                        _peron3Bitti = true;
                    }
                    else
                    {
                        _peron3Yanlis = true;
                        Debug.Log("UCUNCU PERON YANLIS 5");
                    }
                }
                else
                {

                }
            }
            else
            {
                transform.GetChild(2).gameObject.transform.GetChild(4).gameObject.GetComponent<Text>().color = Color.red;

                if (_peron3gelenkelime.Count == 5 && _peron3kelimeliste.Count == 5)
                {
                    _peron3Yanlis = true;
                    Debug.Log("UCUNCU PERON YANLIS 6");

                }
                else
                {

                }
            }
        }
        else
        {
            if (_peron3gelenkelime.Count == 4 && _peron3kelimeliste.Count >= 5)
            {
                transform.GetChild(2).gameObject.transform.GetChild(4).gameObject.GetComponent<Text>().color = Color.white;
                _peron3Yanlis = false;
            }
            else
            {

            }

        }

        if (_peron3gelenkelime.Count == 6 && _peron3kelimeliste.Count >= 6)
        {
            if (_peron3kelime[5].ToString() == _peron3gelenkelime[5].ToString())
            {
                transform.GetChild(2).gameObject.transform.GetChild(5).gameObject.GetComponent<Text>().color = Color.green;

                if (_peron3gelenkelime.Count == 6 && _peron3kelimeliste.Count == 6)
                {
                    if (transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().color == Color.green && transform.GetChild(2).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().color == Color.green && transform.GetChild(2).gameObject.transform.GetChild(2).gameObject.GetComponent<Text>().color == Color.green && transform.GetChild(2).gameObject.transform.GetChild(3).gameObject.GetComponent<Text>().color == Color.green && transform.GetChild(2).gameObject.transform.GetChild(4).gameObject.GetComponent<Text>().color == Color.green && transform.GetChild(2).gameObject.transform.GetChild(5).gameObject.GetComponent<Text>().color == Color.green)
                    {
                        Debug.Log("UCUNCU PERON TAMAMLANDI");
                        _peron3Bariyer.SetActive(true);
                        _peron3Bitti = true;
                    }
                    else
                    {
                        _peron3Yanlis = true;
                        Debug.Log("UCUNCU PERON YANLIS 7");
                    }
                }
                else
                {

                }
            }
            else
            {
                transform.GetChild(2).gameObject.transform.GetChild(5).gameObject.GetComponent<Text>().color = Color.red;

                if (_peron3gelenkelime.Count == 6 && _peron3kelimeliste.Count == 6)
                {
                    _peron3Yanlis = true;
                    Debug.Log("UCUNCU PERON YANLIS 8");

                }
                else
                {

                }
            }
        }
        else
        {
            if (_peron3gelenkelime.Count == 5 && _peron3kelimeliste.Count >= 6)
            {
                transform.GetChild(2).gameObject.transform.GetChild(5).gameObject.GetComponent<Text>().color = Color.white;
                _peron3Yanlis = false;
            }
            else
            {

            }

        }

        if (_level1)
        {
            if (_peron1Bitti && _peron2Bitti)
            {
                GameController.instance.isContinue = false;
                GameController.instance.SetScore(100);
                GameController.instance.ScoreCarp(2);
                UIController.instance.ActivateWinScreen();
            }
            else if (_peron1Bitti && _peron2Yanlis)
            {
                GameController.instance.isContinue = false;
                GameController.instance.SetScore(100);
                GameController.instance.ScoreCarp(1);
                UIController.instance.ActivateWinScreen();
            }
            else if (_peron1Yanlis && _peron2Bitti)
            {
                GameController.instance.isContinue = false;
                GameController.instance.SetScore(100);
                GameController.instance.ScoreCarp(1);
                UIController.instance.ActivateWinScreen();
            }
            else if (_peron1Yanlis && _peron2Yanlis)
            {
                GameController.instance.isContinue = false;
                GameController.instance.SetScore(0);
                UIController.instance.ActivateLooseScreen();
            }
            else
            {

            }
        }
        else
        {
            if (_peron1Bitti && _peron2Bitti && _peron3Bitti)
            {
                GameController.instance.isContinue = false;
                GameController.instance.SetScore(100);
                GameController.instance.ScoreCarp(3);
                UIController.instance.ActivateWinScreen();
            }
            else if (_peron1Bitti && _peron2Bitti && _peron3Yanlis)
            {
                GameController.instance.isContinue = false;
                GameController.instance.SetScore(100);
                GameController.instance.ScoreCarp(2);
                UIController.instance.ActivateWinScreen();
            }
            else if (_peron1Bitti && _peron2Yanlis && _peron3Yanlis)
            {
                GameController.instance.isContinue = false;
                GameController.instance.SetScore(100);
                GameController.instance.ScoreCarp(2);
                UIController.instance.ActivateWinScreen();
            }
            else if (_peron1Yanlis && _peron2Bitti && _peron3Bitti)
            {
                GameController.instance.isContinue = false;
                GameController.instance.SetScore(100);
                GameController.instance.ScoreCarp(2);
                UIController.instance.ActivateWinScreen();
            }
            else if (_peron1Yanlis && _peron2Yanlis && _peron3Bitti)
            {
                GameController.instance.isContinue = false;
                GameController.instance.SetScore(100);
                GameController.instance.ScoreCarp(2);
                UIController.instance.ActivateWinScreen();
            }
            else if (_peron1Yanlis && _peron2Bitti && _peron3Yanlis)
            {
                GameController.instance.isContinue = false;
                GameController.instance.SetScore(100);
                GameController.instance.ScoreCarp(2);
                UIController.instance.ActivateWinScreen();
            }
            else if (_peron1Bitti && _peron2Yanlis && _peron3Bitti)
            {
                GameController.instance.isContinue = false;
                GameController.instance.SetScore(100);
                GameController.instance.ScoreCarp(2);
                UIController.instance.ActivateWinScreen();
            }
            else if (_peron1Yanlis && _peron2Yanlis && _peron3Yanlis)
            {
                GameController.instance.isContinue = false;
                GameController.instance.SetScore(0);
                UIController.instance.ActivateLooseScreen();
            }
            else
            {

            }
        }

    }


    [System.Obsolete]
    private void PeronaKelimeYazdır()
    {

        //--------------PERON 1 KELIME YAZDIRMA------------------------------------------------------------------------------------------------------------------------------------------------------

        if (transform.FindChild("Peron1Kelime") != null)
        {
            int kacharfli;

            if (_level1)
            {
                kacharfli = 3;
            }
            else
            {
                //kacharfli = Random.Range(1, 4);
                kacharfli = _peron1HarfSayisi;
            }

            if (kacharfli == 3)
            {
                //_peron1kelime = _kelimeListesi._3HarfliKelimeler[Random.Range(0, _kelimeListesi._3HarfliKelimeler.Count)].ToCharArray();

                for (int i = 0; i < 3; i++)
                {
                    _peron1kelimeliste.Add(_peron1kelime[i]);
                }


                if (transform.GetChild(0).gameObject.transform.FindChild("Harf1") != null)
                {
                    if (_peron1kelime[0].ToString() != null)
                    {
                        transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = _peron1kelime[0].ToString();
                    }
                    else
                    {
                        transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = " ";
                    }

                }
                else
                {

                }

                if (transform.GetChild(0).gameObject.transform.FindChild("Harf2") != null)
                {
                    if (_peron1kelime[1].ToString() != null)
                    {
                        transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().text = _peron1kelime[1].ToString();
                    }
                    else
                    {
                        transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().text = " ";
                    }
                }
                else
                {

                }

                if (transform.GetChild(0).gameObject.transform.FindChild("Harf3") != null)
                {
                    if (_peron1kelime[2].ToString() != null)
                    {
                        transform.GetChild(0).gameObject.transform.GetChild(2).gameObject.GetComponent<Text>().text = _peron1kelime[2].ToString();
                    }
                    else
                    {
                        transform.GetChild(0).gameObject.transform.GetChild(2).gameObject.GetComponent<Text>().text = " ";
                    }
                }
                else
                {

                }

                if (transform.GetChild(0).gameObject.transform.FindChild("Harf4") != null)
                {

                    transform.GetChild(0).gameObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = " ";

                }
                else
                {

                }

                if (transform.GetChild(0).gameObject.transform.FindChild("Harf5") != null)
                {

                    transform.GetChild(0).gameObject.transform.GetChild(4).gameObject.GetComponent<Text>().text = " ";

                }
                else
                {

                }

                if (transform.GetChild(0).gameObject.transform.FindChild("Harf6") != null)
                {

                    transform.GetChild(0).gameObject.transform.GetChild(5).gameObject.GetComponent<Text>().text = " ";

                }
                else
                {

                }
            }
            else if (kacharfli == 4)
            {
                //_peron1kelime = _kelimeListesi._4HarfliKelimeler[Random.Range(0, _kelimeListesi._4HarfliKelimeler.Count)].ToCharArray();

                for (int i = 0; i < 4; i++)
                {
                    _peron1kelimeliste.Add(_peron1kelime[i]);
                }

                if (transform.GetChild(0).gameObject.transform.FindChild("Harf1") != null)
                {
                    if (_peron1kelime[0].ToString() != null)
                    {
                        transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = _peron1kelime[0].ToString();
                    }
                    else
                    {
                        transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = " ";
                    }

                }
                else
                {

                }

                if (transform.GetChild(0).gameObject.transform.FindChild("Harf2") != null)
                {
                    if (_peron1kelime[1].ToString() != null)
                    {
                        transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().text = _peron1kelime[1].ToString();
                    }
                    else
                    {
                        transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().text = " ";
                    }
                }
                else
                {

                }

                if (transform.GetChild(0).gameObject.transform.FindChild("Harf3") != null)
                {
                    if (_peron1kelime[2].ToString() != null)
                    {
                        transform.GetChild(0).gameObject.transform.GetChild(2).gameObject.GetComponent<Text>().text = _peron1kelime[2].ToString();
                    }
                    else
                    {
                        transform.GetChild(0).gameObject.transform.GetChild(2).gameObject.GetComponent<Text>().text = " ";
                    }
                }
                else
                {

                }

                if (transform.GetChild(0).gameObject.transform.FindChild("Harf4") != null)
                {
                    if (_peron1kelime[3].ToString() != null)
                    {
                        transform.GetChild(0).gameObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = _peron1kelime[3].ToString();
                    }
                    else
                    {
                        transform.GetChild(0).gameObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = " ";
                    }
                }
                else
                {

                }

                if (transform.GetChild(0).gameObject.transform.FindChild("Harf5") != null)
                {

                    transform.GetChild(0).gameObject.transform.GetChild(4).gameObject.GetComponent<Text>().text = " ";

                }
                else
                {

                }

                if (transform.GetChild(0).gameObject.transform.FindChild("Harf6") != null)
                {

                    transform.GetChild(0).gameObject.transform.GetChild(5).gameObject.GetComponent<Text>().text = " ";

                }
                else
                {

                }
            }
            else if (kacharfli == 5)
            {
                //_peron1kelime = _kelimeListesi._5HarfliKelimeler[Random.Range(0, _kelimeListesi._5HarfliKelimeler.Count)].ToCharArray();

                for (int i = 0; i < 5; i++)
                {
                    _peron1kelimeliste.Add(_peron1kelime[i]);
                }

                if (transform.GetChild(0).gameObject.transform.FindChild("Harf1") != null)
                {
                    if (_peron1kelime[0].ToString() != null)
                    {
                        transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = _peron1kelime[0].ToString();
                    }
                    else
                    {
                        transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = " ";
                    }

                }
                else
                {

                }

                if (transform.GetChild(0).gameObject.transform.FindChild("Harf2") != null)
                {
                    if (_peron1kelime[1].ToString() != null)
                    {
                        transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().text = _peron1kelime[1].ToString();
                    }
                    else
                    {
                        transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().text = " ";
                    }
                }
                else
                {

                }

                if (transform.GetChild(0).gameObject.transform.FindChild("Harf3") != null)
                {
                    if (_peron1kelime[2].ToString() != null)
                    {
                        transform.GetChild(0).gameObject.transform.GetChild(2).gameObject.GetComponent<Text>().text = _peron1kelime[2].ToString();
                    }
                    else
                    {
                        transform.GetChild(0).gameObject.transform.GetChild(2).gameObject.GetComponent<Text>().text = " ";
                    }
                }
                else
                {

                }

                if (transform.GetChild(0).gameObject.transform.FindChild("Harf4") != null)
                {
                    if (_peron1kelime[3].ToString() != null)
                    {
                        transform.GetChild(0).gameObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = _peron1kelime[3].ToString();
                    }
                    else
                    {
                        transform.GetChild(0).gameObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = " ";
                    }
                }
                else
                {

                }

                if (transform.GetChild(0).gameObject.transform.FindChild("Harf5") != null)
                {
                    if (_peron1kelime[4].ToString() != null)
                    {
                        transform.GetChild(0).gameObject.transform.GetChild(4).gameObject.GetComponent<Text>().text = _peron1kelime[4].ToString();
                    }
                    else
                    {
                        transform.GetChild(0).gameObject.transform.GetChild(4).gameObject.GetComponent<Text>().text = " ";
                    }
                }
                else
                {

                }

                if (transform.GetChild(0).gameObject.transform.FindChild("Harf6") != null)
                {

                    transform.GetChild(0).gameObject.transform.GetChild(5).gameObject.GetComponent<Text>().text = " ";

                }
                else
                {

                }
            }
            else if (kacharfli == 6)
            {
                //_peron1kelime = _kelimeListesi._6HarfliKelimeler[Random.Range(0, _kelimeListesi._6HarfliKelimeler.Count)].ToCharArray();

                for (int i = 0; i < 6; i++)
                {
                    _peron1kelimeliste.Add(_peron1kelime[i]);
                }

                if (transform.GetChild(0).gameObject.transform.FindChild("Harf1") != null)
                {
                    if (_peron1kelime[0].ToString() != null)
                    {
                        transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = _peron1kelime[0].ToString();
                    }
                    else
                    {
                        transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = " ";
                    }

                }
                else
                {

                }

                if (transform.GetChild(0).gameObject.transform.FindChild("Harf2") != null)
                {
                    if (_peron1kelime[1].ToString() != null)
                    {
                        transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().text = _peron1kelime[1].ToString();
                    }
                    else
                    {
                        transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().text = " ";
                    }
                }
                else
                {

                }

                if (transform.GetChild(0).gameObject.transform.FindChild("Harf3") != null)
                {
                    if (_peron1kelime[2].ToString() != null)
                    {
                        transform.GetChild(0).gameObject.transform.GetChild(2).gameObject.GetComponent<Text>().text = _peron1kelime[2].ToString();
                    }
                    else
                    {
                        transform.GetChild(0).gameObject.transform.GetChild(2).gameObject.GetComponent<Text>().text = " ";
                    }
                }
                else
                {

                }

                if (transform.GetChild(0).gameObject.transform.FindChild("Harf4") != null)
                {
                    if (_peron1kelime[3].ToString() != null)
                    {
                        transform.GetChild(0).gameObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = _peron1kelime[3].ToString();
                    }
                    else
                    {
                        transform.GetChild(0).gameObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = " ";
                    }
                }
                else
                {

                }

                if (transform.GetChild(0).gameObject.transform.FindChild("Harf5") != null)
                {
                    if (_peron1kelime[4].ToString() != null)
                    {
                        transform.GetChild(0).gameObject.transform.GetChild(4).gameObject.GetComponent<Text>().text = _peron1kelime[4].ToString();
                    }
                    else
                    {
                        transform.GetChild(0).gameObject.transform.GetChild(4).gameObject.GetComponent<Text>().text = " ";
                    }
                }
                else
                {

                }

                if (transform.GetChild(0).gameObject.transform.FindChild("Harf6") != null)
                {
                    if (_peron1kelime[5].ToString() != null)
                    {
                        transform.GetChild(0).gameObject.transform.GetChild(5).gameObject.GetComponent<Text>().text = _peron1kelime[5].ToString();
                    }
                    else
                    {
                        transform.GetChild(0).gameObject.transform.GetChild(5).gameObject.GetComponent<Text>().text = " ";
                    }
                }
                else
                {

                }
            }
            else
            {

            }






        }
        else
        {
            Debug.Log("Boyle Bir Sey Yok AGA");
        }



        //--------------PERON 2 KELIME YAZDIRMA------------------------------------------------------------------------------------------------------------------------------------------------------

        if (transform.FindChild("Peron2Kelime") != null)
        {
            int kacharfli;

            if (_level1)
            {
                kacharfli = 3;
            }
            else
            {
                //kacharfli = Random.Range(1, 4);
                kacharfli = _peron2HarfSayisi;
            }

            if (kacharfli == 3)
            {
                //_peron2kelime = _kelimeListesi._3HarfliKelimeler[Random.Range(0, _kelimeListesi._3HarfliKelimeler.Count)].ToCharArray();

                for (int i = 0; i < 3; i++)
                {
                    _peron2kelimeliste.Add(_peron2kelime[i]);
                }


                if (transform.GetChild(1).gameObject.transform.FindChild("Harf1") != null)
                {
                    if (_peron2kelime[0].ToString() != null)
                    {
                        transform.GetChild(1).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = _peron2kelime[0].ToString();
                    }
                    else
                    {
                        transform.GetChild(1).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = " ";
                    }

                }
                else
                {

                }

                if (transform.GetChild(1).gameObject.transform.FindChild("Harf2") != null)
                {
                    if (_peron2kelime[1].ToString() != null)
                    {
                        transform.GetChild(1).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().text = _peron2kelime[1].ToString();
                    }
                    else
                    {
                        transform.GetChild(1).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().text = " ";
                    }
                }
                else
                {

                }

                if (transform.GetChild(1).gameObject.transform.FindChild("Harf3") != null)
                {
                    if (_peron2kelime[2].ToString() != null)
                    {
                        transform.GetChild(1).gameObject.transform.GetChild(2).gameObject.GetComponent<Text>().text = _peron2kelime[2].ToString();
                    }
                    else
                    {
                        transform.GetChild(1).gameObject.transform.GetChild(2).gameObject.GetComponent<Text>().text = " ";
                    }
                }
                else
                {

                }

                if (transform.GetChild(1).gameObject.transform.FindChild("Harf4") != null)
                {

                    transform.GetChild(1).gameObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = " ";

                }
                else
                {

                }

                if (transform.GetChild(1).gameObject.transform.FindChild("Harf5") != null)
                {

                    transform.GetChild(1).gameObject.transform.GetChild(4).gameObject.GetComponent<Text>().text = " ";

                }
                else
                {

                }

                if (transform.GetChild(1).gameObject.transform.FindChild("Harf6") != null)
                {

                    transform.GetChild(1).gameObject.transform.GetChild(5).gameObject.GetComponent<Text>().text = " ";

                }
                else
                {

                }
            }
            else if (kacharfli == 4)
            {
                //_peron2kelime = _kelimeListesi._4HarfliKelimeler[Random.Range(0, _kelimeListesi._4HarfliKelimeler.Count)].ToCharArray();

                for (int i = 0; i < 4; i++)
                {
                    _peron2kelimeliste.Add(_peron2kelime[i]);
                }

                if (transform.GetChild(1).gameObject.transform.FindChild("Harf1") != null)
                {
                    if (_peron2kelime[0].ToString() != null)
                    {
                        transform.GetChild(1).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = _peron2kelime[0].ToString();
                    }
                    else
                    {
                        transform.GetChild(1).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = " ";
                    }

                }
                else
                {

                }

                if (transform.GetChild(1).gameObject.transform.FindChild("Harf2") != null)
                {
                    if (_peron2kelime[1].ToString() != null)
                    {
                        transform.GetChild(1).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().text = _peron2kelime[1].ToString();
                    }
                    else
                    {
                        transform.GetChild(1).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().text = " ";
                    }
                }
                else
                {

                }

                if (transform.GetChild(1).gameObject.transform.FindChild("Harf3") != null)
                {
                    if (_peron2kelime[2].ToString() != null)
                    {
                        transform.GetChild(1).gameObject.transform.GetChild(2).gameObject.GetComponent<Text>().text = _peron2kelime[2].ToString();
                    }
                    else
                    {
                        transform.GetChild(1).gameObject.transform.GetChild(2).gameObject.GetComponent<Text>().text = " ";
                    }
                }
                else
                {

                }

                if (transform.GetChild(1).gameObject.transform.FindChild("Harf4") != null)
                {
                    if (_peron2kelime[3].ToString() != null)
                    {
                        transform.GetChild(1).gameObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = _peron2kelime[3].ToString();
                    }
                    else
                    {
                        transform.GetChild(1).gameObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = " ";
                    }
                }
                else
                {

                }

                if (transform.GetChild(1).gameObject.transform.FindChild("Harf5") != null)
                {

                    transform.GetChild(1).gameObject.transform.GetChild(4).gameObject.GetComponent<Text>().text = " ";

                }
                else
                {

                }

                if (transform.GetChild(1).gameObject.transform.FindChild("Harf6") != null)
                {

                    transform.GetChild(1).gameObject.transform.GetChild(5).gameObject.GetComponent<Text>().text = " ";

                }
                else
                {

                }
            }
            else if (kacharfli == 5)
            {
                //_peron2kelime = _kelimeListesi._5HarfliKelimeler[Random.Range(0, _kelimeListesi._5HarfliKelimeler.Count)].ToCharArray();

                for (int i = 0; i < 5; i++)
                {
                    _peron2kelimeliste.Add(_peron2kelime[i]);
                }

                if (transform.GetChild(1).gameObject.transform.FindChild("Harf1") != null)
                {
                    if (_peron2kelime[0].ToString() != null)
                    {
                        transform.GetChild(1).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = _peron2kelime[0].ToString();
                    }
                    else
                    {
                        transform.GetChild(1).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = " ";
                    }

                }
                else
                {

                }

                if (transform.GetChild(1).gameObject.transform.FindChild("Harf2") != null)
                {
                    if (_peron2kelime[1].ToString() != null)
                    {
                        transform.GetChild(1).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().text = _peron2kelime[1].ToString();
                    }
                    else
                    {
                        transform.GetChild(1).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().text = " ";
                    }
                }
                else
                {

                }

                if (transform.GetChild(1).gameObject.transform.FindChild("Harf3") != null)
                {
                    if (_peron2kelime[2].ToString() != null)
                    {
                        transform.GetChild(1).gameObject.transform.GetChild(2).gameObject.GetComponent<Text>().text = _peron2kelime[2].ToString();
                    }
                    else
                    {
                        transform.GetChild(1).gameObject.transform.GetChild(2).gameObject.GetComponent<Text>().text = " ";
                    }
                }
                else
                {

                }

                if (transform.GetChild(1).gameObject.transform.FindChild("Harf4") != null)
                {
                    if (_peron2kelime[3].ToString() != null)
                    {
                        transform.GetChild(1).gameObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = _peron2kelime[3].ToString();
                    }
                    else
                    {
                        transform.GetChild(1).gameObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = " ";
                    }
                }
                else
                {

                }

                if (transform.GetChild(1).gameObject.transform.FindChild("Harf5") != null)
                {
                    if (_peron2kelime[4].ToString() != null)
                    {
                        transform.GetChild(1).gameObject.transform.GetChild(4).gameObject.GetComponent<Text>().text = _peron2kelime[4].ToString();
                    }
                    else
                    {
                        transform.GetChild(1).gameObject.transform.GetChild(4).gameObject.GetComponent<Text>().text = " ";
                    }
                }
                else
                {

                }

                if (transform.GetChild(1).gameObject.transform.FindChild("Harf6") != null)
                {

                    transform.GetChild(1).gameObject.transform.GetChild(5).gameObject.GetComponent<Text>().text = " ";

                }
                else
                {

                }
            }
            else if (kacharfli == 6)
            {
                //_peron2kelime = _kelimeListesi._6HarfliKelimeler[Random.Range(0, _kelimeListesi._6HarfliKelimeler.Count)].ToCharArray();

                for (int i = 0; i < 6; i++)
                {
                    _peron2kelimeliste.Add(_peron2kelime[i]);
                }

                if (transform.GetChild(1).gameObject.transform.FindChild("Harf1") != null)
                {
                    if (_peron2kelime[0].ToString() != null)
                    {
                        transform.GetChild(1).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = _peron2kelime[0].ToString();
                    }
                    else
                    {
                        transform.GetChild(1).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = " ";
                    }

                }
                else
                {

                }

                if (transform.GetChild(1).gameObject.transform.FindChild("Harf2") != null)
                {
                    if (_peron2kelime[1].ToString() != null)
                    {
                        transform.GetChild(1).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().text = _peron2kelime[1].ToString();
                    }
                    else
                    {
                        transform.GetChild(1).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().text = " ";
                    }
                }
                else
                {

                }

                if (transform.GetChild(1).gameObject.transform.FindChild("Harf3") != null)
                {
                    if (_peron2kelime[2].ToString() != null)
                    {
                        transform.GetChild(1).gameObject.transform.GetChild(2).gameObject.GetComponent<Text>().text = _peron2kelime[2].ToString();
                    }
                    else
                    {
                        transform.GetChild(1).gameObject.transform.GetChild(2).gameObject.GetComponent<Text>().text = " ";
                    }
                }
                else
                {

                }

                if (transform.GetChild(1).gameObject.transform.FindChild("Harf4") != null)
                {
                    if (_peron2kelime[3].ToString() != null)
                    {
                        transform.GetChild(1).gameObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = _peron2kelime[3].ToString();
                    }
                    else
                    {
                        transform.GetChild(1).gameObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = " ";
                    }
                }
                else
                {

                }

                if (transform.GetChild(1).gameObject.transform.FindChild("Harf5") != null)
                {
                    if (_peron2kelime[4].ToString() != null)
                    {
                        transform.GetChild(1).gameObject.transform.GetChild(4).gameObject.GetComponent<Text>().text = _peron2kelime[4].ToString();
                    }
                    else
                    {
                        transform.GetChild(1).gameObject.transform.GetChild(4).gameObject.GetComponent<Text>().text = " ";
                    }
                }
                else
                {

                }

                if (transform.GetChild(1).gameObject.transform.FindChild("Harf6") != null)
                {
                    if (_peron2kelime[5].ToString() != null)
                    {
                        transform.GetChild(1).gameObject.transform.GetChild(5).gameObject.GetComponent<Text>().text = _peron2kelime[5].ToString();
                    }
                    else
                    {
                        transform.GetChild(1).gameObject.transform.GetChild(5).gameObject.GetComponent<Text>().text = " ";
                    }
                }
                else
                {

                }
            }
            else
            {

            }






        }
        else
        {
            Debug.Log("Boyle Bir Sey Yok AGA");
        }


        //--------------PERON 3 KELIME YAZDIRMA------------------------------------------------------------------------------------------------------------------------------------------------------

        if (transform.FindChild("Peron3Kelime") != null)
        {
            int kacharfli;

            if (_level1)
            {
                kacharfli = 3;
            }
            else
            {
                //kacharfli = Random.Range(1, 4);
                kacharfli = _peron3HarfSayisi;
            }

            if (kacharfli == 3)
            {
                //_peron3kelime = _kelimeListesi._3HarfliKelimeler[Random.Range(0, _kelimeListesi._3HarfliKelimeler.Count)].ToCharArray();

                for (int i = 0; i < 3; i++)
                {
                    _peron3kelimeliste.Add(_peron3kelime[i]);
                }


                if (transform.GetChild(2).gameObject.transform.FindChild("Harf1") != null)
                {
                    if (_peron3kelime[0].ToString() != null)
                    {
                        transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = _peron3kelime[0].ToString();
                    }
                    else
                    {
                        transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = " ";
                    }

                }
                else
                {

                }

                if (transform.GetChild(2).gameObject.transform.FindChild("Harf2") != null)
                {
                    if (_peron3kelime[1].ToString() != null)
                    {
                        transform.GetChild(2).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().text = _peron3kelime[1].ToString();
                    }
                    else
                    {
                        transform.GetChild(2).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().text = " ";
                    }
                }
                else
                {

                }

                if (transform.GetChild(2).gameObject.transform.FindChild("Harf3") != null)
                {
                    if (_peron3kelime[2].ToString() != null)
                    {
                        transform.GetChild(2).gameObject.transform.GetChild(2).gameObject.GetComponent<Text>().text = _peron3kelime[2].ToString();
                    }
                    else
                    {
                        transform.GetChild(2).gameObject.transform.GetChild(2).gameObject.GetComponent<Text>().text = " ";
                    }
                }
                else
                {

                }

                if (transform.GetChild(2).gameObject.transform.FindChild("Harf4") != null)
                {

                    transform.GetChild(2).gameObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = " ";

                }
                else
                {

                }

                if (transform.GetChild(2).gameObject.transform.FindChild("Harf5") != null)
                {

                    transform.GetChild(2).gameObject.transform.GetChild(4).gameObject.GetComponent<Text>().text = " ";

                }
                else
                {

                }

                if (transform.GetChild(2).gameObject.transform.FindChild("Harf6") != null)
                {

                    transform.GetChild(2).gameObject.transform.GetChild(5).gameObject.GetComponent<Text>().text = " ";

                }
                else
                {

                }
            }
            else if (kacharfli == 4)
            {
                //_peron3kelime = _kelimeListesi._4HarfliKelimeler[Random.Range(0, _kelimeListesi._4HarfliKelimeler.Count)].ToCharArray();

                for (int i = 0; i < 4; i++)
                {
                    _peron3kelimeliste.Add(_peron3kelime[i]);
                }

                if (transform.GetChild(2).gameObject.transform.FindChild("Harf1") != null)
                {
                    if (_peron3kelime[0].ToString() != null)
                    {
                        transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = _peron3kelime[0].ToString();
                    }
                    else
                    {
                        transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = " ";
                    }

                }
                else
                {

                }

                if (transform.GetChild(2).gameObject.transform.FindChild("Harf2") != null)
                {
                    if (_peron3kelime[1].ToString() != null)
                    {
                        transform.GetChild(2).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().text = _peron3kelime[1].ToString();
                    }
                    else
                    {
                        transform.GetChild(2).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().text = " ";
                    }
                }
                else
                {

                }

                if (transform.GetChild(2).gameObject.transform.FindChild("Harf3") != null)
                {
                    if (_peron3kelime[2].ToString() != null)
                    {
                        transform.GetChild(2).gameObject.transform.GetChild(2).gameObject.GetComponent<Text>().text = _peron3kelime[2].ToString();
                    }
                    else
                    {
                        transform.GetChild(2).gameObject.transform.GetChild(2).gameObject.GetComponent<Text>().text = " ";
                    }
                }
                else
                {

                }

                if (transform.GetChild(2).gameObject.transform.FindChild("Harf4") != null)
                {
                    if (_peron3kelime[3].ToString() != null)
                    {
                        transform.GetChild(2).gameObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = _peron3kelime[3].ToString();
                    }
                    else
                    {
                        transform.GetChild(2).gameObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = " ";
                    }
                }
                else
                {

                }

                if (transform.GetChild(2).gameObject.transform.FindChild("Harf5") != null)
                {

                    transform.GetChild(2).gameObject.transform.GetChild(4).gameObject.GetComponent<Text>().text = " ";

                }
                else
                {

                }

                if (transform.GetChild(2).gameObject.transform.FindChild("Harf6") != null)
                {

                    transform.GetChild(2).gameObject.transform.GetChild(5).gameObject.GetComponent<Text>().text = " ";

                }
                else
                {

                }
            }
            else if (kacharfli == 5)
            {
                //_peron3kelime = _kelimeListesi._5HarfliKelimeler[Random.Range(0, _kelimeListesi._5HarfliKelimeler.Count)].ToCharArray();

                for (int i = 0; i < 5; i++)
                {
                    _peron3kelimeliste.Add(_peron3kelime[i]);
                }

                if (transform.GetChild(2).gameObject.transform.FindChild("Harf1") != null)
                {
                    if (_peron3kelime[0].ToString() != null)
                    {
                        transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = _peron3kelime[0].ToString();
                    }
                    else
                    {
                        transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = " ";
                    }

                }
                else
                {

                }

                if (transform.GetChild(2).gameObject.transform.FindChild("Harf2") != null)
                {
                    if (_peron3kelime[1].ToString() != null)
                    {
                        transform.GetChild(2).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().text = _peron3kelime[1].ToString();
                    }
                    else
                    {
                        transform.GetChild(2).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().text = " ";
                    }
                }
                else
                {

                }

                if (transform.GetChild(2).gameObject.transform.FindChild("Harf3") != null)
                {
                    if (_peron3kelime[2].ToString() != null)
                    {
                        transform.GetChild(2).gameObject.transform.GetChild(2).gameObject.GetComponent<Text>().text = _peron3kelime[2].ToString();
                    }
                    else
                    {
                        transform.GetChild(2).gameObject.transform.GetChild(2).gameObject.GetComponent<Text>().text = " ";
                    }
                }
                else
                {

                }

                if (transform.GetChild(2).gameObject.transform.FindChild("Harf4") != null)
                {
                    if (_peron3kelime[3].ToString() != null)
                    {
                        transform.GetChild(2).gameObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = _peron3kelime[3].ToString();
                    }
                    else
                    {
                        transform.GetChild(2).gameObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = " ";
                    }
                }
                else
                {

                }

                if (transform.GetChild(2).gameObject.transform.FindChild("Harf5") != null)
                {
                    if (_peron3kelime[4].ToString() != null)
                    {
                        transform.GetChild(2).gameObject.transform.GetChild(4).gameObject.GetComponent<Text>().text = _peron3kelime[4].ToString();
                    }
                    else
                    {
                        transform.GetChild(2).gameObject.transform.GetChild(4).gameObject.GetComponent<Text>().text = " ";
                    }
                }
                else
                {

                }

                if (transform.GetChild(2).gameObject.transform.FindChild("Harf6") != null)
                {

                    transform.GetChild(2).gameObject.transform.GetChild(5).gameObject.GetComponent<Text>().text = " ";

                }
                else
                {

                }
            }
            else if (kacharfli == 6)
            {
                //_peron3kelime = _kelimeListesi._6HarfliKelimeler[Random.Range(0, _kelimeListesi._6HarfliKelimeler.Count)].ToCharArray();

                for (int i = 0; i < 6; i++)
                {
                    _peron3kelimeliste.Add(_peron3kelime[i]);
                }

                if (transform.GetChild(2).gameObject.transform.FindChild("Harf1") != null)
                {
                    if (_peron3kelime[0].ToString() != null)
                    {
                        transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = _peron3kelime[0].ToString();
                    }
                    else
                    {
                        transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = " ";
                    }

                }
                else
                {

                }

                if (transform.GetChild(2).gameObject.transform.FindChild("Harf2") != null)
                {
                    if (_peron3kelime[1].ToString() != null)
                    {
                        transform.GetChild(2).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().text = _peron3kelime[1].ToString();
                    }
                    else
                    {
                        transform.GetChild(2).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().text = " ";
                    }
                }
                else
                {

                }

                if (transform.GetChild(2).gameObject.transform.FindChild("Harf3") != null)
                {
                    if (_peron3kelime[2].ToString() != null)
                    {
                        transform.GetChild(2).gameObject.transform.GetChild(2).gameObject.GetComponent<Text>().text = _peron3kelime[2].ToString();
                    }
                    else
                    {
                        transform.GetChild(2).gameObject.transform.GetChild(2).gameObject.GetComponent<Text>().text = " ";
                    }
                }
                else
                {

                }

                if (transform.GetChild(2).gameObject.transform.FindChild("Harf4") != null)
                {
                    if (_peron3kelime[3].ToString() != null)
                    {
                        transform.GetChild(2).gameObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = _peron3kelime[3].ToString();
                    }
                    else
                    {
                        transform.GetChild(2).gameObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = " ";
                    }
                }
                else
                {

                }

                if (transform.GetChild(2).gameObject.transform.FindChild("Harf5") != null)
                {
                    if (_peron3kelime[4].ToString() != null)
                    {
                        transform.GetChild(2).gameObject.transform.GetChild(4).gameObject.GetComponent<Text>().text = _peron3kelime[4].ToString();
                    }
                    else
                    {
                        transform.GetChild(2).gameObject.transform.GetChild(4).gameObject.GetComponent<Text>().text = " ";
                    }
                }
                else
                {

                }

                if (transform.GetChild(2).gameObject.transform.FindChild("Harf6") != null)
                {
                    if (_peron3kelime[5].ToString() != null)
                    {
                        transform.GetChild(2).gameObject.transform.GetChild(5).gameObject.GetComponent<Text>().text = _peron3kelime[5].ToString();
                    }
                    else
                    {
                        transform.GetChild(2).gameObject.transform.GetChild(5).gameObject.GetComponent<Text>().text = " ";
                    }
                }
                else
                {

                }
            }
            else
            {

            }






        }
        else
        {
            Debug.Log("Boyle Bir Sey Yok AGA");
        }
    }
}
