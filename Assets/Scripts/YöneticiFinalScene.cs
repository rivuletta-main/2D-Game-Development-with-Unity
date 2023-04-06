using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class YöneticiFinalScene : MonoBehaviour
{
    public Text skor;
    public Text highskor;

    public int bestskor;

    private void Start() {
    }
    private void Update() {

        skor.text = Yönetici.skorint.ToString();
        highskor.text = PlayerPrefs.GetInt("bestskor").ToString();

        if(Yönetici.skorint > PlayerPrefs.GetInt("bestskor"))
        {
            PlayerPrefs.SetInt("bestskor",Yönetici.skorint);
        }
    }

    public void oyunkapat()
    {
        FinalGecis.oyunkapatıldı = true;
    }
}
