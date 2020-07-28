using UnityEngine;

public class Collosion : MonoBehaviour
{
    public NewBehaviourScript player;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obsticle")
        {
            Debug.Log("You are hit Press r to move again");
            player.enabled = false;
        }
       
    }
}
