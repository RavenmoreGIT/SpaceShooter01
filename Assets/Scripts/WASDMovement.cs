using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class WASDMovement : MonoBehaviour
{
    public float MovementSpeed;
    private float DeltaTimeMovementSpeed = 0f;
   
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        DeltaTimeMovementSpeed = Time.deltaTime * MovementSpeed;
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left*DeltaTimeMovementSpeed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right* DeltaTimeMovementSpeed;
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.up* DeltaTimeMovementSpeed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.down* DeltaTimeMovementSpeed;
        }
    }
}
