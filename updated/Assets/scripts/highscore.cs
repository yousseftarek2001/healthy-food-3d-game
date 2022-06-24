using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class highscore : MonoBehaviour
{
    public Transform PlayerMovement;
    public Text scoretext;
    public float Score;
    void Update()
    {
        
        Score = PlayerMovement.position.z;
        scoretext.text =Score.ToString("0");

    }
        
    
}