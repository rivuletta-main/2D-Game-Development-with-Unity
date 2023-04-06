using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flash : MonoBehaviour
{
    Animator anim;

    public bool elliflash, yüzflash, yüzelliflash, ikiyüzflash, ikiyüzelliflash, üçyüzflash, üçyüzelliflash, dörtyüzflash;

    private void Start() {
        anim = GetComponent<Animator>();
    }
    private void Update() {
        
        if(Yönetici.skorint >= 50 && elliflash == false)
        {
            anim.SetTrigger("Flash");
            elliflash = true;
        }

        if(Yönetici.skorint >= 100 && yüzflash == false)
        {
            anim.SetTrigger("Flash");
            yüzflash = true;
        }

        if(Yönetici.skorint >= 150 && yüzelliflash == false)
        {
            anim.SetTrigger("Flash");
            yüzelliflash = true;
        }

        if(Yönetici.skorint >= 200 && ikiyüzflash == false)
        {
            anim.SetTrigger("Flash");
            ikiyüzflash = true;
        }

        if(Yönetici.skorint >= 250 && ikiyüzelliflash == false)
        {
            anim.SetTrigger("Flash");
            ikiyüzelliflash = true;
        }

        if(Yönetici.skorint >= 300 && üçyüzflash == false)
        {
            anim.SetTrigger("Flash");
            üçyüzflash = true;
        }

        if(Yönetici.skorint >= 350 && üçyüzelliflash == false)
        {
            anim.SetTrigger("Flash");
            üçyüzelliflash = true;
        }

        if(Yönetici.skorint >= 400 && dörtyüzflash == false)
        {
            anim.SetTrigger("Flash");
            dörtyüzflash = true;
        }
    }
}
