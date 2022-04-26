using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using DG.Tweening;
public class CubeScript : MonoBehaviour
{
    public GameObject target;
    public GameObject donenRay;
    public GameObject bariyerSol;
    public GameObject bariyerOrta;
    public GameObject bariyerSag;
    public GameObject bariyerEmpty1;
    public GameObject bariyerEmpty2;

    GameObject ArrowControl;
    GameObject TurnDirection;

    public string _tasidigiHarf;

    public bool _bombaMi;

    private LevelCanvasScript _levelCanvasScript;

    public ParticleSystem _bombaPatlamaEfekt;

    private bool _ucacak;


    void Start()
    {
        if (_bombaMi)
        {

        }
        else
        {
            _tasidigiHarf = gameObject.transform.GetChild(6).gameObject.transform.GetChild(0).gameObject.name;
        }

        _ucacak = false;


        Invoke("HareketiBaslat", 1f);

        GetComponent<NavMeshAgent>().enabled = true;
        gameObject.tag = "Untagged";

        ArrowControl = GameObject.FindGameObjectWithTag("ArrowControl");
        TurnDirection = GameObject.FindGameObjectWithTag("turnDirection");


        bariyerSol = GameObject.FindGameObjectWithTag("LeftStation");
        bariyerOrta = GameObject.FindGameObjectWithTag("MidStation");
        bariyerSag = GameObject.FindGameObjectWithTag("RightStation");
        bariyerEmpty1 = GameObject.FindGameObjectWithTag("SolBariyer");
        bariyerEmpty2 = GameObject.FindGameObjectWithTag("SagBariyer");
        donenRay = GameObject.FindGameObjectWithTag("turnDirection");

        _levelCanvasScript = GameObject.FindGameObjectWithTag("LevelCanvas").GetComponent<LevelCanvasScript>();
    }

    private void FixedUpdate()
    {
        if (_ucacak)
        {
            GetComponent<Rigidbody>().AddForce(transform.forward * 10 * Time.timeScale);

            Invoke("ForceKapat", 1f);
        }
        else
        {

        }

    }

    private void ForceKapat()
    {
        _ucacak = false;

        GetComponent<Rigidbody>().useGravity = true;

        gameObject.GetComponent<CubeScript>().enabled = false;
    }

    private void HareketiBaslat()
    {
        transform.DOMove(new Vector3(0, 1, -7), 3).OnComplete(() => turnDonenRay());
    }


    void turnDonenRay()
    {
        //transform.parent = donenRay.transform;
        transform.position = new Vector3(transform.position.x, 1f, transform.position.z);
        if (ArrowControl.GetComponent<SwipeTest>().arrowIsRight)
        {
            target = bariyerSag;
        }

        else if (ArrowControl.GetComponent<SwipeTest>().arrowIsLeft)
        {
            target = bariyerSol;
        }

        else if (ArrowControl.GetComponent<SwipeTest>().arrowIsMid)
        {
            target = bariyerOrta;
        }

        else if (ArrowControl.GetComponent<SwipeTest>().arrowIsLeftBarrier)
        {
            target = bariyerEmpty1;
        }

        else if (ArrowControl.GetComponent<SwipeTest>().arrowIsRightBarrier)
        {
            target = bariyerEmpty2;
        }
        StartCoroutine(nMesh());


    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "LeftStation")
        {
            GetComponent<NavMeshAgent>().enabled = false;
            gameObject.tag = "LeftStop";
            gameObject.GetComponent<CubeScript>().enabled = false;

            if (_bombaMi)
            {
                _bombaPatlamaEfekt.Play();
                Destroy(gameObject, 0.3f);
            }
            else
            {
                LevelCanvasScript.instance._peron1gelenkelime.Add(_tasidigiHarf[0]);
                LevelCanvasScript.instance.Peron1KelimeleriKontrolEt();
            }


            //bariyerSol.GetComponent<LeftStationControl>().eklenenHarfler.Add(gameObject.transform.GetChild(transform.childCount - 1).gameObject);
            TurnDirection.GetComponent<TurnDirection>().newRound = true;

            if (ArrowControl.GetComponent<SwipeTest>()._level1)
            {
                if (_levelCanvasScript._peron1Bitti)
                {
                    ArrowControl.GetComponent<SwipeTest>().leftArrow.SetActive(false);
                    ArrowControl.GetComponent<SwipeTest>().rightArrow.SetActive(true);
                }
                else
                {
                    ArrowControl.GetComponent<SwipeTest>().rightArrow.SetActive(false);
                    ArrowControl.GetComponent<SwipeTest>().leftArrow.SetActive(true);
                }

            }
            else
            {
                if (_levelCanvasScript._peron3Bitti)
                {
                    if (_levelCanvasScript._peron3Bitti && _levelCanvasScript._peron1Bitti)
                    {
                        ArrowControl.GetComponent<SwipeTest>().rightArrow.SetActive(true);
                        ArrowControl.GetComponent<SwipeTest>().leftArrow.SetActive(false);
                        ArrowControl.GetComponent<SwipeTest>().midArrow.SetActive(false);
                    }
                    else
                    {
                        ArrowControl.GetComponent<SwipeTest>().rightArrow.SetActive(false);
                        ArrowControl.GetComponent<SwipeTest>().leftArrow.SetActive(true);
                        ArrowControl.GetComponent<SwipeTest>().midArrow.SetActive(false);
                    }

                }
                else
                {
                    ArrowControl.GetComponent<SwipeTest>().rightArrow.SetActive(false);
                    ArrowControl.GetComponent<SwipeTest>().leftArrow.SetActive(false);
                    ArrowControl.GetComponent<SwipeTest>().midArrow.SetActive(true);
                }

            }


        }

