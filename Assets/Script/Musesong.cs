using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Musesong : MonoBehaviour
{
    
    public bool mute;
    public Musetrue museset;
    public static Musesong instance;
    public AudioSource BG2;
  


    public void Awake()
    {
        instance = this;
        BG2.mute = Musetrue.musetre.BG.mute;

    }


    // Update is called once per frame
    void Update()
    {
        
    }

    public void muse()
    {
        mute = true;
        museset.musetrue(mute);

    }

    public void unmuse()
    {
        mute = false;
        museset.musetrue(mute);
        print("musse");
    }



}
