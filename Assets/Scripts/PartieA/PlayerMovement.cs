using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float vitesse;

    private Rigidbody cube;

    private void Start()
    {
        cube = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Vector3 velocity = cube.velocity;
        if (Input.GetKey(KeyCode.A))
        {
            velocity.x = vitesse * -10.0f;
        }
        if (Input.GetKey(KeyCode.D))
        {
            velocity.x = vitesse * 10.0f;
        }
        if (Input.GetKey(KeyCode.W))
        {
            velocity.z = vitesse * 10.0f;
        }
        if (Input.GetKey(KeyCode.S))
        {
            velocity.z = vitesse * -10.0f;
        }
        cube.velocity = velocity;

        //ceci est l'original, j'ai voulue utiliser le rigid body pour ne pas avoir a dealer avec
        //le fait que mon cube hit les "Blockers". J'ai du rajouter du drag, aussi non il glissait tout le long
        //ps : je sais que c'est du code inutiliser, mais je voulais que tu vois la difference
        //if (Input.GetKey(KeyCode.A))
        //{
        //    transform.Translate(Vector3.left * (vitesse * Time.deltaTime));
        //}
        //if (Input.GetKey(KeyCode.D))
        //{
        //    transform.Translate(Vector3.right * (vitesse * Time.deltaTime));
        //}
        //if (Input.GetKey(KeyCode.W))
        //{
        //    transform.Translate(Vector3.forward * (vitesse * Time.deltaTime));
        //}
        //if (Input.GetKey(KeyCode.S))
        //{
        //    transform.Translate(Vector3.back * (vitesse * Time.deltaTime));
    }
}