        else if (other.gameObject.tag == "RightStation")
        {
            GetComponent<NavMeshAgent>().enabled = false;
            gameObject.tag = "RightStop";
            gameObject.GetComponent<CubeScript>().enabled = false;

            if (_bombaMi)
            {
                _bombaPatlamaEfekt.Play();
                Destroy(gameObject, 0.3f);
            }
            else
            {
                LevelCanvasScript.instance._peron2gelenkelime.Add(_tasidigiHarf[0]);
                LevelCanvasScript.instance.Peron2KelimeleriKontrolEt();
            }


            //bariyerSag.GetComponent<RightStationControl>().eklenenHarfler.Add(gameObject.transform.GetChild(transform.childCount - 1).gameObject);
            TurnDirection.GetComponent<TurnDirection>().newRound = true;

            if (ArrowControl.GetComponent<SwipeTest>()._level1)
            {
                if (_levelCanvasScript._peron1Bitti)
                {
                    ArrowControl.GetComponent<SwipeTest>().leftArrow.SetActive(false);
                    ArrowControl.GetComponent<SwipeTest>().rightArrow.SetActive(true);
                }
                else
                {
                    ArrowControl.GetComponent<SwipeTest>().rightArrow.SetActive(false);
                    ArrowControl.GetComponent<SwipeTest>().leftArrow.SetActive(true);
                }
            }
            else
            {
                if (_levelCanvasScript._peron3Bitti)
                {
                    if (_levelCanvasScript._peron3Bitti && _levelCanvasScript._peron1Bitti)
                    {
                        ArrowControl.GetComponent<SwipeTest>().rightArrow.SetActive(true);
                        ArrowControl.GetComponent<SwipeTest>().leftArrow.SetActive(false);
                        ArrowControl.GetComponent<SwipeTest>().midArrow.SetActive(false);
                    }
                    else
                    {
                        ArrowControl.GetComponent<SwipeTest>().rightArrow.SetActive(false);
                        ArrowControl.GetComponent<SwipeTest>().leftArrow.SetActive(true);
                        ArrowControl.GetComponent<SwipeTest>().midArrow.SetActive(false);
                    }

                }
                else
                {
                    ArrowControl.GetComponent<SwipeTest>().rightArrow.SetActive(false);
                    ArrowControl.GetComponent<SwipeTest>().leftArrow.SetActive(false);
                    ArrowControl.GetComponent<SwipeTest>().midArrow.SetActive(true);
                }
            }
        }

