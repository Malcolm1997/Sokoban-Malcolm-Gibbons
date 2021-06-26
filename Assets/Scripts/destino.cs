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

    // Start is called before the first frame update
    void Start()
    {

        sprite = GetComponent<SpriteRenderer>();
        position = transform.position;
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
        }
        else
        {
            sprite.color = blue;
            destinoLlego = false;
        }




    }
}
