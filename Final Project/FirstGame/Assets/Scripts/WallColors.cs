using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallColors : MonoBehaviour
{
    public GameObject Hero;
    // Start is called before the first frame update
    void Start()
    {
        Color[] colors = { Color.red, Color.blue, Color.green};
        int i = Random.Range(0, 3);
        this.GetComponent<Renderer>().material.color = colors[i];
    }

    // Update is called once per frame
    void Update()
    {
        if (Hero.GetComponent<Renderer>().material.color == Color.white)
        {
            this.GetComponent<MeshCollider>().enabled = false;
        }
        else if(Hero.GetComponent<Renderer>().material.color == this.GetComponent<Renderer>().material.color){
            this.GetComponent<MeshCollider>().enabled = false;
        }
        else
        {
            this.GetComponent<MeshCollider>().enabled = true;
        }
    }
}
