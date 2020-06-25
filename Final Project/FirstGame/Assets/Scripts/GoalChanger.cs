using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalChanger : MonoBehaviour
{
    public GameObject Hero;
    public GameObject ExplosionEffect;
    public static Boolean exploded = false;
    public static int points = 0;

    // Start is called before the first frame update
    void Start()
    {
        int choice = UnityEngine.Random.Range(1, 5);
        Color orange = new Color(1, (float)0.461, (float)0.008, 1);
        Color purple = new Color(1, 0, 1, 1);
        Color greenblue = new Color(0, 1, 1, 1);
        Color greenyellow = new Color((float)128 / 255, 1, 0, 1);
        Color[] colors = { orange, purple, greenblue, greenyellow};
        GetComponent<Renderer>().material.color = colors[choice - 1];
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //Instantiate(ExplosionEffect, transform.position, transform.rotation);
        UnityEngine.Debug.Log("BOOM!!!");

        if (other.name == "Hero")
        {
            if(Hero.GetComponent<Renderer>().material.color == GetComponent<Renderer>().material.color)
            {
                if (!exploded)
                {
                    Explode();
                }
            }
            else
            {
                UnityEngine.Debug.Log("You Lose");
                SceneManager.LoadScene(2);
            }
        }
    }

   void Explode()
    {
        Instantiate(ExplosionEffect, transform.position, transform.rotation);
        exploded = true;
        ExplosionEffect.GetComponent<ParticleSystem>().Stop();
        points += 100;
        Destroy(gameObject);
    }
}
