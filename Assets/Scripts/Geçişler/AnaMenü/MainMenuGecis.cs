using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuGecis : MonoBehaviour
{
    public static bool sahnedegisiyor;
    Animator anim;
    void Start()
    {
        sahnedegisiyor = false;
        anim = GetComponent<Animator>();
        anim.SetTrigger("Giriş");
    }

    private void Update() {
        
        if(sahnedegisiyor == true)
        {
            StartCoroutine(oyunagec());
        }
    }

    IEnumerator oyunagec()
    {
        anim.SetTrigger("Çıkış");
        yield return new WaitForSecondsRealtime(2f);
        SceneManager.LoadScene(1);

    }
    
}
