using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zemin : MonoBehaviour
{
    float zıplamakuvveti;
    public bool karakterteması;
    public bool puanalındı;

    Animator anim;

    public int boosterşansı;

    private void Start() {
        anim = GetComponent<Animator>();
        boosterşansı = Random.Range(1,11);
        
        if(boosterşansı == 1)
        {
            anim.SetBool("Booster",true);
            zıplamakuvveti = 20f;
        }
        else
        {
            zıplamakuvveti = 13.5f;
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        
        if(collision.relativeVelocity.y < 0 && collision.gameObject.tag == "hero")
        {
        Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();

        if(rb != null)
        {
            Vector2 ZıplamaVelocity = rb.velocity;
            ZıplamaVelocity.y = zıplamakuvveti;
            rb.velocity = ZıplamaVelocity;
        }

        if(collision.gameObject.tag == "hero")
        {
            karakterteması = true;

            if(puanalındı == false)
            {
                if(boosterşansı == 1)
                {
                    Yönetici.skorint+=5;
                    puanalındı = true;
                }
                else
                {
                    Yönetici.skorint++;
                    puanalındı = true;
                }
            
            }   
        }
        }
    }

    private void Update() {
        if(karakterteması == true)
        {
            anim.SetBool("TemasEdildi",true);
            Destroy(gameObject,1.3f);
        }
        
    }
    
    

    
}
