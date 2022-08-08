using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour
{

    [SerializeField, Range(0, 10)] private float speed = 2.0f;
    [SerializeField, Range(0, 10)] private float jumpPower = 2.0f;


    private CharacterController characterController;
    private Animator animator;

    private float gravityForce; // гравитация персонажа
    private Vector3 movement;   // направление движения персонажа
    


    // Start is called before the first frame update
    void Awake()
    {
        characterController = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }


    private void Update()
    {
        MovePlayer();
        GamingGravity();
    }

    private void MovePlayer()
    {

        movement = Vector3.zero;
        movement.x = Input.GetAxis(GlobalStringsVars.HORIZONTAL_AXIS) * speed;
        movement.z = Input.GetAxis(GlobalStringsVars.VERTICAL_AXIS) * speed;

        movement.y = gravityForce; 
        characterController.Move(movement * Time.deltaTime); 

    }

    //метод гравитации
    private void GamingGravity()
    {
        if (!characterController.isGrounded)
        {
            gravityForce -= 20f * Time.deltaTime;
        } else
        {
            gravityForce = -2f; 
        }

        // прыжок
        if (Input.GetKeyDown(KeyCode.Space) && characterController.isGrounded) 
        {
            gravityForce = jumpPower;
        }
    }
}
