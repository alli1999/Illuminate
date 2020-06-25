using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FInalScore : MonoBehaviour
{
    private Text text;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        text.text = "Game Over \n You Lose!!! \n\n Score: " + GoalChanger.points;
        GoalChanger.points = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
