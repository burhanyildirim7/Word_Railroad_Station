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

    void Start()
    {
        transform.DOMove(new Vector3(35,1,3), 3).OnComplete(() => turnDonenRay());

        ArrowControl = GameObject.FindGameObjectWithTag("ArrowControl");
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
        StartCoroutine(nMesh());
        //donenRay.transform.DORotate(new Vector3(0,90,0),2).OnComplete(() => nMesh());

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "turnDirection")
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
