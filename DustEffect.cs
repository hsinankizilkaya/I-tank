using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustEffect : MonoBehaviour

{   

    [SerializeField] ParticleSystem DustParticles;

    void Update() {
        duzts();
    }

    void duzts()
    {
        if(Input.GetKey(KeyCode.UpArrow)){
        DustParticles.Play();
        
        }
    }
}