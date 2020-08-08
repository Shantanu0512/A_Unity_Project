using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flagpole : MonoBehaviour
{
    private void OnTriggerEnter()
    {
        Gamemaager.instance.Win();
    }
}
