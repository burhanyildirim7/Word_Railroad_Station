using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TrainControl : MonoBehaviour
{
    GameObject TurnDirection;
    public GameObject parentObject;


    bool canGoLeftStation;
    bool canGoMidStation;
    bool canGoRightStation;

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

        if (gameObject.tag == "LeftStop")
        {
            GetComponent<TrainControl>().enabled = false;
        }
        canGoLeftStation = GameObject.FindGameObjectWithTag("MainControl").GetComponent<MainControl>().leftStationAvailable;
        canGoMidStation = GameObject.FindGameObjectWithTag("MainControl").GetComponent<MainControl>().midStationAvailable;
        canGoRightStation = GameObject.FindGameObjectWithTag("MainControl").GetComponent<MainControl>().rightStationAvailable;


        if (canGoRightStation == false)
        {
            Debug.Log("Sað Ýstasyon Kapandý");
        }

        if (canGoLeftStation == false)
        {
            Debug.Log("Sol Ýstasyon Kapandý");
        }

        if (canGoMidStation == false)
        {
            Debug.Log("Orta Ýstasyon Kapandý");
        }


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
     

        if (canGoLeftStation)
        {
            if (other.gameObject.tag == "LeftStop")
            {
                if (gameObject.tag == other.gameObject.GetComponent<TrainControl>().parentObject.transform.GetChild(GameObject.FindGameObjectWithTag("MainControl").GetComponent<MainControl>().leftStationChild).tag)
                {
                    gameObject.tag = "LeftStop";
                    parentObject = leftRoad.gameObject;
                    Stop();
                   // GameObject.FindGameObjectWithTag("MainControl").GetComponent<MainControl>().SpawnNewTrain();
                    GameObject.FindGameObjectWithTag("MainControl").GetComponent<MainControl>().leftStationChild++;
                }
                else
                {
                    Destroy(gameObject);
                    //GameObject.FindGameObjectWithTag("MainControl").GetComponent<MainControl>().SpawnNewTrain();
                }
            }

            if (other.gameObject.tag == "LeftStation")
            {
                if (gameObject.tag == other.gameObject.transform.GetChild(GameObject.FindGameObjectWithTag("MainControl").GetComponent<MainControl>().leftStationChild).gameObject.tag)
                {
                    gameObject.tag = "LeftStop";
                    parentObject = leftRoad.gameObject;
                    Stop();
                    //GameObject.FindGameObjectWithTag("MainControl").GetComponent<MainControl>().SpawnNewTrain();
                    GameObject.FindGameObjectWithTag("MainControl").GetComponent<MainControl>().leftStationChild++;
                }
                else
                {
                    Destroy(gameObject);
                    //GameObject.FindGameObjectWithTag("MainControl").GetComponent<MainControl>().SpawnNewTrain();
                }


            }
        }
    


        if (canGoMidStation)
        {
            if (other.gameObject.tag == "MidStop")
            {
                if (gameObject.tag == other.gameObject.GetComponent<TrainControl>().parentObject.transform.GetChild(GameObject.FindGameObjectWithTag("MainControl").GetComponent<MainControl>().midStationChild).tag)
                {
                    gameObject.tag = "MidStop";
                    parentObject = midRoad.gameObject;
                    Stop();
                   // GameObject.FindGameObjectWithTag("MainControl").GetComponent<MainControl>().SpawnNewTrain();
                    GameObject.FindGameObjectWithTag("MainControl").GetComponent<MainControl>().midStationChild++;
                }
                else
                {
                    Destroy(gameObject);
                   // GameObject.FindGameObjectWithTag("MainControl").GetComponent<MainControl>().SpawnNewTrain();
                }
            }

            if (other.gameObject.tag == "MidStation")
            {
                if (gameObject.tag == other.gameObject.transform.GetChild(GameObject.FindGameObjectWithTag("MainControl").GetComponent<MainControl>().midStationChild).gameObject.tag)
                {
                    gameObject.tag = "MidStop";
                    parentObject = midRoad.gameObject;
                    Stop();
                   // GameObject.FindGameObjectWithTag("MainControl").GetComponent<MainControl>().SpawnNewTrain();
                    GameObject.FindGameObjectWithTag("MainControl").GetComponent<MainControl>().midStationChild++;
                }
                else
                {
                    Destroy(gameObject);
                    //GameObject.FindGameObjectWithTag("MainControl").GetComponent<MainControl>().SpawnNewTrain();
                }


            }
        }

     


        if (canGoRightStation)
        {
            if (other.gameObject.tag == "RightStop")
            {
                if (gameObject.tag == other.gameObject.GetComponent<TrainControl>().parentObject.transform.GetChild(GameObject.FindGameObjectWithTag("MainControl").GetComponent<MainControl>().rightStationChild).tag)
                {
                    gameObject.tag = "RightStop";
                    parentObject = rightRoad.gameObject;
                    Stop();
                    //GameObject.FindGameObjectWithTag("MainControl").GetComponent<MainControl>().SpawnNewTrain();
                    GameObject.FindGameObjectWithTag("MainControl").GetComponent<MainControl>().rightStationChild++;
                }
                else
                {
                    Destroy(gameObject);
                   // GameObject.FindGameObjectWithTag("MainControl").GetComponent<MainControl>().SpawnNewTrain();
                }
            }

            if (other.gameObject.tag == "RightStation")
            {
                if (gameObject.tag == other.gameObject.transform.GetChild(GameObject.FindGameObjectWithTag("MainControl").GetComponent<MainControl>().rightStationChild).gameObject.tag)
                {
                    gameObject.tag = "RightStop";
                    parentObject = rightRoad.gameObject;
                    Stop();
                   // GameObject.FindGameObjectWithTag("MainControl").GetComponent<MainControl>().SpawnNewTrain();
                    GameObject.FindGameObjectWithTag("MainControl").GetComponent<MainControl>().rightStationChild++;
                }
                else
                {
                    Destroy(gameObject);
                    //GameObject.FindGameObjectWithTag("MainControl").GetComponent<MainControl>().SpawnNewTrain();
                }


            }
        }



       
            if (other.gameObject.tag == "LeftStop")
            {
            if (canGoLeftStation == false)
            {
                DOTween.Kill(transform);
                trainSpeed = 0;
                GetComponent<Rigidbody>().useGravity = true;
                Destroy(gameObject, 3);
            }
     
            }

        if (other.gameObject.tag == "RightStop")
        {
            if (canGoRightStation == false)
            {
                trainSpeed = 0;
                DOTween.Kill(transform);
                GetComponent<Rigidbody>().useGravity = true;
                Destroy(gameObject,3);
            }

        }

        if (other.gameObject.tag == "MidStop")
        {
            if (canGoMidStation == false)
            {
                trainSpeed = 0;
                DOTween.Kill(transform);
                GetComponent<Rigidbody>().useGravity = true;
                Destroy(gameObject, 3);
            }

        }




        if (other.gameObject.tag == "turnDirection")
        {
            canTurn = true;
        }
    }

     void OnTriggerStay(Collider other)
    {
        if (other.gameObject == GameObject.FindGameObjectWithTag("turnDirection").transform.GetChild(0).gameObject || other.gameObject == GameObject.FindGameObjectWithTag("turnDirection").transform.GetChild(1).gameObject)
        {
            GameObject.FindGameObjectWithTag("turnDirection").GetComponent<TurnDirection>().lockTurn = true;
            Debug.Log("Temas Var");
        }
        else
        {
            GameObject.FindGameObjectWithTag("turnDirection").GetComponent<TurnDirection>().lockTurn = false;
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
