using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeTest : MonoBehaviour
{
    public Swipe swipeControls;

    public GameObject leftArrow;
    public GameObject midArrow;
    public GameObject rightArrow;

    bool canSwipe = false;
  
    // Start is called before the first frame update
    void Start()
    {
        midArrow.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            canSwipe = true;
        }
 
                if (swipeControls.SwipeLeft && canSwipe)
                {
                    if (leftArrow.activeSelf)
                    {
                        rightArrow.SetActive(true);
                        leftArrow.SetActive(false);
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
        


    
}