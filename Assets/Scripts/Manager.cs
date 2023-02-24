using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public int starCount;
    public int jumpPadCount;

    public Text UiText;
    void Start()
    {
        
    }


    void Update()
    {
        UiText.text = "Stars: " + starCount.ToString() + "/5\nJump Pads: " + jumpPadCount.ToString() + "/30";
    }
}
