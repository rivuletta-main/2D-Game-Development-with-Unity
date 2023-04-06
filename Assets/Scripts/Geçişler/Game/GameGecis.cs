using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameGecis : MonoBehaviour
{
    Animator anim;

    public static bool öldümü = false;
    public static bool menuyedon = false;
    private void Start() {

        öldümü = false;
        menuyedon = false;
        anim = GetComponent<Animator>();
        anim.SetTrigger("Giriş");
    }

    private void Update() {
        if(öldümü == true)
        {
            StartCoroutine(öldü());
        }

        if(menuyedon == true)
        {
            StartCoroutine(menuyedondu());
        }
    }

    IEnumerator öldü()
    {
        anim.SetTrigger("Çıkış");
        yield return new WaitForSecondsRealtime(1f);
        SceneManager.LoadScene(2);

    }

    IEnumerator menuyedondu()
    {
        anim.SetTrigger("Çıkış");
        yield return new WaitForSecondsRealtime(1f);
        SceneManager.LoadScene(0);
    }
}
