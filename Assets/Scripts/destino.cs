using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destino : MonoBehaviour
{

    public LayerMask ObjMov;

    Vector2 position;
    // Start is called before the first frame update
    void Start()
    {
        position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D rh;

        rh = Physics2D.Raycast(position, position, 0, ObjMov);


        if (rh.collider != null )
        {
            
        }




    }
}
