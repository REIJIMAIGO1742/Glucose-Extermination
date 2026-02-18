using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Musetrue : MonoBehaviour
{

    public AudioSource BG;
    public static Musetrue musetre;
    // Start is called before the first frame update
    private void Awake()
    {
        musetre = this;

        BG.mute = Musesong.instance.mute;


        //scoret.text = Scoremanager.instance.higtscoretexrt.text;

    }



    public void musetrue (bool musesan)
    {
        BG.mute = musesan;
    }
}
