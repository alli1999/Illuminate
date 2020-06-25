using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public GameObject Hero;
    AudioSource music;

    void Start()
    {
        music = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        this.transform.Rotate(0, 180, 0, Space.Self);
        music.Play();
        if (Hero.GetComponent<Renderer>().material.color != this.GetComponent<Renderer>().material.color)
        {
            colorReset.colors += 1;
        }
        
        if (other.name == "Hero")
        {
            if (Hero.GetComponent<Renderer>().material.color == Color.white)
            {
                UnityEngine.Debug.Log(other.name);
                Color color2 = this.GetComponent<Renderer>().material.color;
                UnityEngine.Debug.Log(color2);

                Hero.GetComponent<Renderer>().material.color = color2;

                if (this.name == "Yellow")
                {
                    Hero.GetComponent<Renderer>().material.color = Color.yellow;
                    UnityEngine.Debug.Log("COLOR2" + Hero.GetComponent<Renderer>().material.color);
                }
            }
            else
            {
                Color color1 = Hero.GetComponent<Renderer>().material.color;
                Color color2 = this.GetComponent<Renderer>().material.color;
                if (this.name == "Yellow")
                {
                    color2 = Color.yellow;
                }
                UnityEngine.Debug.Log("Color1: " + color1);
                UnityEngine.Debug.Log("Color2: " + color2);

                if((color1 == Color.red && color2 == Color.blue) || (color2 == Color.red && color1 == Color.blue))
                {
                    Color purple = new Color(1, 0, 1, 1);
                    Hero.GetComponent<Renderer>().material.color = purple;
                }
                else if ((color1 == Color.red && color2 == Color.green) || (color2 == Color.red && color1 == Color.green))
                {
                    Hero.GetComponent<Renderer>().material.color = Color.yellow;
                }
                else if ((color1 == Color.red && color2 == Color.yellow) || (color2 == Color.red && color1 == Color.yellow))
                {
                    Color orange = new Color(1, (float)0.461, (float)0.008, 1);
                    Hero.GetComponent<Renderer>().material.color = orange;
                }
                else if ((color1 == Color.blue && color2 == Color.green) || (color2 == Color.blue && color1 == Color.green))
                {
                    Color greenblue = new Color(0, 1, 1, 1);
                    Hero.GetComponent<Renderer>().material.color = greenblue;
                }
                else if ((color1 == Color.blue && color2 == Color.yellow) || (color2 == Color.blue && color1 == Color.yellow))
                {
                    Hero.GetComponent<Renderer>().material.color = Color.green;
                }
                else if ((color1 == Color.green && color2 == Color.yellow) || (color2 == Color.green && color1 == Color.yellow))
                {
                    Color greenyellow = new Color( (float)128/255, 1, 0, 1);
                    Hero.GetComponent<Renderer>().material.color = greenyellow;
                }

                //Hero.GetComponent<Renderer>().material.color = Color.Lerp(color1, color2, (float) 0.5);
            }
            
        }
    }
}
