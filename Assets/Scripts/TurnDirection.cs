using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TurnDirection : MonoBehaviour
{
    public bool right;
    public bool left;
    public bool mid;
    public bool leftBarrier;
    public bool rightBarrier;

    public bool lockTurn = false;
    GameObject ArrowControl;
    GameObject otherGameobject;



    public bool newRound = false;
    void Start()
    {
        mid = true;
        lockTurn = true;
        ArrowControl = GameObject.FindGameObjectWithTag("ArrowControl");

    }


    void Update()
    {
        if (GameController.instance.isContinue)
        {
            if (newRound)
            {
                ArrowControl = GameObject.FindGameObjectWithTag("ArrowControl");

                if (ArrowControl.GetComponent<SwipeTest>()._level1)
                {
                    transform.DORotate(new Vector3(0, 90, 0), 1);
                    newRound = false;
                }
                else
                {
                    transform.DORotate(new Vector3(0, 0, 0), 1);
                    newRound = false;
                }

            }
        }
        else
        {

        }


    }

    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(TurnDirectionWithMouse());

        otherGameobject = other.gameObject;


    }

    IEnumerator TurnDirectionWithMouse()
    {
        ArrowControl = GameObject.FindGameObjectWithTag("ArrowControl");

        yield return new WaitForSeconds(1);

        if (ArrowControl.GetComponent<SwipeTest>()._level1)
        {
            if (ArrowControl.GetComponent<SwipeTest>().arrowIsLeft)
            {
                transform.DORotate(new Vector3(0, 50, 0), 1).OnComplete(() => otherGameobject.gameObject.GetComponent<TrainControl>().canTurn = true);
                right = false;
                left = true;
                mid = false;
            }

            if (ArrowControl.GetComponent<SwipeTest>().arrowIsRight)
            {
                transform.DORotate(new Vector3(0, 130, 0), 1).OnComplete(() => otherGameobject.gameObject.GetComponent<TrainControl>().canTurn = true);
                right = true;
                left = false;
                mid = false;
            }
        }
        else
        {
            if (ArrowControl.GetComponent<SwipeTest>().arrowIsLeft)
            {
                transform.DORotate(new Vector3(0, -65, 0), 1).OnComplete(() => otherGameobject.gameObject.GetComponent<TrainControl>().canTurn = true);
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
                transform.DORotate(new Vector3(0, 65, 0), 1).OnComplete(() => otherGameobject.gameObject.GetComponent<TrainControl>().canTurn = true);
                right = true;
                left = false;
                mid = false;
            }

            if (ArrowControl.GetComponent<SwipeTest>().arrowIsLeftBarrier)
            {
                transform.DORotate(new Vector3(0, -90, 0), 1).OnComplete(() => otherGameobject.gameObject.GetComponent<TrainControl>().canTurn = true);
                right = false;
                left = false;
                mid = false;
                leftBarrier = true;
            }

            if (ArrowControl.GetComponent<SwipeTest>().arrowIsRightBarrier)
            {
                transform.DORotate(new Vector3(0, 90, 0), 1).OnComplete(() => otherGameobject.gameObject.GetComponent<TrainControl>().canTurn = true);
                right = false;
                left = false;
                mid = false;
                rightBarrier = true;
            }
        }


    }
}
