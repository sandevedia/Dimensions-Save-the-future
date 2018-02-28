using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UImanager : MonoBehaviour {



    public void Jugar(int nivel)
    {
        Application.LoadLevel(nivel);
    }

    public void Salir()
    {
        Application.Quit();
    }
}
