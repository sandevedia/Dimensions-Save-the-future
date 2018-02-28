using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour {

    //public Transform escenaPrefab;
   
 
    public void ReiniciarEscena(int escena)
    {
        SceneManager.LoadScene(escena);
    }
}
