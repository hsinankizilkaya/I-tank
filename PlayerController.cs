using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float torqueAmount = 5f;
    Rigidbody2D cntrl;
    
    void Start()
    {
        cntrl = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            cntrl.AddTorque(torqueAmount);
        }
        else if(Input.GetKey(KeyCode.RightArrow))
        {
            cntrl.AddTorque(-torqueAmount);
        }
    }
}
