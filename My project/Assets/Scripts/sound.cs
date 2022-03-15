using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound : MonoBehaviour
{
    public static sound instance;//dp: singleton

    private void Awake(){
        instance = this;
    }

    public void playSound(string clipName, float Volume){
        AudioSource audioSource = this.gameObject.AddComponent<AudioSource>();
        audioSource.volume *= Volume;
        audioSource.PlayOneShot((AudioClip)Resources.Load("Sounds/" + clipName, typeof(AudioClip)));//chay am thanh, do dat ten file giong v ham nen rut gon con Sounds.
    }
}
