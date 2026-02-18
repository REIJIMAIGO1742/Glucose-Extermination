using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class Hightscore : MonoBehaviour
{
    public TextMeshProUGUI Highyer;
    public TextMeshProUGUI scoret;

    int H;
    int S;

    private void Start()
    {
        
    }
    private void Awake()
    {
        
       
            Highyer.text = Scoremanager.instance.higtscoretexrt.text;
            
        
            //scoret.text = Scoremanager.instance.higtscoretexrt.text;
        
    }
}
