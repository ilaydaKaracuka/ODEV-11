using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buton : MonoBehaviour
{
    public void Exit()
    {
        Application.Quit();
    }
    public void Startli()   //start ve try again butonlarý için
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        // SceneManager.LoadScene(0);



    }
}
