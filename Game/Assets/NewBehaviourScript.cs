using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Rigidbody Rb;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w")) {
            Rb.AddForce(0, 0, 20);
        }
        else if (Input.GetKey("s")) {
            Rb.AddForce(0, 0, -20);
        }
        else if (Input.GetKey("d")) { 
            Rb.AddForce(20, 0, 0); 
        }
        else if (Input.GetKey("a"))
        {
            Rb.AddForce(-20, 0, 0);
        }
        else if (Input.GetKey("e"))
        {
            Rb.AddForce(20, 0, 20);
        }
        else if (Input.GetKey("q"))
        {
            Rb.AddForce(-20, 0, 20);
        }
        else if (Input.GetKey("c"))
        {
            Rb.AddForce(20, 0, -20);
        }
        else if (Input.GetKey("z"))
        {
            Rb.AddForce(-20, 0, -20);
        }
        else if (Input.GetKey("j"))
        {
            for (int i = 0; i<= 20; i+=3) { 
                Rb.AddForce(0, i, 0); }
            
        }
        
    }


}
