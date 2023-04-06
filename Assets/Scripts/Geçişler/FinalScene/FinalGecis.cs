using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalGecis : MonoBehaviour
{
    Animator anim;

    public static bool oyunkapatıldı = false;

    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetTrigger("Giriş");
    }

    private void Update() {
        if(Input.GetMouseButton(0))
        {
            StartCoroutine(tekraroyna());
        }

        if(Input.GetMouseButton(1))
        {
            StartCoroutine(menüyedön());
        }

        if(oyunkapatıldı == true)
        {
            oyunukapat();
        }
    }

    IEnumerator tekraroyna()
    {
        anim.SetTrigger("Çıkış");
        yield return new WaitForSecondsRealtime(1f);
        SceneManager.LoadScene(1);

    }

    IEnumerator menüyedön()
    {
        anim.SetTrigger("Çıkış");
        yield return new WaitForSecondsRealtime(1f);
        SceneManager.LoadScene(0);
    } 

    public void oyunukapat()
    {
        Application.Quit();
    }   
}
