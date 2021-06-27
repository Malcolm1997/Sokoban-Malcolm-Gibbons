using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Sprites;


public class destino : MonoBehaviour
{

    public LayerMask ObjMov;
    
    Vector2 position;

    public Color orange  = Color.magenta;
    public Color blue = Color.blue;
    public SpriteRenderer sprite;
    public static bool destinoLlego;
    public Color actualColor;
    public GameObject child;
    public GameObject padre;

    // Start is called before the first frame update
    void Start()
    {

        sprite = GetComponent<SpriteRenderer>();
        position = transform.position;
        padre = gameObject;
        child = padre.transform.GetChild(0).gameObject;

    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D rh;

        rh = Physics2D.Raycast(position, position, 0, ObjMov);
        


        if (rh.collider != null )
        {
            sprite.color = orange;
            destinoLlego = true;
            Destroy(child);
        }
        else
        {
            sprite.color = blue;
            destinoLlego = false;
        }

        actualColor = sprite.color;



    }
}
