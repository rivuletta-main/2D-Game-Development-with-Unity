using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    public float yatayhareket;
    public float harekethızı;

    public static float relvelo;

    public Rigidbody2D rb;
    
    private void Start() {
        rb = GetComponent<Rigidbody2D>();
        
    }
    
    private void Update() {
        yatayhareket = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(yatayhareket*harekethızı*100*Time.deltaTime,rb.velocity.y);

        Vector2 YeniScale = transform.localScale;

        if(yatayhareket > 0)
        {
            YeniScale.x = 0.35f;
        }

        if(yatayhareket < 0)
        {
            YeniScale.x = -0.35f;
        }

        transform.localScale = YeniScale;

        relvelo = rb.velocity.y;
    }
}
