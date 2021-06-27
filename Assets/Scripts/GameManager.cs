using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Sprites;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    Scene escena;
    public static int punt;
    public GameObject destino1;
    public GameObject destino2;
    public Text victoria;


    // Start is called before the first frame update
    void Start()
    {
        destino1 = GameObject.Find("objFinal/punt");
        destino2 = GameObject.Find("objFinal (1)/punt");
        punt = 0;
        escena = GetComponent<Scene>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(escena.name);
        }

        destino1 = GameObject.Find("objFinal/punt");
        destino2 = GameObject.Find("objFinal (1)/punt");

        if(destino1 == null && destino2 == null)
        {
            victoria.text = "Ganaste";
        }


    }

}
