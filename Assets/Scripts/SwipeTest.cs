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

    public KontrolNoktasiScript _kontrolNoktasiScript;

    public GameObject _level1Onboarding;


    private bool _level1Asama1;
    private bool _level1Asama2;
    private bool _level1Asama3;
    private bool _level1Asama4;
    private bool _level1Asama5;
    private bool _level1Asama6;
    private bool _level1Asama7;

    private CubeScript _cubeScript;

    // Start is called before the first frame update
    void Start()
    {
        OkSifirla();
        _levelCanvasScript = GameObject.FindGameObjectWithTag("LevelCanvas").GetComponent<LevelCanvasScript>();
        //_level1Onboarding.SetActive(false);
        _level1Onboarding = GameObject.FindGameObjectWithTag("Level1Onboarding");
        _level1Onboarding.transform.GetChild(0).gameObject.SetActive(false);
        _level1Onboarding.transform.GetChild(1).gameObject.SetActive(false);
        _level1Onboarding.transform.GetChild(2).gameObject.SetActive(false);
        _level1Onboarding.transform.GetChild(3).gameObject.SetActive(false);

    }

    public void OnBoardingKontrol()
    {
        if (_level1Asama1 == false && _level1Asama2 == false && _level1Asama3 == false && _level1Asama4 == false && _level1Asama5 == false && _level1Asama6 == false && _level1Asama7 == false)
        {
            leftArrow.SetActive(false);
            rightArrow.SetActive(true);
            _level1Asama1 = true;
            _level1Onboarding.transform.GetChild(0).gameObject.SetActive(false);
            _level1Onboarding.transform.GetChild(1).gameObject.SetActive(true);
            _level1Onboarding.transform.GetChild(2).gameObject.SetActive(false);
            _level1Onboarding.transform.GetChild(3).gameObject.SetActive(false);
        }
        else if (_level1Asama1 == true && _level1Asama2 == false && _level1Asama3 == false && _level1Asama4 == false && _level1Asama5 == false && _level1Asama6 == false && _level1Asama7 == false)
        {
            _level1Asama2 = true;
            _level1Onboarding.transform.GetChild(0).gameObject.SetActive(true);
            _level1Onboarding.transform.GetChild(1).gameObject.SetActive(false);
            _level1Onboarding.transform.GetChild(2).gameObject.SetActive(false);
            _level1Onboarding.transform.GetChild(3).gameObject.SetActive(false);
        }
        else if (_level1Asama1 == true && _level1Asama2 == true && _level1Asama3 == false && _level1Asama4 == false && _level1Asama5 == false && _level1Asama6 == false && _level1Asama7 == false)
        {
            _level1Asama3 = true;
            _level1Onboarding.transform.GetChild(0).gameObject.SetActive(false);
            _level1Onboarding.transform.GetChild(1).gameObject.SetActive(true);
            _level1Onboarding.transform.GetChild(2).gameObject.SetActive(false);
            _level1Onboarding.transform.GetChild(3).gameObject.SetActive(false);
        }
        else if (_level1Asama1 == true && _level1Asama2 == true && _level1Asama3 == true && _level1Asama4 == false && _level1Asama5 == false && _level1Asama6 == false && _level1Asama7 == false)
        {
            leftArrow.SetActive(false);
            rightArrow.SetActive(true);
            _level1Asama4 = true;
            _level1Onboarding.transform.GetChild(0).gameObject.SetActive(false);
            _level1Onboarding.transform.GetChild(1).gameObject.SetActive(false);
            _level1Onboarding.transform.GetChild(2).gameObject.SetActive(false);
            _level1Onboarding.transform.GetChild(3).gameObject.SetActive(true);
            //_kontrolNoktasiScript = GameObject.FindGameObjectWithTag("KontrolNoktasi").GetComponent<KontrolNoktasiScript>();
            //_kontrolNoktasiScript._kontrolEdilenVagon.GetComponent<CubeScript>().DuraklamaNoktasi();
            //_cubeScript = _kontrolNoktasiScript._kontrolEdilenVagon.GetComponent<CubeScript>();

        }
        else if (_level1Asama1 == true && _level1Asama2 == true && _level1Asama3 == true && _level1Asama4 == true && _level1Asama5 == false && _level1Asama6 == false && _level1Asama7 == false)
        {
            _level1Asama5 = true;
            _level1Onboarding.transform.GetChild(0).gameObject.SetActive(true);
            _level1Onboarding.transform.GetChild(1).gameObject.SetActive(false);
            _level1Onboarding.transform.GetChild(2).gameObject.SetActive(false);
            _level1Onboarding.transform.GetChild(3).gameObject.SetActive(false);

        }
        else if (_level1Asama1 == true && _level1Asama2 == true && _level1Asama3 == true && _level1Asama4 == true && _level1Asama5 == true && _level1Asama6 == false && _level1Asama7 == false)
        {
            rightArrow.SetActive(false);
            leftArrow.SetActive(true);
            _level1Asama6 = true;
            _level1Onboarding.transform.GetChild(0).gameObject.SetActive(true);
            _level1Onboarding.transform.GetChild(1).gameObject.SetActive(false);
            _level1Onboarding.transform.GetChild(2).gameObject.SetActive(false);
            _level1Onboarding.transform.GetChild(3).gameObject.SetActive(false);

        }
        else if (_level1Asama1 == true && _level1Asama2 == true && _level1Asama3 == true && _level1Asama4 == true && _level1Asama5 == true && _level1Asama6 == true && _level1Asama7 == false)
        {
            rightArrow.SetActive(false);
            leftArrow.SetActive(true);
            _level1Asama7 = true;
            _level1Onboarding.transform.GetChild(0).gameObject.SetActive(false);
            _level1Onboarding.transform.GetChild(1).gameObject.SetActive(false);
            _level1Onboarding.transform.GetChild(2).gameObject.SetActive(false);
            _level1Onboarding.transform.GetChild(3).gameObject.SetActive(false);
            _kontrolNoktasiScript = GameObject.FindGameObjectWithTag("KontrolNoktasi").GetComponent<KontrolNoktasiScript>();
            _kontrolNoktasiScript._kontrolEdilenVagon.GetComponent<CubeScript>().DuraklamaNoktasi();

        }
        else if (_level1Asama1 == true && _level1Asama2 == true && _level1Asama3 == true && _level1Asama4 == true && _level1Asama5 == true && _level1Asama6 == true && _level1Asama7 == true)
        {
            rightArrow.SetActive(false);
            leftArrow.SetActive(true);
            _level1Asama7 = true;
            _level1Onboarding.transform.GetChild(0).gameObject.SetActive(false);
            _level1Onboarding.transform.GetChild(1).gameObject.SetActive(false);
            _level1Onboarding.transform.GetChild(2).gameObject.SetActive(false);
            _level1Onboarding.transform.GetChild(3).gameObject.SetActive(false);
            _kontrolNoktasiScript = GameObject.FindGameObjectWithTag("KontrolNoktasi").GetComponent<KontrolNoktasiScript>();
            _kontrolNoktasiScript._kontrolEdilenVagon.GetComponent<CubeScript>().DuraklamaNoktasi();

        }
        else
        {

        }
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
                _levelCanvasScript = GameObject.FindGameObjectWithTag("LevelCanvas").GetComponent<LevelCanvasScript>();
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
                            if (_level1Asama1 == true && _level1Asama2 == false && _level1Asama3 == false && _level1Asama4 == false && _level1Asama5 == false && _level1Asama6 == false && _level1Asama7 == false)
                            {
                                rightArrow.SetActive(false);
                                leftArrow.SetActive(true);
                                _kontrolNoktasiScript = GameObject.FindGameObjectWithTag("KontrolNoktasi").GetComponent<KontrolNoktasiScript>();
                                _kontrolNoktasiScript._kontrolEdilenVagon.GetComponent<CubeScript>().DuraklamaNoktasi();
                                _level1Onboarding.transform.GetChild(0).gameObject.SetActive(false);
                                _level1Onboarding.transform.GetChild(1).gameObject.SetActive(false);
                                _level1Onboarding.transform.GetChild(2).gameObject.SetActive(false);
                                _level1Onboarding.transform.GetChild(3).gameObject.SetActive(false);
                            }
                            else if (_level1Asama1 == true && _level1Asama2 == true && _level1Asama3 == false && _level1Asama4 == false && _level1Asama5 == false && _level1Asama6 == false && _level1Asama7 == false)
                            {

                            }
                            else if (_level1Asama1 == true && _level1Asama2 == true && _level1Asama3 == true && _level1Asama4 == false && _level1Asama5 == false && _level1Asama6 == false && _level1Asama7 == false)
                            {
                                rightArrow.SetActive(false);
                                leftArrow.SetActive(true);
                                _kontrolNoktasiScript = GameObject.FindGameObjectWithTag("KontrolNoktasi").GetComponent<KontrolNoktasiScript>();
                                _kontrolNoktasiScript._kontrolEdilenVagon.GetComponent<CubeScript>().DuraklamaNoktasi();
                                _level1Onboarding.transform.GetChild(0).gameObject.SetActive(false);
                                _level1Onboarding.transform.GetChild(1).gameObject.SetActive(false);
                                _level1Onboarding.transform.GetChild(2).gameObject.SetActive(false);
                                _level1Onboarding.transform.GetChild(3).gameObject.SetActive(false);
                            }
                            else if (_level1Asama1 == true && _level1Asama2 == true && _level1Asama3 == true && _level1Asama4 == true && _level1Asama5 == false && _level1Asama6 == false && _level1Asama7 == false)
                            {
                                rightArrow.SetActive(false);
                                leftArrow.SetActive(true);
                                _kontrolNoktasiScript = GameObject.FindGameObjectWithTag("KontrolNoktasi").GetComponent<KontrolNoktasiScript>();
                                _kontrolNoktasiScript._kontrolEdilenVagon.GetComponent<CubeScript>().DuraklamaNoktasi();
                                //_cubeScript.DuraklamaNoktasi();
                                _level1Onboarding.transform.GetChild(0).gameObject.SetActive(false);
                                _level1Onboarding.transform.GetChild(1).gameObject.SetActive(false);
                                _level1Onboarding.transform.GetChild(2).gameObject.SetActive(false);
                                _level1Onboarding.transform.GetChild(3).gameObject.SetActive(false);
                            }
                            else if (_level1Asama1 == true && _level1Asama2 == true && _level1Asama3 == true && _level1Asama4 == true && _level1Asama5 == true && _level1Asama6 == false && _level1Asama7 == false)
                            {

                            }
                            else if (_level1Asama1 == true && _level1Asama2 == true && _level1Asama3 == true && _level1Asama4 == true && _level1Asama5 == true && _level1Asama6 == true && _level1Asama7 == false)
                            {

                            }
                            else if (_level1Asama1 == true && _level1Asama2 == true && _level1Asama3 == true && _level1Asama4 == true && _level1Asama5 == true && _level1Asama6 == true && _level1Asama7 == true)
                            {

                            }
                            else
                            {

                            }

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
                            if (_level1Asama1 == true && _level1Asama2 == false && _level1Asama3 == false && _level1Asama4 == false && _level1Asama5 == false && _level1Asama6 == false && _level1Asama7 == false)
                            {

                            }
                            else if (_level1Asama1 == true && _level1Asama2 == true && _level1Asama3 == false && _level1Asama4 == false && _level1Asama5 == false && _level1Asama6 == false && _level1Asama7 == false)
                            {
                                leftArrow.SetActive(false);
                                rightArrow.SetActive(true);
                                _kontrolNoktasiScript = GameObject.FindGameObjectWithTag("KontrolNoktasi").GetComponent<KontrolNoktasiScript>();
                                _kontrolNoktasiScript._kontrolEdilenVagon.GetComponent<CubeScript>().DuraklamaNoktasi();
                                _level1Onboarding.transform.GetChild(0).gameObject.SetActive(false);
                                _level1Onboarding.transform.GetChild(1).gameObject.SetActive(false);
                                _level1Onboarding.transform.GetChild(2).gameObject.SetActive(false);
                                _level1Onboarding.transform.GetChild(3).gameObject.SetActive(false);
                            }
                            else if (_level1Asama1 == true && _level1Asama2 == true && _level1Asama3 == true && _level1Asama4 == false && _level1Asama5 == false && _level1Asama6 == false && _level1Asama7 == false)
                            {

                            }
                            else if (_level1Asama1 == true && _level1Asama2 == true && _level1Asama3 == true && _level1Asama4 == true && _level1Asama5 == false && _level1Asama6 == false && _level1Asama7 == false)
                            {

                            }
                            else if (_level1Asama1 == true && _level1Asama2 == true && _level1Asama3 == true && _level1Asama4 == true && _level1Asama5 == true && _level1Asama6 == false && _level1Asama7 == false)
                            {
                                leftArrow.SetActive(false);
                                rightArrow.SetActive(true);
                                _kontrolNoktasiScript = GameObject.FindGameObjectWithTag("KontrolNoktasi").GetComponent<KontrolNoktasiScript>();
                                _kontrolNoktasiScript._kontrolEdilenVagon.GetComponent<CubeScript>().DuraklamaNoktasi();
                                _level1Onboarding.transform.GetChild(0).gameObject.SetActive(false);
                                _level1Onboarding.transform.GetChild(1).gameObject.SetActive(false);
                                _level1Onboarding.transform.GetChild(2).gameObject.SetActive(false);
                                _level1Onboarding.transform.GetChild(3).gameObject.SetActive(false);
                            }
                            else if (_level1Asama1 == true && _level1Asama2 == true && _level1Asama3 == true && _level1Asama4 == true && _level1Asama5 == true && _level1Asama6 == true && _level1Asama7 == false)
                            {
                                leftArrow.SetActive(false);
                                rightArrow.SetActive(true);
                                _kontrolNoktasiScript = GameObject.FindGameObjectWithTag("KontrolNoktasi").GetComponent<KontrolNoktasiScript>();
                                _kontrolNoktasiScript._kontrolEdilenVagon.GetComponent<CubeScript>().DuraklamaNoktasi();
                                _level1Onboarding.transform.GetChild(0).gameObject.SetActive(false);
                                _level1Onboarding.transform.GetChild(1).gameObject.SetActive(false);
                                _level1Onboarding.transform.GetChild(2).gameObject.SetActive(false);
                                _level1Onboarding.transform.GetChild(3).gameObject.SetActive(false);
                            }
                            else if (_level1Asama1 == true && _level1Asama2 == true && _level1Asama3 == true && _level1Asama4 == true && _level1Asama5 == true && _level1Asama6 == true && _level1Asama7 == true)
                            {
                                rightArrow.SetActive(false);
                                leftArrow.SetActive(true);
                                _kontrolNoktasiScript = GameObject.FindGameObjectWithTag("KontrolNoktasi").GetComponent<KontrolNoktasiScript>();
                                _kontrolNoktasiScript._kontrolEdilenVagon.GetComponent<CubeScript>().DuraklamaNoktasi();
                                _level1Onboarding.transform.GetChild(0).gameObject.SetActive(false);
                                _level1Onboarding.transform.GetChild(1).gameObject.SetActive(false);
                                _level1Onboarding.transform.GetChild(2).gameObject.SetActive(false);
                                _level1Onboarding.transform.GetChild(3).gameObject.SetActive(false);
                            }
                            else
                            {
                                //leftArrow.SetActive(false);
                                //rightArrow.SetActive(true);
                            }

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
                    MoreMountains.NiceVibrations.MMVibrationManager.Haptic(MoreMountains.NiceVibrations.HapticTypes.MediumImpact);

                    if (leftArrow.activeSelf)
                    {
                        leftArrow.SetActive(false);
                        barrier1Arrow.SetActive(true);

                    }

                    else if (barrier1Arrow.activeSelf)
                    {
                        //barrier1Arrow.SetActive(false);
                        //barrier2Arrow.SetActive(true);
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
                    MoreMountains.NiceVibrations.MMVibrationManager.Haptic(MoreMountains.NiceVibrations.HapticTypes.MediumImpact);

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
                        //barrier2Arrow.SetActive(false);
                        //barrier1Arrow.SetActive(true);
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

            rightArrow.SetActive(true);


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