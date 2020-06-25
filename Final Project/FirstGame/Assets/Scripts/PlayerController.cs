using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    AudioSource music;
    public Animator anim;

    void Start()
    {
        music = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetFloat("vertical", Input.GetAxis("Vertical"));
        anim.SetFloat("horizontal", Input.GetAxis("Horizontal"));
        if (GoalChanger.exploded) 
        {
            music.Play();
            Invoke("Destroy", 1);
            GoalChanger.exploded = false;
        }
    }

    void Destroy()
    {
        SceneManager.LoadScene(1);
    }
}
