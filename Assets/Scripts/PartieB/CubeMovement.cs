using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    [SerializeField]
    private float vitesseX;

    [SerializeField]
    private float vitesseY;

    private bool directionX;

    // Start is called before the first frame update
    void Start()
    {
        //true = droite false = gauche
        directionX = true;
    }

    // Update is called once per frame
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
            Debug.Log("Hit right wall");
        }
        if (collision.collider.CompareTag("LeftWall"))
        {
            directionX = true;
            Debug.Log("Hit left wall");
        }
    }
}
