using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlapAnimController : MonoBehaviour
{

    private Animator anim;
    private int randomAnim = 0;

    void Start()
    {
        anim = GetComponent<Animator>();
    }



    private void ChangeAnim()
    {
        anim.SetInteger("Anim", randomAnim);
    }


    public void CheckedEndAnimation()
    {
        randomAnim = Random.Range(0, 3);
        ChangeAnim();
    }
}
