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




    void Start()
    {
        transform.DOMove(new Vector3(0, 1, -7), 3).OnComplete(() => turnDonenRay());

        GetComponent<NavMeshAgent>().enabled = true;
        gameObject.tag = "Untagged";

        ArrowControl = GameObject.FindGameObjectWithTag("ArrowControl");
        TurnDirection = GameObject.FindGameObjectWithTag("turnDirection");


        bariyerSol = GameObject.FindGameObjectWithTag("LeftStation");
        bariyerOrta = GameObject.FindGameObjectWithTag("MidStation");
        bariyerSag = GameObject.FindGameObjectWithTag("RightStation");
        donenRay = GameObject.FindGameObjectWithTag("turnDirection");
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
            //bariyerSol.GetComponent<LeftStationControl>().eklenenHarfler.Add(gameObject.transform.GetChild(transform.childCount - 1).gameObject);
            TurnDirection.GetComponent<TurnDirection>().newRound = true;

            if (ArrowControl.GetComponent<SwipeTest>()._level1)
            {
                ArrowControl.GetComponent<SwipeTest>().rightArrow.SetActive(false);
                ArrowControl.GetComponent<SwipeTest>().leftArrow.SetActive(true);
            }
            else
            {
                ArrowControl.GetComponent<SwipeTest>().rightArrow.SetActive(false);
                ArrowControl.GetComponent<SwipeTest>().leftArrow.SetActive(false);
                ArrowControl.GetComponent<SwipeTest>().midArrow.SetActive(true);
            }


        }

        else if (other.gameObject.tag == "RightStation")
        {
            GetComponent<NavMeshAgent>().enabled = false;
            gameObject.tag = "RightStop";
            gameObject.GetComponent<CubeScript>().enabled = false;
            //bariyerSag.GetComponent<RightStationControl>().eklenenHarfler.Add(gameObject.transform.GetChild(transform.childCount - 1).gameObject);
            TurnDirection.GetComponent<TurnDirection>().newRound = true;

            if (ArrowControl.GetComponent<SwipeTest>()._level1)
            {
                ArrowControl.GetComponent<SwipeTest>().rightArrow.SetActive(false);
                ArrowControl.GetComponent<SwipeTest>().leftArrow.SetActive(true);
            }
            else
            {
                ArrowControl.GetComponent<SwipeTest>().rightArrow.SetActive(false);
                ArrowControl.GetComponent<SwipeTest>().leftArrow.SetActive(false);
                ArrowControl.GetComponent<SwipeTest>().midArrow.SetActive(true);
            }
        }

        else if (other.gameObject.tag == "MidStation")
        {
            GetComponent<NavMeshAgent>().enabled = false;
            gameObject.tag = "MidStop";
            gameObject.GetComponent<CubeScript>().enabled = false;
            //bariyerOrta.GetComponent<MidStationControl>().eklenenHarfler.Add(gameObject.transform.GetChild(transform.childCount - 1).gameObject);
            TurnDirection.GetComponent<TurnDirection>().newRound = true;
            if (ArrowControl.GetComponent<SwipeTest>()._level1)
            {
                ArrowControl.GetComponent<SwipeTest>().rightArrow.SetActive(false);
                ArrowControl.GetComponent<SwipeTest>().leftArrow.SetActive(true);
            }
            else
            {
                ArrowControl.GetComponent<SwipeTest>().rightArrow.SetActive(false);
                ArrowControl.GetComponent<SwipeTest>().leftArrow.SetActive(false);
                ArrowControl.GetComponent<SwipeTest>().midArrow.SetActive(true);
            }
        }

        else if (other.gameObject.tag == "LeftStop")
        {
            GetComponent<NavMeshAgent>().enabled = false;
            gameObject.tag = "LeftStop";
            gameObject.GetComponent<CubeScript>().enabled = false;
            //bariyerSol.GetComponent<LeftStationControl>().eklenenHarfler.Add(gameObject.transform.GetChild(transform.childCount - 1).gameObject);
            TurnDirection.GetComponent<TurnDirection>().newRound = true;

            if (ArrowControl.GetComponent<SwipeTest>()._level1)
            {
                ArrowControl.GetComponent<SwipeTest>().rightArrow.SetActive(false);
                ArrowControl.GetComponent<SwipeTest>().leftArrow.SetActive(true);
            }
            else
            {
                ArrowControl.GetComponent<SwipeTest>().rightArrow.SetActive(false);
                ArrowControl.GetComponent<SwipeTest>().leftArrow.SetActive(false);
                ArrowControl.GetComponent<SwipeTest>().midArrow.SetActive(true);
            }
        }
        else if (other.gameObject.tag == "MidStop")
        {
            GetComponent<NavMeshAgent>().enabled = false;
            gameObject.tag = "MidStop";
            gameObject.GetComponent<CubeScript>().enabled = false;
            //bariyerOrta.GetComponent<MidStationControl>().eklenenHarfler.Add(gameObject.transform.GetChild(transform.childCount - 1).gameObject);
            TurnDirection.GetComponent<TurnDirection>().newRound = true;

            if (ArrowControl.GetComponent<SwipeTest>()._level1)
            {
                ArrowControl.GetComponent<SwipeTest>().rightArrow.SetActive(false);
                ArrowControl.GetComponent<SwipeTest>().leftArrow.SetActive(true);
            }
            else
            {
                ArrowControl.GetComponent<SwipeTest>().rightArrow.SetActive(false);
                ArrowControl.GetComponent<SwipeTest>().leftArrow.SetActive(false);
                ArrowControl.GetComponent<SwipeTest>().midArrow.SetActive(true);
            }
        }

        else if (other.gameObject.tag == "RightStop")
        {
            GetComponent<NavMeshAgent>().enabled = false;
            gameObject.tag = "RightStop";
            gameObject.GetComponent<CubeScript>().enabled = false;
            //bariyerSag.GetComponent<RightStationControl>().eklenenHarfler.Add(gameObject.transform.GetChild(transform.childCount - 1).gameObject);
            TurnDirection.GetComponent<TurnDirection>().newRound = true;

            if (ArrowControl.GetComponent<SwipeTest>()._level1)
            {
                ArrowControl.GetComponent<SwipeTest>().rightArrow.SetActive(false);
                ArrowControl.GetComponent<SwipeTest>().leftArrow.SetActive(true);
            }
            else
            {
                ArrowControl.GetComponent<SwipeTest>().rightArrow.SetActive(false);
                ArrowControl.GetComponent<SwipeTest>().leftArrow.SetActive(false);
                ArrowControl.GetComponent<SwipeTest>().midArrow.SetActive(true);
            }
        }
        else if (other.gameObject.tag == "turnDirection")
        {
            transform.parent = donenRay.transform;
            //TurnDirection = other.gameObject;
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
