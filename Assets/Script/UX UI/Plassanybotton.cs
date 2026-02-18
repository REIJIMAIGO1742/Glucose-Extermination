using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public enum alphaValue 
{ 
    SHRINKING, 
    GROWING 
}
public class Plassanybotton : MonoBehaviour
{
    public alphaValue currentAlphaValue;
    public float CommentminAlpha;
    public float CommentmaxAlpha;
    public float CommentCurrentAlpha;
    public TextMeshProUGUI MyText;
    void Start()
    {
        CommentminAlpha = 0f;
        CommentmaxAlpha = 1.0f;
        CommentCurrentAlpha = 1.0f;
        currentAlphaValue = alphaValue.SHRINKING;
    }
    void Update()
    {
        alphaComments();
    }
    public void alphaComments()
    {
        if (currentAlphaValue == alphaValue.SHRINKING)
        {
            CommentCurrentAlpha = CommentCurrentAlpha - 0.050f;
            MyText.color = new Color(Color.white.r, Color.white.g, Color.white.b, CommentCurrentAlpha);
            if (CommentCurrentAlpha <= CommentminAlpha)
            {
                currentAlphaValue = alphaValue.GROWING;
            }
        }
        else
        if (currentAlphaValue == alphaValue.GROWING)
        {
            CommentCurrentAlpha = CommentCurrentAlpha + 0.050f; MyText.color = new Color(Color.white.r, Color.white.g, Color.white.b, CommentCurrentAlpha);
            if (CommentCurrentAlpha >= CommentmaxAlpha)
            {
                currentAlphaValue = alphaValue.SHRINKING;
            }
        }
    }
}   