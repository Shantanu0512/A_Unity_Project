
using UnityEngine;

public class Reset : MonoBehaviour
{
    // Start is called before the first frame update
    public NewBehaviourScript player;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("r"))
        {
            Debug.Log("Good to go!!");
            player.enabled = true;
            
        }
    }
}
