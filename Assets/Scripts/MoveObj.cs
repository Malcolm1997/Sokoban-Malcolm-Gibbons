using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MoveObj : MonoBehaviour
{
    // Start is called before the first frame update

    Vector2 dir;
    Vector2 position;
    Vector2 dirObj;
    public LayerMask pj;
    public LayerMask Obs;
    public static bool llego = false;
    float movPJ = 2f;
    void Start()
    {
        position = transform.position;
    }


    // Update is called once per frame
    void Update()
    {   
        // deteccion de el empuje
        dir = Vector2.zero;
            if (Input.GetKeyDown(KeyCode.A)) dir = Vector2.right;
            if (Input.GetKeyDown(KeyCode.D)) dir = Vector2.left;
            if (Input.GetKeyDown(KeyCode.W)) dir = Vector2.down;
            if (Input.GetKeyDown(KeyCode.S)) dir = Vector2.up;
           

        RaycastHit2D rh;
        RaycastHit2D rhObs;
        rh = Physics2D.Raycast(position, dir, 1f, pj);
        rhObs = Physics2D.Raycast(position, -dir, 1f, Obs);

        // Movimiento del objeto

        if (llego)
        {
            if (rhObs.collider == null)
            {
                if (rh.collider != null)
                {
                    if (transform.position.x == position.x && transform.position.y == position.y)
                    {
                        if (Input.GetKeyDown(KeyCode.D))
                        {
                            position -= dir;
                        }
                        else if (Input.GetKeyDown(KeyCode.A))
                        {
                            position -= dir;
                        }
                        else if (Input.GetKeyDown(KeyCode.S))
                        {
                            position -= dir;
                        }
                        else if (Input.GetKeyDown(KeyCode.W))
                        {
                            position -= dir;
                        }
                    }
                }
            }
        }   
        transform.position = Vector2.MoveTowards(transform.position, position, movPJ * Time.deltaTime);
    }
}
