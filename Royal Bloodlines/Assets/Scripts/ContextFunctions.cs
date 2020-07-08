using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContextFunctions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }


    public void Disappear()
    {
        GameObject.Find("Canvas/Context Menu").SetActive(false);
    }


}
