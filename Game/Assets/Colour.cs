using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colour : MonoBehaviour
{
    public Material[] material;
    public  int y;
    public Renderer rend1;
    // Start is called before the first frame update
    void Start()
    {
        rend1 = GetComponent<Renderer>();
        rend1.enabled = true;
        rend1.sharedMaterial = material[Assign_colour.x];

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
