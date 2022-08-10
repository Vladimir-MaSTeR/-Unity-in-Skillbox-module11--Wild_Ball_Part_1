using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallController : MonoBehaviour
{
    private Animator anim;
    private static bool activeAnimWall = false;

    void Start()
    {
        anim = GetComponent<Animator>();
        activeAnimWall = false;
    }

    private void Update()
    {
        if (activeAnimWall)
        {
            anim.SetBool("Activ", true);
        } else
        {
            anim.SetBool("Activ", false);
        }
    }


    public static void SetActiveAnimWall(bool bl)
    {
        activeAnimWall = bl;
    }



}