        else if (other.gameObject.tag == "MidStation")
        {
            GetComponent<NavMeshAgent>().enabled = false;
            gameObject.tag = "MidStop";
            gameObject.GetComponent<CubeScript>().enabled = false;

            if (_bombaMi)
            {
                _bombaPatlamaEfekt.Play();
                Destroy(gameObject, 0.3f);
            }
            else
            {
                LevelCanvasScript.instance._peron3gelenkelime.Add(_tasidigiHarf[0]);
                LevelCanvasScript.instance.Peron3KelimeleriKontrolEt();
            }

            //bariyerOrta.GetComponent<MidStationControl>().eklenenHarfler.Add(gameObject.transform.GetChild(transform.childCount - 1).gameObject);
            TurnDirection.GetComponent<TurnDirection>().newRound = true;

            if (ArrowControl.GetComponent<SwipeTest>()._level1)
            {
                if (_levelCanvasScript._peron1Bitti)
                {
                    ArrowControl.GetComponent<SwipeTest>().leftArrow.SetActive(false);
                    ArrowControl.GetComponent<SwipeTest>().rightArrow.SetActive(true);
                }
                else
                {
                    ArrowControl.GetComponent<SwipeTest>().rightArrow.SetActive(false);
                    ArrowControl.GetComponent<SwipeTest>().leftArrow.SetActive(true);
                }
            }
            else
            {
                if (_levelCanvasScript._peron3Bitti)
                {
                    if (_levelCanvasScript._peron3Bitti && _levelCanvasScript._peron1Bitti)
                    {
                        ArrowControl.GetComponent<SwipeTest>().rightArrow.SetActive(true);
                        ArrowControl.GetComponent<SwipeTest>().leftArrow.SetActive(false);
                        ArrowControl.GetComponent<SwipeTest>().midArrow.SetActive(false);
                    }
                    else
                    {
                        ArrowControl.GetComponent<SwipeTest>().rightArrow.SetActive(false);
                        ArrowControl.GetComponent<SwipeTest>().leftArrow.SetActive(true);
                        ArrowControl.GetComponent<SwipeTest>().midArrow.SetActive(false);
                    }

                }
                else
                {
                    ArrowControl.GetComponent<SwipeTest>().rightArrow.SetActive(false);
                    ArrowControl.GetComponent<SwipeTest>().leftArrow.SetActive(false);
                    ArrowControl.GetComponent<SwipeTest>().midArrow.SetActive(true);
                }
            }
        }

