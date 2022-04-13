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
  

    void Start()
    {
        transform.DOMove(new Vector3(35,1,3), 3).OnComplete(() => turnDonenRay());

        GetComponent<NavMeshAgent>().enabled = true;
        gameObject.tag = "Untagged";

        ArrowControl = GameObject.FindGameObjectWithTag("ArrowControl");
        TurnDirection = GameObject.FindGameObjectWithTag("turnDirection");
        

        bariyerSol =  GameObject.FindGameObjectWithTag("LeftStation");
        bariyerOrta = GameObject.FindGameObjectWithTag("MidStation");
        bariyerSag =  GameObject.FindGameObjectWithTag("RightStation");
        donenRay = GameObject.FindGameObjectWithTag("turnDirection");
    }

    // Update is called once per frame
    void Update()
    {
     
    }

    void turnDonenRay()
    {
        transform.parent = donenRay.transform;
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
        if (other.gameObject.tag == "LeftStation" || other.gameObject.tag == "RightStation" || other.gameObject.tag == "MidStation" || other.gameObject.tag == "Stop")
        {
            GetComponent<NavMeshAgent>().enabled = false;
   
            gameObject.tag = "Stop";
            //GameObject.FindGameObjectWithTag("MainControl").GetComponent<MainControl>().SpawnNewTrain();

            TurnDirection.GetComponent<TurnDirection>().newRound = true;
            ArrowControl.GetComponent<SwipeTest>().midArrow.SetActive(true);
            ArrowControl.GetComponent<SwipeTest>().rightArrow.SetActive(false);
            ArrowControl.GetComponent<SwipeTest>().leftArrow.SetActive(false);


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
