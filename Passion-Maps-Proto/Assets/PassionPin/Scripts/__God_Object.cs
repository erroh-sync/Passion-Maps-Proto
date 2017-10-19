using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class __God_Object : MonoBehaviour {

    [SerializeField]
    private float animTime = 0.0f;

    [SerializeField]
    private Animator Anim;

    private void OnEnable()
    {
        Anim.SetBool("Active", true);
    }

    private void OnDisable()
    {
        if(animTime > 0)
            Destroy(this.gameObject, animTime);
        Anim.SetBool("Active", false);
    }
}