using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public bool IsOpened = false;
    public GameObject key;

    public void OnClick()
    {
        IsOpened = !IsOpened;
        transform.Rotate(0, 90, 0);
        transform.Translate(1, 0, 0);
        //isStatic = true;
    }
}
