using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TurnDirection : MonoBehaviour
{
    public bool right;
    public bool left;
    public bool mid;

    public bool lockTurn = false;
    GameObject ArrowControl;
    GameObject otherGameobject;

    bool trainCanGo = false;
    void Start()
    {
        mid = true;
        lockTurn = true;
        ArrowControl = GameObject.FindGameObjectWithTag("ArrowControl");
       
    }


    void Update()
    {
  
  
    }

    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(TurnDirectionWithMouse());

        otherGameobject = other.gameObject;
    }

    IEnumerator TurnDirectionWithMouse()
    {
        yield return new WaitForSeconds(1);
        if (ArrowControl.GetComponent<SwipeTest>().arrowIsLeft)
        {
            transform.DORotate(new Vector3(0, -60, 0), 1).OnComplete(()=> otherGameobject.gameObject.GetComponent<TrainControl>().canTurn = true);
            right = false;
            left = true;
            mid = false;
        }

        if (ArrowControl.GetComponent<SwipeTest>().arrowIsMid)
        {
            transform.DORotate(new Vector3(0, 0, 0), 1).OnComplete(() => otherGameobject.gameObject.GetComponent<TrainControl>().canTurn = true);
            right = false;
            left = false;
            mid = true;
        }
        if (ArrowControl.GetComponent<SwipeTest>().arrowIsRight)
        {
            transform.DORotate(new Vector3(0, 60, 0), 1).OnComplete(() => otherGameobject.gameObject.GetComponent<TrainControl>().canTurn = true);
            right = true;
            left = false;
            mid = false;
        }
    }
}
