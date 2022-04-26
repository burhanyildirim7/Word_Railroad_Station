using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeTest : MonoBehaviour
{
    public Swipe swipeControls;

    public bool _level1;
    //public bool _level2;
    //public bool _level3;
    //public bool _level4;
    // public bool _level5;

    public GameObject leftArrow;
    public GameObject midArrow;
    public GameObject rightArrow;
    public GameObject barrier1Arrow;
    public GameObject barrier2Arrow;

    public bool arrowIsLeft;
    public bool arrowIsRight;
    public bool arrowIsMid;
    public bool arrowIsLeftBarrier;
    public bool arrowIsRightBarrier;

    bool canSwipe = false;

    private LevelCanvasScript _levelCanvasScript;

    // Start is called before the first frame update
    void Start()
    {
        OkSifirla();
        _levelCanvasScript = GameObject.FindGameObjectWithTag("LevelCanvas").GetComponent<LevelCanvasScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameController.instance.isContinue)
        {

            CheckArrowDirection();


            // FunctionAccordingToArrowDirection();

            if (Input.GetMouseButtonDown(0))
            {
                canSwipe = true;
            }

            if (_level1)
            {
                if (swipeControls.SwipeLeft && canSwipe)
                {

                    if (rightArrow.activeSelf)
                    {
                        if (_levelCanvasScript._peron1Bitti)
                        {

                        }
                        else
                        {
                            rightArrow.SetActive(false);
                            leftArrow.SetActive(true);
                        }


                    }

                    canSwipe = false;
                }



                if (swipeControls.SwipeRight && canSwipe)
                {
                    if (leftArrow.activeSelf)
                    {
                        if (_levelCanvasScript._peron2Bitti)
                        {

                        }
                        else
                        {
                            leftArrow.SetActive(false);
                            rightArrow.SetActive(true);
                        }


                    }

                    canSwipe = false;
                }
            }
            /*
            else if (_level2)
            {
                if (swipeControls.SwipeLeft && canSwipe)
                {
                    if (leftArrow.activeSelf)
                    {
                        leftArrow.SetActive(false);
                        barrier1Arrow.SetActive(true);

                    }

                    else if (barrier1Arrow.activeSelf)
                    {
                        barrier1Arrow.SetActive(false);
                        barrier2Arrow.SetActive(true);
                    }
                    else if (barrier2Arrow.activeSelf)
                    {
                        barrier2Arrow.SetActive(false);
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
                        barrier2Arrow.SetActive(true);

                    }
                    else if (barrier2Arrow.activeSelf)
                    {
                        barrier2Arrow.SetActive(false);
                        barrier1Arrow.SetActive(true);
                    }

                    else if (barrier1Arrow.activeSelf)
                    {
                        barrier1Arrow.SetActive(false);
                        leftArrow.SetActive(true);
                    }
                    canSwipe = false;
                }
            }
            */
            else
            {
                if (swipeControls.SwipeLeft && canSwipe)
                {
                    if (leftArrow.activeSelf)
                    {
                        leftArrow.SetActive(false);
                        barrier1Arrow.SetActive(true);

                    }

                    else if (barrier1Arrow.activeSelf)
                    {
                        barrier1Arrow.SetActive(false);
                        barrier2Arrow.SetActive(true);
                    }
                    else if (barrier2Arrow.activeSelf)
                    {
                        if (_levelCanvasScript._peron2Bitti)
                        {
                            if (_levelCanvasScript._peron2Bitti && _levelCanvasScript._peron3Bitti)
                            {
                                barrier2Arrow.SetActive(false);
                                leftArrow.SetActive(true);
                            }
                            else
                            {
                                barrier2Arrow.SetActive(false);
                                midArrow.SetActive(true);
                            }

                        }
                        else
                        {
                            barrier2Arrow.SetActive(false);
                            rightArrow.SetActive(true);
                        }

                    }


                    else if (rightArrow.activeSelf)
                    {
                        if (_levelCanvasScript._peron3Bitti)
                        {
                            if (_levelCanvasScript._peron1Bitti && _levelCanvasScript._peron3Bitti)
                            {
                                rightArrow.SetActive(false);
                                barrier1Arrow.SetActive(true);
                            }
                            else
                            {
                                rightArrow.SetActive(false);
                                leftArrow.SetActive(true);
                            }

                        }
                        else
                        {
                            rightArrow.SetActive(false);
                            midArrow.SetActive(true);
                        }


                    }


                    else if (midArrow.activeSelf)
                    {
                        if (_levelCanvasScript._peron1Bitti)
                        {
                            midArrow.SetActive(false);
                            barrier1Arrow.SetActive(true);
                        }
                        else
                        {
                            midArrow.SetActive(false);
                            leftArrow.SetActive(true);
                        }


                    }


                    canSwipe = false;
                }



                if (swipeControls.SwipeRight && canSwipe)
                {
                    if (leftArrow.activeSelf)
                    {
                        if (_levelCanvasScript._peron3Bitti)
                        {
                            if (_levelCanvasScript._peron2Bitti && _levelCanvasScript._peron3Bitti)
                            {
                                leftArrow.SetActive(false);
                                barrier2Arrow.SetActive(true);
                            }
                            else
                            {
                                leftArrow.SetActive(false);
                                rightArrow.SetActive(true);
                            }

                        }
                        else
                        {
                            leftArrow.SetActive(false);
                            midArrow.SetActive(true);
                        }


                    }

                    else if (midArrow.activeSelf)
                    {
                        if (_levelCanvasScript._peron2Bitti)
                        {
                            midArrow.SetActive(false);
                            barrier2Arrow.SetActive(true);
                        }
                        else
                        {
                            midArrow.SetActive(false);
                            rightArrow.SetActive(true);
                        }


                    }
                    else if (rightArrow.activeSelf)
                    {
                        rightArrow.SetActive(false);
                        barrier2Arrow.SetActive(true);

                    }
                    else if (barrier2Arrow.activeSelf)
                    {
                        barrier2Arrow.SetActive(false);
                        barrier1Arrow.SetActive(true);
                    }

                    else if (barrier1Arrow.activeSelf)
                    {
                        if (_levelCanvasScript._peron1Bitti)
                        {
                            if (_levelCanvasScript._peron1Bitti && _levelCanvasScript._peron3Bitti)
                            {
                                barrier1Arrow.SetActive(false);
                                rightArrow.SetActive(true);
                            }
                            else
                            {
                                barrier1Arrow.SetActive(false);
                                midArrow.SetActive(true);
                            }

                        }
                        else
                        {
                            barrier1Arrow.SetActive(false);
                            leftArrow.SetActive(true);
                        }

                    }
                    canSwipe = false;
                }
            }
            /*
            else if (_level4)
            {
                if (swipeControls.SwipeLeft && canSwipe)
                {
                    if (leftArrow.activeSelf)
                    {
                        leftArrow.SetActive(false);
                        barrier1Arrow.SetActive(true);

                    }

                    else if (barrier1Arrow.activeSelf)
                    {
                        barrier1Arrow.SetActive(false);
                        barrier2Arrow.SetActive(true);
                    }
                    else if (barrier2Arrow.activeSelf)
                    {
                        barrier2Arrow.SetActive(false);
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
                        barrier2Arrow.SetActive(true);

                    }
                    else if (barrier2Arrow.activeSelf)
                    {
                        barrier2Arrow.SetActive(false);
                        barrier1Arrow.SetActive(true);
                    }

                    else if (barrier1Arrow.activeSelf)
                    {
                        barrier1Arrow.SetActive(false);
                        leftArrow.SetActive(true);
                    }
                    canSwipe = false;
                }
            }
            else if (_level5)
            {
                if (swipeControls.SwipeLeft && canSwipe)
                {
                    if (leftArrow.activeSelf)
                    {
                        leftArrow.SetActive(false);
                        barrier1Arrow.SetActive(true);

                    }

                    else if (barrier1Arrow.activeSelf)
                    {
                        barrier1Arrow.SetActive(false);
                        barrier2Arrow.SetActive(true);
                    }
                    else if (barrier2Arrow.activeSelf)
                    {
                        barrier2Arrow.SetActive(false);
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
                        barrier2Arrow.SetActive(true);

                    }
                    else if (barrier2Arrow.activeSelf)
                    {
                        barrier2Arrow.SetActive(false);
                        barrier1Arrow.SetActive(true);
                    }

                    else if (barrier1Arrow.activeSelf)
                    {
                        barrier1Arrow.SetActive(false);
                        leftArrow.SetActive(true);
                    }
                    canSwipe = false;
                }
            }
            */

        }
        else
        {

        }

    }



    void CheckArrowDirection()
    {
        if (leftArrow.activeSelf)
        {
            arrowIsLeft = true;
            arrowIsMid = false;
            arrowIsRight = false;
            arrowIsLeftBarrier = false;
            arrowIsRightBarrier = false;
        }


        if (rightArrow.activeSelf)
        {
            arrowIsLeft = false;
            arrowIsMid = false;
            arrowIsRight = true;
            arrowIsLeftBarrier = false;
            arrowIsRightBarrier = false;
        }

        if (midArrow.activeSelf)
        {
            arrowIsLeft = false;
            arrowIsMid = true;
            arrowIsRight = false;
            arrowIsLeftBarrier = false;
            arrowIsRightBarrier = false;

        }

        if (barrier1Arrow.activeSelf)
        {
            arrowIsLeft = false;
            arrowIsMid = false;
            arrowIsRight = false;
            arrowIsLeftBarrier = true;
            arrowIsRightBarrier = false;
        }

        if (barrier2Arrow.activeSelf)
        {
            arrowIsLeft = false;
            arrowIsMid = false;
            arrowIsRight = false;
            arrowIsLeftBarrier = false;
            arrowIsRightBarrier = true;
        }

    }

    public void OkSifirla()
    {
        if (_level1)
        {

            leftArrow.SetActive(true);


        }
        else
        {
            midArrow.SetActive(true);
        }
    }

    void FunctionAccordingToArrowDirection()
    {
        if (arrowIsLeft)
        {
            Debug.Log("Ok Sola Bak?yor");
        }

        if (arrowIsMid)
        {
            Debug.Log("Arrow Ortaya Bak?yor");
        }

        if (arrowIsRight)
        {
            Debug.Log("Arrow Sa?a Bak?yor");
        }

    }
}