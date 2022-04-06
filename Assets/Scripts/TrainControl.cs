using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TrainControl : MonoBehaviour
{
    GameObject TurnDirection;

    private Transform leftRoad;
    private Transform rightRoad;
    private Transform midRoad;

    public Transform leftTurnPoint;
    public Transform rightTurnPoint;

    public int trainSpeed = 3;
    bool canTurn = false;
    void Start()
    {
       
        TurnDirection = GameObject.FindGameObjectWithTag("turnDirection");

        leftRoad = GameObject.FindGameObjectWithTag("LeftStation").transform;
        midRoad = GameObject.FindGameObjectWithTag("MidStation").transform;
        rightRoad = GameObject.FindGameObjectWithTag("RightStation").transform;

        leftTurnPoint = GameObject.FindGameObjectWithTag("LeftTurnPoint").transform;
        rightTurnPoint = GameObject.FindGameObjectWithTag("RightTurnPoint").transform;

        GetComponent<BoxCollider>().isTrigger = true;
    }

    void Update()
    {

        transform.eulerAngles = new Vector3(90, transform.eulerAngles.y, transform.eulerAngles.z);
        MoveToTargetRoad();
    }

    void MoveToTargetRoad()
    {
        if (canTurn)
        {


            if (TurnDirection.GetComponent<TurnDirection>().right)
            {
                transform.DOMove(rightTurnPoint.position, 1).OnComplete(() => OnCompleteRightPoint());
               
                transform.LookAt(rightTurnPoint);

            }
            else if (TurnDirection.GetComponent<TurnDirection>().left)
            {
                transform.DOMove(leftTurnPoint.position, 1).OnComplete(() => OnCompleteLeftPoint());
                transform.LookAt(leftTurnPoint);
            }
            else if (TurnDirection.GetComponent<TurnDirection>().mid)
            {
                transform.DOMove(midRoad.position, 1);
                transform.LookAt(midRoad);
            }
            canTurn = false;
        }
        else
        {
            transform.Translate(new Vector3(0, trainSpeed * Time.deltaTime, 0));
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "LeftStation" || other.gameObject.tag == "MidStation" || other.gameObject.tag == "RightStation" || other.gameObject.tag == "Stop")
        {
            gameObject.tag = "Stop";
            Stop();
            GameObject.FindGameObjectWithTag("MainControl").GetComponent<MainControl>().SpawnNewTrain();
        }
        if (other.gameObject.tag == "turnDirection")
        {
            canTurn = true;
        }
    }

    void Stop()
    {
        DOTween.Kill(transform);
        trainSpeed = 0;
    }

    void OnCompleteRightPoint()
    {

        transform.DOMove(rightRoad.position, 1).OnComplete(()=>Stop());
        transform.LookAt(rightRoad);
    }

    void OnCompleteLeftPoint()
    {

        transform.DOMove(leftRoad.position, 1).OnComplete(() => Stop());
        transform.LookAt(leftRoad);
    }
}
