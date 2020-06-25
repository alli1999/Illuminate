using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PossibleGame : MonoBehaviour
{
    public GameObject WallR, WallG, WallB, WallY;
    public GameObject gameCube;
    Color redWall, greenWall, blueWall, yellowWall, cubeColor;
    string color;
    int i = 1;

    // Update is called once per frame
    void Update()
    {
        while(i == 1)
        {
            redWall = WallR.GetComponent<Renderer>().material.color;
            greenWall = WallG.GetComponent<Renderer>().material.color;
            blueWall = WallB.GetComponent<Renderer>().material.color;
            yellowWall = WallY.GetComponent<Renderer>().material.color;
            cubeColor = gameCube.GetComponent<Renderer>().material.color;

            if (cubeColor[0] == 1 && cubeColor[1] == 0 && cubeColor[2] == 1)
            {
                color = "purple";
            }
            else if(cubeColor[0] == 1 && cubeColor[1] == (float)0.461 && cubeColor[2] == (float)0.008){
                color = "orange";
            }
            else if (cubeColor[0] == 0 && cubeColor[1] == 1 && cubeColor[2] == 1){
                color = "bluegreen";
            }
            else if (cubeColor[0] == (float)128 / 255 && cubeColor[1] == 1 && cubeColor[2] == 0){
                color = "greenyellow";
            }

            if(color == "purple")
            {
                if(redWall == Color.blue || blueWall == Color.red) { }
                else 
                {
                    UnityEngine.Debug.Log("ResetP");
                    SceneManager.LoadScene(1);
                }
            }
            else if(color == "orange")
            {
                if(yellowWall == Color.red) { }
                else
                {
                    UnityEngine.Debug.Log("ResetO");
                    SceneManager.LoadScene(1);
                }
            }
            else if(color == "bluegreen")
            {
                if(blueWall == Color.green || greenWall == Color.blue) { }
                else
                {
                    UnityEngine.Debug.Log("ResetBG");
                    SceneManager.LoadScene(1);
                }
            }
            else if (color == "greenyellow")
            {
                if (yellowWall == Color.green) { }
                else
                {
                    UnityEngine.Debug.Log("ResetBG");
                    SceneManager.LoadScene(1);
                }
            }
            i++;
        }
    }
}
