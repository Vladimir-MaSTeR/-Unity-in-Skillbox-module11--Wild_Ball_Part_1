using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{

    [SerializeField, Range(0, 10)] private float speed = 2.0f;
    [SerializeField, Range(0, 10)] private float jumpPower = 2.0f;


    private Rigidbody playerRigidBody;
    private Vector3 movement;
    private Vector3 jump;


    // Start is called before the first frame update
    void Awake()
    {
        playerRigidBody = GetComponent<Rigidbody>();
    }


    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis(GlobalStringsVars.HORIZONTAL_AXIS);
        float vertical = Input.GetAxis(GlobalStringsVars.VERTICAL_AXIS);
        float jum = Input.GetAxis(GlobalStringsVars.JUMP_BUTTON);

        movement = new Vector3(horizontal, 0, vertical).normalized;
        jump = new Vector3(transform.position.x, jum * jumpPower, transform.position.z).normalized;
       
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        if (true)
        {

        }
        playerRigidBody.AddForce(movement * speed);
    }
}
