using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraScript : MonoBehaviour
{
    Animator anim;

    private void Start() {
        anim = GetComponent<Animator>();
    }

    private void Update() {
        if(Yönetici.skorint >= 50)
        {
            anim.SetBool("50",true);
        }
        if(Yönetici.skorint >= 200)
        {
            anim.SetBool("100",true);
        }
    }

}
