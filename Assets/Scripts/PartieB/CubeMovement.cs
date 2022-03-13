using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    [SerializeField]
    private float vitesseX;

    [SerializeField]
    private float vitesseY;

    //true = droite, false = gauche
    [SerializeField]
    private bool directionX;

    void Update()
    {
        if (directionX)
        {
            transform.Translate(Vector3.right * (vitesseX * Time.deltaTime));
        }
        if (!directionX)
        {
            transform.Translate(Vector3.left * (vitesseX * Time.deltaTime));
        }

        transform.Translate(Vector3.forward * (vitesseY * Time.deltaTime));
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("RightWall"))
        {
            directionX = false;
        }
        if (collision.collider.CompareTag("LeftWall"))
        {
            directionX = true;
        }
    }
}
