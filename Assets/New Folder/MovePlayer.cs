using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public Rigidbody2D rdb;
    public float velocidade = 10;
    public SpriteRenderer fogo1, fogo2;
    // Start is called before the first frame update
    void Start()
    {
  
    }

    // Update is called once per frame
    void Update()
    {
       
    }


    private void FixedUpdate() { Movimentos(); }


    void Movimentos()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rdb.AddTorque(-3);

         

        }
        if (Input.GetKey(KeyCode.A))
        {
            rdb.AddTorque(3);

            

        }
        if (Input.GetKey(KeyCode.S))
        {

        }
            

        if (Input.GetKey(KeyCode.W))

        {
            rdb.AddRelativeForce(Vector2.up * velocidade);
            fogo1.enabled = true;
            fogo2.enabled = true;
        }
        else
        {
            fogo1.enabled = false;
            fogo2.enabled = false;
        }

    }
}
