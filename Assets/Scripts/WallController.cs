using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallController : MonoBehaviour
{

    [SerializeField] private Canvas canvas1;
    [SerializeField] private Canvas canvas2;
    [SerializeField] private GameObject pushPlane;


    private Animator anim;
    private static bool activeAnimWall = false;

    void Start()
    {
        anim = GetComponent<Animator>();
        activeAnimWall = false;

        pushPlane.SetActive(false);
        canvas1.gameObject.SetActive(true);
        canvas2.gameObject.SetActive(false);
    }

    private void Update()
    {
        if (activeAnimWall)
        {
            anim.SetBool("Activ", true);
            pushPlane.SetActive(true);
            canvas1.gameObject.SetActive(false);
            canvas2.gameObject.SetActive(true);
        } else
        {
            anim.SetBool("Activ", false);

            pushPlane.SetActive(false);
            canvas1.gameObject.SetActive(true);
            canvas2.gameObject.SetActive(false);
        }
    }


    public static void SetActiveAnimWall(bool bl)
    {
        activeAnimWall = bl;
    }



}
