using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void OnBotonJugar()
    {
        SceneManager.LoadScene("Nivel1");
    }

    public void OnBotonCreditos()
    {
        SceneManager.LoadScene("Creditos");
    }

    public void OnBotonMenu()
    {
        SceneManager.LoadScene("Menu");
    }

}
