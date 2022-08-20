using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[RequireComponent(typeof(CharacterController))]
[RequireComponent(typeof(Animator))]
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

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("DeathTriger"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        if (other.CompareTag("WallTriger"))
        {
            WallController.SetActiveAnimWall(true);
        }

    }

    private void MovePlayer()
    {

        movement = Vector3.zero;
        movement.x = Input.GetAxis(GlobalStringsVars.HORIZONTAL_AXIS) * speed;
        movement.z = Input.GetAxis(GlobalStringsVars.VERTICAL_AXIS) * speed;

        //анимации
        AnimGo();

        movement.y = gravityForce;
        characterController.Move(movement * Time.deltaTime);

    }

    //Метод гравитации
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

    //Метод проигрывания анимации
    private void AnimGo()
    {
        if (Input.GetKey(KeyCode.W))
        {
            animator.SetBool("FrontMovGo", true);
            animator.SetBool("BackMoveGo", false);
            animator.SetBool("RightMovGo", false);
            animator.SetBool("LeftMovGo", false);

        }
        else if (Input.GetKey(KeyCode.S))
        {
            animator.SetBool("BackMoveGo", true);
            animator.SetBool("FrontMovGo", false);
            animator.SetBool("RightMovGo", false);
            animator.SetBool("LeftMovGo", false);

        }
        else if (Input.GetKey(KeyCode.D))
        {
            animator.SetBool("RightMovGo", true);
            animator.SetBool("FrontMovGo", false);
            animator.SetBool("BackMoveGo", false);
            animator.SetBool("LeftMovGo", false);

        }
        else if (Input.GetKey(KeyCode.A))
        {
            animator.SetBool("LeftMovGo", true);
            animator.SetBool("FrontMovGo", false);
            animator.SetBool("BackMoveGo", false);
            animator.SetBool("RightMovGo", false);

        }
        else
        {
            animator.SetBool("FrontMovGo", false);
            animator.SetBool("BackMoveGo", false);
            animator.SetBool("RightMovGo", false);
            animator.SetBool("LeftMovGo", false);

        }
    }


}
