using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gölge : MonoBehaviour
{
    public float gölgehızı;
    private void Update() {
        transform.Translate(new Vector2(0f,1f)*gölgehızı*Time.deltaTime);

        
    }
}