        else if (other.gameObject.tag == "LeftStop")
        {
            GetComponent<NavMeshAgent>().enabled = false;

            gameObject.GetComponent<CubeScript>().enabled = false;

            if (gameObject.tag != "LeftStop")
            {
                if (_bombaMi)
                {
                    LevelCanvasScript.instance._peron1gelenkelime.RemoveAt(LevelCanvasScript.instance._peron1gelenkelime.Count - 1);
                    LevelCanvasScript.instance.Peron1KelimeleriKontrolEt();
                    _bombaPatlamaEfekt.Play();
                    Destroy(other.gameObject, 0.3f);
                    Destroy(gameObject, 0.3f);
                }
                else
                {
                    if (LevelCanvasScript.instance._peron1gelenkelime.Count == 6)
                    {
                        transform.DOMoveY(2, 0.5f);
                        transform.DORotate(new Vector3(0, 0, -90f), 0.5f);
                        Destroy(gameObject, 1f);
                    }
                    else
                    {
                        LevelCanvasScript.instance._peron1gelenkelime.Add(_tasidigiHarf[0]);
                        LevelCanvasScript.instance.Peron1KelimeleriKontrolEt();
                    }

                }
            }
            else
            {

            }

            gameObject.tag = "LeftStop";




            //bariyerSol.GetComponent<LeftStationControl>().eklenenHarfler.Add(gameObject.transform.GetChild(transform.childCount - 1).gameObject);
            TurnDirection.GetComponent<TurnDirection>().newRound = true;

            if (ArrowControl.GetComponent<SwipeTest>()._level1)
            {
                if (_levelCanvasScript._peron1Bitti)
                {
                    ArrowControl.GetComponent<SwipeTest>().leftArrow.SetActive(false);
                    ArrowControl.GetComponent<SwipeTest>().rightArrow.SetActive(true);
                }
                else
                {
                    ArrowControl.GetComponent<SwipeTest>().rightArrow.SetActive(false);
                    ArrowControl.GetComponent<SwipeTest>().leftArrow.SetActive(true);
                }
            }
            else
            {
                if (_levelCanvasScript._peron3Bitti)
                {
                    if (_levelCanvasScript._peron3Bitti && _levelCanvasScript._peron1Bitti)
                    {
                        ArrowControl.GetComponent<SwipeTest>().rightArrow.SetActive(true);
                        ArrowControl.GetComponent<SwipeTest>().leftArrow.SetActive(false);
                        ArrowControl.GetComponent<SwipeTest>().midArrow.SetActive(false);
                    }
                    else
                    {
                        ArrowControl.GetComponent<SwipeTest>().rightArrow.SetActive(false);
                        ArrowControl.GetComponent<SwipeTest>().leftArrow.SetActive(true);
                        ArrowControl.GetComponent<SwipeTest>().midArrow.SetActive(false);
                    }

                }
                else
                {
                    ArrowControl.GetComponent<SwipeTest>().rightArrow.SetActive(false);
                    ArrowControl.GetComponent<SwipeTest>().leftArrow.SetActive(false);
                    ArrowControl.GetComponent<SwipeTest>().midArrow.SetActive(true);
                }
            }
        }
        else if (other.gameObject.tag == "MidStop")
        {
            GetComponent<NavMeshAgent>().enabled = false;

            gameObject.GetComponent<CubeScript>().enabled = false;

            if (gameObject.tag != "MidStop")
            {
                if (_bombaMi)
                {
                    LevelCanvasScript.instance._peron3gelenkelime.RemoveAt(LevelCanvasScript.instance._peron3gelenkelime.Count - 1);
                    LevelCanvasScript.instance.Peron3KelimeleriKontrolEt();
                    _bombaPatlamaEfekt.Play();
                    Destroy(other.gameObject, 0.3f);
                    Destroy(gameObject, 0.3f);
                }
                else
                {
                    if (LevelCanvasScript.instance._peron3gelenkelime.Count == 6)
                    {
                        transform.DOMoveY(2, 0.5f);
                        transform.DORotate(new Vector3(0, 0, -90f), 0.5f);
                        Destroy(gameObject, 1f);
                    }
                    else
                    {
                        LevelCanvasScript.instance._peron3gelenkelime.Add(_tasidigiHarf[0]);
                        LevelCanvasScript.instance.Peron3KelimeleriKontrolEt();
                    }
                }
            }
            else
            {

            }

            gameObject.tag = "MidStop";


            //bariyerOrta.GetComponent<MidStationControl>().eklenenHarfler.Add(gameObject.transform.GetChild(transform.childCount - 1).gameObject);
            TurnDirection.GetComponent<TurnDirection>().newRound = true;

            if (ArrowControl.GetComponent<SwipeTest>()._level1)
            {
                if (_levelCanvasScript._peron1Bitti)
                {
                    ArrowControl.GetComponent<SwipeTest>().leftArrow.SetActive(false);
                    ArrowControl.GetComponent<SwipeTest>().rightArrow.SetActive(true);
                }
                else
                {
                    ArrowControl.GetComponent<SwipeTest>().rightArrow.SetActive(false);
                    ArrowControl.GetComponent<SwipeTest>().leftArrow.SetActive(true);
                }
            }
            else
            {
                if (_levelCanvasScript._peron3Bitti)
                {
                    if (_levelCanvasScript._peron3Bitti && _levelCanvasScript._peron1Bitti)
                    {
                        ArrowControl.GetComponent<SwipeTest>().rightArrow.SetActive(true);
                        ArrowControl.GetComponent<SwipeTest>().leftArrow.SetActive(false);
                        ArrowControl.GetComponent<SwipeTest>().midArrow.SetActive(false);
                    }
                    else
                    {
                        ArrowControl.GetComponent<SwipeTest>().rightArrow.SetActive(false);
                        ArrowControl.GetComponent<SwipeTest>().leftArrow.SetActive(true);
                        ArrowControl.GetComponent<SwipeTest>().midArrow.SetActive(false);
                    }

                }
                else
                {
                    ArrowControl.GetComponent<SwipeTest>().rightArrow.SetActive(false);
                    ArrowControl.GetComponent<SwipeTest>().leftArrow.SetActive(false);
                    ArrowControl.GetComponent<SwipeTest>().midArrow.SetActive(true);
                }
            }
        }

