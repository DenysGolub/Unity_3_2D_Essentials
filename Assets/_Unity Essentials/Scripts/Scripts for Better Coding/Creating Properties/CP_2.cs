using UnityEngine;
using System.Collections;

public class Game : MonoBehaviour
{
    void Start()
    {
        Player_cp myPlayer = new Player_cp();

        //Properties can be used just like variables
        myPlayer.Experience = 5;
        int x = myPlayer.Experience;
    }
}