using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RightStationControl : MonoBehaviour
{

    public List<Text> _harfler = new List<Text>();

    public GameObject firstLetterColor;
    public GameObject secondLetterColor;
    public GameObject thirdLetterColor;

    private KelimeListesi _kelimeListesi;

    private string _kelime;

    void Start()
    {
        _kelimeListesi = GameObject.FindGameObjectWithTag("KelimeListesi").GetComponent<KelimeListesi>();
        _kelime = _kelimeListesi._3HarfliKelimeler[1];

        _harfler[0].text = _kelime[0].ToString();
        _harfler[1].text = _kelime[1].ToString();
        _harfler[2].text = _kelime[2].ToString();
        _harfler[3].text = "";
        _harfler[4].text = "";
        _harfler[5].text = "";
    }

}
