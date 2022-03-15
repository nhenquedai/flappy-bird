using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BornPipe : MonoBehaviour
{
    public GameObject Prefabs;    
    private float countdown;
    public float timeDuration;
    public bool enableBornPipe;

    private void Awake(){
        countdown = timeDuration;
        enableBornPipe = false;
    }

    void Update()
    {
        if(enableBornPipe == true){

        
        countdown -= Time.deltaTime;
        //giam theo tg =1/fps
        if(countdown <= 0){
            Instantiate(Prefabs, new Vector3(10, Random.Range(3.1f, 8.1f), 0), Quaternion.identity);
            //sinh ra cai gi, sinh ra o dau(10, ngau nhien trong khoang, truc Z = 0), ham khong xoay.
            countdown = timeDuration;
        }
        }
    }
}
