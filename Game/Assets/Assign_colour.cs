using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assign_colour : MonoBehaviour
{
    public Material[] material;
    public static int x;
    public Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        x = 0;
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[x];
    }

    // Update is called once per frame
    void Update()
    {
        rend.sharedMaterial = material[x];
    }
    public void Colornext()
    {
        if (x < 2)
            x++;
        else
            x = 0;
    }
}
