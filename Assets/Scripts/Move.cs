using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum Direction{
    up,down,right,left
}




public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    Direction direction;
    public float movPJ = 2f;
    Vector3 myPosition;
    public LayerMask cajaMov;
    public LayerMask obstaculo;
    
    

    void Start()
    {
        myPosition = transform.position;
    }
    
    
    // Update is called once per frame
    void Update()
    {
        Vector2 dir = Vector2.zero;
        RaycastHit2D rh;
        RaycastHit2D rhMov;
        RaycastHit2D rhMovObs;
        //Direccion de deteccion

        if (myPosition == transform.position)
        {
            if (Input.GetKeyDown(KeyCode.A)) dir = Vector2.left;
            if (Input.GetKeyDown(KeyCode.D)) dir = Vector2.right;
            if (Input.GetKeyDown(KeyCode.W)) dir = Vector2.up;
            if (Input.GetKeyDown(KeyCode.S)) dir = Vector2.down;

        }


        rh = Physics2D.Raycast(transform.position, dir, 1, obstaculo);
        rhMov = Physics2D.Raycast(transform.position, dir, 1, cajaMov);
        rhMovObs = Physics2D.Raycast(transform.position, dir, 2, obstaculo);

        // Ejecucion del moviminto

        if(myPosition != transform.position)
        {
            MoveObj.llego = false;
        }

        if (myPosition == transform.position)
        {
            MoveObj.llego = true;

            if (Input.GetKeyDown(KeyCode.A))
            {
                if (!rh.collider)
                {
                    if(!rhMov.collider && !rhMovObs.collider || rhMov.collider && !rhMovObs.collider || !rhMov.collider && rhMovObs.collider)
                    {
                        myPosition += Vector3.left;
                    }
                }               
                direction = Direction.left;
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                if (!rh.collider)
                {
                    if (!rhMov.collider && !rhMovObs.collider || rhMov.collider && !rhMovObs.collider || !rhMov.collider && rhMovObs.collider)
                    {
                        myPosition += Vector3.right;
                    }
                }
                direction = Direction.right;
            }
            else if (Input.GetKeyDown(KeyCode.W))
            {
                if (!rh.collider)
                {
                    if (!rhMov.collider && !rhMovObs.collider || rhMov.collider && !rhMovObs.collider || !rhMov.collider && rhMovObs.collider)
                    {
                        myPosition += Vector3.up;
                    }
                }
                direction = Direction.up;
            }
            else if (Input.GetKeyDown(KeyCode.S))
            {
                if (!rh.collider)
                {
                    if (!rhMov.collider && !rhMovObs.collider || rhMov.collider && !rhMovObs.collider || !rhMov.collider && rhMovObs.collider)
                    {
                        myPosition += Vector3.down;
                    }
                }
                direction = Direction.down;
            }
        }
        transform.position = Vector3.MoveTowards(transform.position, myPosition, movPJ * Time.deltaTime);
    }

}
