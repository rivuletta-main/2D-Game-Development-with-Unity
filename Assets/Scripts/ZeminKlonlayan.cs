using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeminKlonlayan : MonoBehaviour
{
    public GameObject platform;

    public Transform tr;
    public int platformsayısı;

    public float konumgenişlik = 3f;
    public float minimumy = 2f;
    public float maksimumy = 3f;
    private void Start() {

        
        tr = platform.GetComponent<Transform>();
        Vector3 spawnkonumu = new Vector3();
        Vector2 YeniScale = new Vector2();
        
        for (int i = 0; i < platformsayısı; i++)
        {
            YeniScale.x = Random.Range(0.9f,1.1f);
            YeniScale.y = Random.Range(0.9f,1.2f);
            tr.localScale = YeniScale;
            spawnkonumu.y += Random.Range(minimumy,maksimumy);
            spawnkonumu.x = Random.Range(-konumgenişlik,konumgenişlik);
            Instantiate(platform,spawnkonumu,Quaternion.identity);
        }

    }
}
