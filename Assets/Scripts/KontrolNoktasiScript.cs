using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KontrolNoktasiScript : MonoBehaviour
{
    public GameObject _kontrolEdilenVagon;

    private void OnTriggerEnter(Collider other)
    {
        _kontrolEdilenVagon = other.gameObject;
    }

    private void OnTriggerExit(Collider other)
    {
        // _kontrolEdilenVagon = null;
    }
}
