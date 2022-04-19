using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelCanvasScript : MonoBehaviour
{

    public static LevelCanvasScript instance;

    public bool _level1;

    private KelimeListesi _kelimeListesi;

    public char[] _peron1kelime;
    public char[] _peron2kelime;
    public char[] _peron3kelime;

    public List<char> _peron1gelenkelime = new List<char>();


    public List<char> _peron1kelimeliste = new List<char>();
    public List<char> _peron2kelimeliste = new List<char>();
    public List<char> _peron3kelimeliste = new List<char>();


    private void Awake()
    {
        if (instance == null) instance = this;
        //else Destroy(this);
    }


    [System.Obsolete]
    void Start()
    {
        _kelimeListesi = GameObject.FindGameObjectWithTag("KelimeListesi").GetComponent<KelimeListesi>();
        PeronaKelimeYazdır();

    }


    void Update()
    {

    }

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

        }


        if (_peron1gelenkelime.Count == 3 && _peron1kelimeliste.Count >= 3)
        {
            if (_peron1kelime[2].ToString() == _peron1gelenkelime[2].ToString())
            {
                transform.GetChild(0).gameObject.transform.GetChild(2).gameObject.GetComponent<Text>().color = Color.green;
            }
            else
            {
                transform.GetChild(0).gameObject.transform.GetChild(2).gameObject.GetComponent<Text>().color = Color.red;
            }
        }
        else
        {

        }

        if (_peron1gelenkelime.Count == 4 && _peron1kelimeliste.Count >= 4)
        {
            if (_peron1kelime[3].ToString() == _peron1gelenkelime[3].ToString())
            {
                transform.GetChild(0).gameObject.transform.GetChild(3).gameObject.GetComponent<Text>().color = Color.green;
            }
            else
            {
                transform.GetChild(0).gameObject.transform.GetChild(3).gameObject.GetComponent<Text>().color = Color.red;
            }
        }
        else
        {

        }

        if (_peron1gelenkelime.Count == 5 && _peron1kelimeliste.Count >= 5)
        {
            if (_peron1kelime[4].ToString() == _peron1gelenkelime[4].ToString())
            {
                transform.GetChild(0).gameObject.transform.GetChild(4).gameObject.GetComponent<Text>().color = Color.green;
            }
            else
            {
                transform.GetChild(0).gameObject.transform.GetChild(4).gameObject.GetComponent<Text>().color = Color.red;
            }
        }
        else
        {

        }

        if (_peron1gelenkelime.Count == 6 && _peron1kelimeliste.Count >= 6)
        {
            if (_peron1kelime[5].ToString() == _peron1gelenkelime[5].ToString())
            {
                transform.GetChild(0).gameObject.transform.GetChild(5).gameObject.GetComponent<Text>().color = Color.green;
            }
            else
            {
                transform.GetChild(0).gameObject.transform.GetChild(5).gameObject.GetComponent<Text>().color = Color.red;
            }
        }
        else
        {

        }



    }


    [System.Obsolete]
    private void PeronaKelimeYazdır()
    {


        if (transform.FindChild("Peron1Kelime") != null)
        {
            int kacharfli;

            if (_level1)
            {
                kacharfli = 0;
            }
            else
            {
                kacharfli = Random.Range(0, 4);
            }

            if (kacharfli == 0)
            {
                _peron1kelime = _kelimeListesi._3HarfliKelimeler[Random.Range(0, _kelimeListesi._3HarfliKelimeler.Count)].ToCharArray();

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
            else if (kacharfli == 1)
            {
                _peron1kelime = _kelimeListesi._4HarfliKelimeler[Random.Range(0, _kelimeListesi._4HarfliKelimeler.Count)].ToCharArray();

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
            else if (kacharfli == 2)
            {
                _peron1kelime = _kelimeListesi._5HarfliKelimeler[Random.Range(0, _kelimeListesi._5HarfliKelimeler.Count)].ToCharArray();

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
            else if (kacharfli == 3)
            {
                _peron1kelime = _kelimeListesi._6HarfliKelimeler[Random.Range(0, _kelimeListesi._6HarfliKelimeler.Count)].ToCharArray();

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
    }
}
