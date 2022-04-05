using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TrainControl : MonoBehaviour
{
    GameObject TurnDirection;

    public Transform leftRoad;
    public Transform rightRoad;
    public Transform midRoad;

    public Transform leftTurnPoint;
    public Transform rightTurnPoint;


    bool canTurn = false;
    void Start()
    {
        RandomColor();
        TurnDirection = GameObject.FindGameObjectWithTag("turnDirection");
       

    }

    void Update()
    {


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
            transform.Translate(new Vector3(0, 0, -3     * Time.deltaTime));
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "targetPoint")
        {
            if (gameObject.GetComponent<Renderer>().material.color == other.gameObject.GetComponent<Renderer>().material.color)
            {
                Debug.Log("Do�ru Renk");
            }
            else
            {
                Debug.Log("Yanl�� Renk");
            }
            Destroy(gameObject);
            GameObject.FindGameObjectWithTag("MainControl").GetComponent<MainControl>().SpawnNewTrain();
        }
        if (other.gameObject.tag == "turnDirection")
        {
            canTurn = true;
        }
    }

    void RandomColor()
    {
        int colorNumber;
        colorNumber = Random.Range(0, 3);

        if (colorNumber == 0)
        {
            GetComponent<Renderer>().material.color = Color.red;
        }
        else if (colorNumber == 1)
        {
            GetComponent<Renderer>().material.color = Color.blue;
        }
        else if (colorNumber == 2)
        {
            GetComponent<Renderer>().material.color = Color.green;
        }
    }

    void OnCompleteRightPoint()
    {

        transform.DOMove(rightRoad.position, 1);
        transform.LookAt(rightRoad);
    }

    void OnCompleteLeftPoint()
    {

        transform.DOMove(leftRoad.position, 1);
        transform.LookAt(leftRoad);
    }
}
