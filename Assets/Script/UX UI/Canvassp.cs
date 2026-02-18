
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class Canvassp : MonoBehaviour
{

    

    public Canvas canvas;

    //public string scean;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        canvas.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.anyKey)
        {

            canvas.gameObject.SetActive(true);
            gameObject.SetActive(false);
;            

        }
        



    }




    public void PlayBotton()

    {
        SceneManager.LoadScene("Playscean");



    }

    public void Main()

    {
        SceneManager.LoadScene("Mainscean");



    }

    public void SettingBotton()

    {
        SceneManager.LoadScene("Setting");

    }

    public void Quit()

    {
        Application.Quit();

    }







}
