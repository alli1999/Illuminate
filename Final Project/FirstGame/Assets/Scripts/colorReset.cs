using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorReset : MonoBehaviour
{
    public GameObject Hero;
    public static int colors = 0;

    // Update is called once per frame
    void Update()
    {
        if (colors > 2)
        {
            Hero.GetComponent<Renderer>().material.color = Color.white;
            colors = 0;
        }
    }
}
