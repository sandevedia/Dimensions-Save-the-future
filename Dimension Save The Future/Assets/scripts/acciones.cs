using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum State
{
    desciende, abeja ,asciende, impulsar, estirarVertical, estirarHorizontal
}



public class acciones : MonoBehaviour {

    string accion;
    public State actividad;
    
    
    bool isTouching = false;
    public float intensidad = 2.0f;

    GameObject jugador;

   

	void Start () {
        accion = actividad.ToString();
        jugador = GameObject.FindGameObjectWithTag("Player");
	}

    void OnCollisionEnter2D(Collision2D other) {

        if (other.gameObject.tag == "Player")
        {
            isTouching = true;
        }
       
    }

    void OnCollisionExit2D(Collision2D other)
    {

        if (other.gameObject.tag == "Player")
        {
            isTouching = false;
        }
    }


	// Update is called once per frame
	void FixedUpdate () {

        if(!GetComponent<BoxCollider2D>().enabled){
            //print("desactivado");
            return;
        }
        
        switch (accion)
        {


            case "desciende":

                if (isTouching)
                {
                    transform.Translate(Vector2.down * Time.deltaTime * intensidad);
                }
                break;

            case "abeja":

                
                if (transform.position.x > -10)
                {
                    transform.Translate(Vector2.left * Time.deltaTime * intensidad);
                       
                }else {
                    transform.position = new Vector2(jugador.transform.position.x + 10, transform.position.y);
                }
                break;
        
        
        
        }
	}
}
