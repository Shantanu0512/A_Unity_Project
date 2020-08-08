
using UnityEngine;
using UnityEngine.UI;

public class Display_Message : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform pos_of_player;
    public Text Display_text;
    public NewBehaviourScript player;

    // Update is called once per frame
    void Update()
    {    
        if (player.enabled == true)
        {
            Display_text.text = "You are ready to move \n Press 'w' to move forward\n Press 'd' to move right\nPress 'a' to move left\nPress 's'to move  backward \n" +
                "Press 'e'to move top right \n Press 'q'to ove top left\n Press 'c'to move bottom right\n Press 'z'to move bottom left \nPress 'j' to jump\nReach to the flag" ;

        }
        else if (player.enabled == false)
        {
            Display_text.text = "You hit something \n Press 'r' to move again";
        }
        else {
            Display_text.text = pos_of_player.position.z.ToString("0");
        }
    }
}
