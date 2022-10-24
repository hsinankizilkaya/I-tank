using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GasBreak : MonoBehaviour
{
    [SerializeField] float neg = -1;
    [SerializeField] float i = +1;  
 
    void Start(){
        
    }

    void Update(){
        keysss();
    }

    void keysss(){
        if(Input.GetKey(KeyCode.DownArrow)){
            FindObjectOfType<SurfaceEffector2D>().speed = neg;
            if (neg>-9f){
            neg-=0.040f;
            }
            i = neg+1;
           
                
            

        }
        
        if(Input.GetKey(KeyCode.UpArrow)){
            
            FindObjectOfType<SurfaceEffector2D>().speed = i;
            if (i<9f){
            i+=0.035f; 
            }
                neg = i-1;            
            
        }
        
    }
}