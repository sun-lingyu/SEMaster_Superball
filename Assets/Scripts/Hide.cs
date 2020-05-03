using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hide : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject tar;

    void Start()
    {
        Hide_Panel(tar);
    }


    void Hide_Panel(GameObject a)
    {
    	a.SetActive(false);

    }
    
}
