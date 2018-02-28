using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
//using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.PostProcessing;
using UnityEngine.UI;
public class GameManagerDimensiones : MonoBehaviour
{
    public KeyCode cambiar = KeyCode.Keypad5;

    public byte opacidad = 30;
    GameObject[] objetosVerdes;
    GameObject[] objetosAzules;
    Text textYear;

   // GameObject UI_key;

    public bool dimension = true;
    public bool withkey = false;

    int nivel = 0;

    SpriteRenderer cielo;
	void Start () {

     //  UI_key = GameObject.Find("Image_Key");
        BuscarObjetos();
        CambiarMundo(dimension);
        textYear = GameObject.Find("TextYear").GetComponent<Text>();
      //  UI_key.GetComponent<Image>().color = new Color32(255, 255, 255, opacidad);
       
	}

    public void BuscarObjetos()
    {
        objetosVerdes = GameObject.FindGameObjectsWithTag("verde");
        objetosAzules = GameObject.FindGameObjectsWithTag("azul");
    }
    public void NextLevel() {
       Application.LoadLevel(Application.loadedLevel + 1);
        //print("deberia pasar de nivel");
    }

    void SetMass()
    {
        if (Input.GetKey(KeyCode.LeftControl))
        {
            GetComponent<Rigidbody2D>().mass = 5;
           //gameObject.layer = 11;
        }
        else 
        {
            GetComponent<Rigidbody2D>().mass = 1;
            //gameObject.layer = 10;
        }
    }
	void Update () {

        SetMass();
        /*if (Input.GetButtonDown("Fire1"))
        {

            dimension = !dimension;
        }
         
         
         */ //solo para pc


        if (Input.GetKeyDown(cambiar))
        {

            dimension = !dimension;
        }
        CambiarMundo(dimension);
        SetPostProcesing();
        if (withkey)
        {

     //   UI_key.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }
	}


    void ObtenerLlave()
    {
        withkey = true;
    }


    //para ocultar los efectos de camara 
    public bool setPostProcessing = false;
    public PostProcessingProfile profile1;
    public PostProcessingProfile profile2;
    void SetPostProcesing()
    {
        if (setPostProcessing)
        {
            if (Input.GetKeyDown(cambiar))
            {
                GameObject camara = GameObject.Find("Main Camera");
            if (camara.GetComponent<PostProcessingBehaviour>().profile == profile1)
            {
                camara.GetComponent<PostProcessingBehaviour>().profile = profile2;
                
                textYear.text = "2018";
            }
            else
            {
                camara.GetComponent<PostProcessingBehaviour>().profile = profile1;
                textYear.text = "2038";
            }
            }
            
        }
       
    }
    void CambiarMundo(bool dim)
    {
        
       
        //cielo = GameObject.Find("cielo").GetComponent<SpriteRenderer>();
        if (dim)
        {
            
            for (int i = 0; i < objetosAzules.Length; i++)
            {
              //  objetosAzules[i].gameObject.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, opacidad);
              //  objetosAzules[i].gameObject.GetComponent<BoxCollider2D>().enabled = false;
               // Camera.main.backgroundColor = new Color32(67, 73, 54, 0);
               // cielo.enabled = true;
                objetosAzules[i].gameObject.SetActive(true);
                
            }
            for (int i = 0; i < objetosVerdes.Length; i++)
            {
             //   objetosVerdes[i].gameObject.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 255);
              //  objetosVerdes[i].gameObject.GetComponent<BoxCollider2D>().enabled = true;
                objetosVerdes[i].gameObject.gameObject.SetActive(false);
            }

           
        }
        else
        {
            
            for (int i = 0; i < objetosAzules.Length; i++)
            {
                objetosAzules[i].gameObject.SetActive(false);
               // objetosAzules[i].gameObject.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 255);
               // objetosAzules[i].gameObject.GetComponent<BoxCollider2D>().enabled = true;
               // Camera.main.backgroundColor = new Color32(54, 63, 73, 0);
              //  cielo.enabled = false;

            }
            for (int i = 0; i < objetosVerdes.Length; i++)
            {
               // objetosVerdes[i].gameObject.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, opacidad);
               // objetosVerdes[i].gameObject.GetComponent<BoxCollider2D>().enabled = false;
                objetosVerdes[i].gameObject.gameObject.SetActive(true);
               
            }


        }
    }
                
    
}
