using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeTest : MonoBehaviour
{
    public Swipe swipeControls;

    public GameObject leftArrow;
    public GameObject midArrow;
    public GameObject rightArrow;

    public bool arrowIsLeft;
    public bool arrowIsRight;
    public bool arrowIsMid;

    bool canSwipe = false;
  
    // Start is called before the first frame update
    void Start()
    {
        midArrow.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

        CheckArrowDirection();


        FunctionAccordingToArrowDirection();

        if (Input.GetMouseButtonDown(0))
        {
            canSwipe = true;
        }
 
                if (swipeControls.SwipeLeft && canSwipe)
                {
                    if (leftArrow.activeSelf)
                    {
                        leftArrow.SetActive(false);
                        rightArrow.SetActive(true);
            
                    }
     

                    else if (rightArrow.activeSelf)
                    {
                        rightArrow.SetActive(false);
                        midArrow.SetActive(true);
           
                    }


                    else if (midArrow.activeSelf)
                    {
                        midArrow.SetActive(false);
                        leftArrow.SetActive(true);
                   
                    }
                     canSwipe = false;
                }

                

                if (swipeControls.SwipeRight && canSwipe)
                {
                       if (leftArrow.activeSelf)
                          {
                            leftArrow.SetActive(false);
                            midArrow.SetActive(true);
                         
                          }

                        else if (midArrow.activeSelf)
                        {
                            midArrow.SetActive(false);
                            rightArrow.SetActive(true);
             
                        }
                        else if (rightArrow.activeSelf)
                        {
                            rightArrow.SetActive(false);
                            leftArrow.SetActive(true);
                       
                        }
                        canSwipe = false;
                }      
        }
        


    void CheckArrowDirection()
    {
        if (leftArrow.activeSelf)
        {
            arrowIsLeft = true;
            arrowIsMid = false;
            arrowIsRight = false;
        }


        if (rightArrow.activeSelf)
        {
            arrowIsLeft = false;
            arrowIsMid = false;
            arrowIsRight = true;

        }

        if (midArrow.activeSelf)
        {
            arrowIsLeft = false;
            arrowIsMid = true;
            arrowIsRight = false;

        }

    }

    void FunctionAccordingToArrowDirection()
    {
        if (arrowIsLeft)
        {
            Debug.Log("Ok Sola Bakýyor");
        }

        if (arrowIsMid)
        {
            Debug.Log("Arrow Ortaya Bakýyor");
        }

        if (arrowIsRight)
        {
            Debug.Log("Arrow Saða Bakýyor");
        }

    }
}