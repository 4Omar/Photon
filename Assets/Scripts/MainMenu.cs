using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EscenaJuego()
    {
        SceneManager.LoadScene("GameScene");
    }


    public void EscenaCreditos()
    {
        SceneManager.LoadScene("Creditos");
    }

    public void Salir()
    {
        Debug.Log("Saliendo");
        Application.Quit();
    }

    public void EscenaMenu()
    {
        SceneManager.LoadScene("Menu");
    }




}
