using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Scoremanager : MonoBehaviour
{
    public static Scoremanager instance;

    public TextMeshProUGUI ScoreText;
    public TextMeshProUGUI higtscoretexrt;

    int score = 0;
    //int setzero = 0;
    int higtscore = 0;

    public void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        //higtscoretexrt.text = ""+ setzero.ToString();
        higtscore = PlayerPrefs.GetInt("higtscore", 0);
        ScoreText.text = score.ToString() + "";
        higtscoretexrt.text = "" + higtscore.ToString();
    }

    public void Addpoint()
    {
        score += 1;
        ScoreText.text = score.ToString() + "";
        if (higtscore < score)
        PlayerPrefs.SetInt("higtscore", score);


    }
}
