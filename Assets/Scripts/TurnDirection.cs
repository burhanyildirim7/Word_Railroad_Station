using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnDirection : MonoBehaviour
{
    public bool right;
    public bool left;
    public bool mid;

    public bool lockTurn = false;

    void Start()
    {
        mid = true;
    }


    void Update()
    {
        if (lockTurn == false)
        {
            TurnDirectionWithMouse();
        }

  
    }

    void TurnDirectionWithMouse()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (transform.rotation.y == 0)
            {
                transform.eulerAngles = new Vector3(0, 60, 0);
        
                right = true;
                left = false;
                mid = false;
            }
            else if (transform.rotation.y > 0f)
            {
      
                transform.eulerAngles = new Vector3(0, -60, 0);
                right = false;
                left = true;
                mid = false;
            }
            else if (transform.rotation.y < 0f)
            {
 
                transform.eulerAngles = new Vector3(0, 0, 0);
                right = false;
                left = false;
                mid = true;
            }
        }
    }
}
