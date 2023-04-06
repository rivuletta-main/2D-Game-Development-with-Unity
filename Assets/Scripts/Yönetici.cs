using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Yönetici : MonoBehaviour
{
    public GameObject hero;

    bool heroaktif;

    public Text skortext;

    public Text startogame;
    public static int skorint;

    public float relveloyönetici;
    
    public float oyunhızı = 1f;
    public float oyunhızıartıs = 0.5f;

    public bool oyundurdu;

    public Button durdurmabutonu;

    public GameObject paused;

    private void Start() {
        paused.SetActive(false);
        durdurmabutonu.interactable = false;
        oyundurdu = false;
        oyunhızı = 1f;
        skorint = 0;
        heroaktif = false;
        startogame.text = "LEFT CLİCK TO START TO GAME";
    }

    private void Update() {

        skortext.text = skorint.ToString();
        relveloyönetici = Hero.relvelo;

        if(Hero.relvelo <= -30 && heroaktif == true)
        {
            Time.timeScale = 1f;
            paused.SetActive(false);
            GameGecis.öldümü = true;
        }

        if(Input.GetMouseButton(0))
        {
            durdurmabutonu.interactable = true;
            hero.SetActive(true);
            startogame.text = " ";
            StartCoroutine(heroyuaktifet());
        }

        if(skorint > 0 && skorint <= 50 && oyundurdu == false)
        {
            Time.timeScale = 1f;
        }

        if(skorint > 50 && skorint <= 75 && oyundurdu == false)
        {
            Time.timeScale = 1.05f;
        }

        if(skorint > 75 && skorint <= 100 && oyundurdu == false)
        {
            Time.timeScale = 1.1f;
        }

        if(skorint > 100 && skorint <= 150 && oyundurdu == false)
        {
            Time.timeScale = 1.15f;
        }

        if(skorint > 150 && skorint <= 200 && oyundurdu == false)
        {
            Time.timeScale = 1.2f;
        }

        if(skorint > 200 && skorint <= 250 && oyundurdu == false)
        {
            Time.timeScale = 1.25f;
        }

        if(skorint > 250 && skorint <= 300 && oyundurdu == false)
        {
            Time.timeScale = 1.3f;
        }

        if(skorint > 300 && skorint <= 350 && oyundurdu == false)
        {
            Time.timeScale = 1.4f;
        }

        if(skorint > 350 && skorint <= 400 && oyundurdu == false)
        {
            Time.timeScale = 1.5f;
        }

        if(skorint > 400 && oyundurdu == false)
        {
            Time.timeScale = 1.6f;
        }

        
    }

    public void durdur()
    {
            if(oyundurdu == false)
            {
                oyundurdu = true;
                paused.SetActive(true);
                Time.timeScale = 0f;
            }
            else
            {
                oyundurdu = false;
                paused.SetActive(false);
                Time.timeScale = 1f;
            }
    }

    public void returntomenu()
    {
        Time.timeScale = 1f;
        GameGecis.menuyedon = true;
    }

    IEnumerator heroyuaktifet()
    {
        yield return new WaitForSecondsRealtime(1);
        heroaktif = true;
    }

    
}
