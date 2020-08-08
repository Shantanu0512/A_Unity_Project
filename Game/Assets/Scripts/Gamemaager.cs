using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemaager : MonoBehaviour
{
   public static Gamemaager instance= null;
    public float Resetdelay;
    public GameObject TaskCompletedtext;
    public GameObject movementtext;
     void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != null)
            Destroy(gameObject);
    }
    public void Win()
    {
        TaskCompletedtext.SetActive(true);
        movementtext.SetActive(false);
        Time.timeScale = 0.5f;
        Invoke("Reset", Resetdelay);
    }
    void Reset() {
        Time.timeScale = 1f;
        Application.LoadLevel(Application.loadedLevel);    
    }
    
    
}
