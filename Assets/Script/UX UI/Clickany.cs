using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Clickany : MonoBehaviour
{
    public string scean;

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey)
        {


            SceneManager.LoadScene(scean);

        }
    }
}
