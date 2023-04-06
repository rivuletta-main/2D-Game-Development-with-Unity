using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuYönetici : MonoBehaviour
{
    private void Update() {
       if(Input.GetMouseButton(0))
       {
           MainMenuGecis.sahnedegisiyor = true;
       } 
    }
    
}