        else if (other.gameObject.tag == "RightStop")
        {
            GetComponent<NavMeshAgent>().enabled = false;

            gameObject.GetComponent<CubeScript>().enabled = false;

            if (gameObject.tag != "RightStop")
            {
                if (_bombaMi)
                {
                    LevelCanvasScript.instance._peron2gelenkelime.RemoveAt(LevelCanvasScript.instance._peron2gelenkelime.Count - 1);
                    LevelCanvasScript.instance.Peron2KelimeleriKontrolEt();
                    _bombaPatlamaEfekt.Play();
                    Destroy(other.gameObject, 0.3f);
                    Destroy(gameObject, 0.3f);
                }
                else
                {
                    if (LevelCanvasScript.instance._peron2gelenkelime.Count == 6)
                    {
                        transform.DOMoveY(2, 0.5f);
                        transform.DORotate(new Vector3(0, 0, -90f), 0.5f);
                        Destroy(gameObject, 1f);
                    }
                    else
                    {
                        LevelCanvasScript.instance._peron2gelenkelime.Add(_tasidigiHarf[0]);
                        LevelCanvasScript.instance.Peron2KelimeleriKontrolEt();
                    }
                }
            }
            else
            {

            }

            gameObject.tag = "RightStop";



            //bariyerSag.GetComponent<RightStationControl>().eklenenHarfler.Add(gameObject.transform.GetChild(transform.childCount - 1).gameObject);
            TurnDirection.GetComponent<TurnDirection>().newRound = true;

            if (ArrowControl.GetComponent<SwipeTest>()._level1)
            {
                if (_levelCanvasScript._peron1Bitti)
                {
                    ArrowControl.GetComponent<SwipeTest>().leftArrow.SetActive(false);
                    ArrowControl.GetComponent<SwipeTest>().rightArrow.SetActive(true);
                }
                else
                {
                    ArrowControl.GetComponent<SwipeTest>().rightArrow.SetActive(false);
                    ArrowControl.GetComponent<SwipeTest>().leftArrow.SetActive(true);
                }
            }
            else
            {
                if (_levelCanvasScript._peron3Bitti)
                {
                    if (_levelCanvasScript._peron3Bitti && _levelCanvasScript._peron1Bitti)
                    {
                        ArrowControl.GetComponent<SwipeTest>().rightArrow.SetActive(true);
                        ArrowControl.GetComponent<SwipeTest>().leftArrow.SetActive(false);
                        ArrowControl.GetComponent<SwipeTest>().midArrow.SetActive(false);
                    }
                    else
                    {
                        ArrowControl.GetComponent<SwipeTest>().rightArrow.SetActive(false);
                        ArrowControl.GetComponent<SwipeTest>().leftArrow.SetActive(true);
                        ArrowControl.GetComponent<SwipeTest>().midArrow.SetActive(false);
                    }

                }
                else
                {
                    ArrowControl.GetComponent<SwipeTest>().rightArrow.SetActive(false);
                    ArrowControl.GetComponent<SwipeTest>().leftArrow.SetActive(false);
                    ArrowControl.GetComponent<SwipeTest>().midArrow.SetActive(true);
                }
            }
        }
        else if (other.gameObject.tag == "turnDirection")
        {
            transform.parent = donenRay.transform;
            //TurnDirection = other.gameObject;
        }
        else if (other.gameObject.tag == "SolBariyer")
        {
            GetComponent<NavMeshAgent>().enabled = false;

            TurnDirection.GetComponent<TurnDirection>().newRound = true;

            if (_levelCanvasScript._peron3Bitti)
            {
                if (_levelCanvasScript._peron3Bitti && _levelCanvasScript._peron1Bitti)
                {
                    ArrowControl.GetComponent<SwipeTest>().barrier1Arrow.SetActive(false);
                    ArrowControl.GetComponent<SwipeTest>().barrier2Arrow.SetActive(false);
                    ArrowControl.GetComponent<SwipeTest>().rightArrow.SetActive(true);
                    ArrowControl.GetComponent<SwipeTest>().leftArrow.SetActive(false);
                    ArrowControl.GetComponent<SwipeTest>().midArrow.SetActive(false);
                }
                else
                {
                    ArrowControl.GetComponent<SwipeTest>().barrier1Arrow.SetActive(false);
                    ArrowControl.GetComponent<SwipeTest>().barrier2Arrow.SetActive(false);
                    ArrowControl.GetComponent<SwipeTest>().rightArrow.SetActive(false);
                    ArrowControl.GetComponent<SwipeTest>().leftArrow.SetActive(true);
                    ArrowControl.GetComponent<SwipeTest>().midArrow.SetActive(false);
                }

            }
            else
            {
                ArrowControl.GetComponent<SwipeTest>().barrier1Arrow.SetActive(false);
                ArrowControl.GetComponent<SwipeTest>().barrier2Arrow.SetActive(false);
                ArrowControl.GetComponent<SwipeTest>().rightArrow.SetActive(false);
                ArrowControl.GetComponent<SwipeTest>().leftArrow.SetActive(false);
                ArrowControl.GetComponent<SwipeTest>().midArrow.SetActive(true);
            }

            //GetComponent<Rigidbody>().useGravity = true;

            //gameObject.GetComponent<CubeScript>().enabled = false;

            _ucacak = true;



            Debug.Log("Force Uygulandı");
        }
        else if (other.gameObject.tag == "SagBariyer")
        {
            GetComponent<NavMeshAgent>().enabled = false;

            TurnDirection.GetComponent<TurnDirection>().newRound = true;

            if (_levelCanvasScript._peron3Bitti)
            {
                if (_levelCanvasScript._peron3Bitti && _levelCanvasScript._peron1Bitti)
                {
                    ArrowControl.GetComponent<SwipeTest>().barrier1Arrow.SetActive(false);
                    ArrowControl.GetComponent<SwipeTest>().barrier2Arrow.SetActive(false);
                    ArrowControl.GetComponent<SwipeTest>().rightArrow.SetActive(true);
                    ArrowControl.GetComponent<SwipeTest>().leftArrow.SetActive(false);
                    ArrowControl.GetComponent<SwipeTest>().midArrow.SetActive(false);
                }
                else
                {
                    ArrowControl.GetComponent<SwipeTest>().barrier1Arrow.SetActive(false);
                    ArrowControl.GetComponent<SwipeTest>().barrier2Arrow.SetActive(false);
                    ArrowControl.GetComponent<SwipeTest>().rightArrow.SetActive(false);
                    ArrowControl.GetComponent<SwipeTest>().leftArrow.SetActive(true);
                    ArrowControl.GetComponent<SwipeTest>().midArrow.SetActive(false);
                }

            }
            else
            {
                ArrowControl.GetComponent<SwipeTest>().barrier1Arrow.SetActive(false);
                ArrowControl.GetComponent<SwipeTest>().barrier2Arrow.SetActive(false);
                ArrowControl.GetComponent<SwipeTest>().rightArrow.SetActive(false);
                ArrowControl.GetComponent<SwipeTest>().leftArrow.SetActive(false);
                ArrowControl.GetComponent<SwipeTest>().midArrow.SetActive(true);
            }

            //GetComponent<Rigidbody>().useGravity = true;

            //gameObject.GetComponent<CubeScript>().enabled = false;

            _ucacak = true;
        }
        else
        {

        }


    }


    IEnumerator nMesh()
    {
        yield return new WaitForSeconds(1);
        transform.parent = null;
        NavMeshAgent nMesh = GetComponent<NavMeshAgent>();

        nMesh.destination = target.transform.position;
    }
}
