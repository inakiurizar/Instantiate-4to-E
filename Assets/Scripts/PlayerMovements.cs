using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    public Vector3 playerPosition;
    public float rotationSpeed;
    public float movementSpeed;
    // Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        // cam = GetComponent<Camera>(); // referencia a un componente
        playerPosition = transform.position + new Vector3(0, 1, 0);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, movementSpeed, 0);
        } else if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(0, 0, -movementSpeed);
        } else if (Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(0, -movementSpeed, 0);
        } else if(Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(0, 0, movementSpeed);
        } else if(Input.GetKey(KeyCode.Q))
        {
            transform.position += new Vector3(movementSpeed, 0, 0);
        } else if (Input.GetKey(KeyCode.E))
        {
            transform.position += new Vector3(-movementSpeed, 0, 0);
        }

        //transform.position += new Vector3(0, 0, 0);
        transform.eulerAngles += new Vector3(0, rotationSpeed, 0);
        //transform.localScale += new Vector3(0, 0, 0.1f);
    }
}
