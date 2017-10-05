using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class __God_Object : MonoBehaviour {

    [SerializeField]
    private float animTime = 0.0f;

    private Animator Anim;

    private void Start()
    {
        Anim = this.GetComponent<Animator>();
    }

    private void OnDisable()
    {
        if (Anim)
            Anim.SetBool("Active", false);

        if(animTime > 0)
            Destroy(this.gameObject, animTime);
    }

    private void OnEnable()
    {
        if (Anim)
            Anim.SetBool("Active", true);
    }
}