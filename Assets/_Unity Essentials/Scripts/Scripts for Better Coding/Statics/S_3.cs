using UnityEngine;
using System.Collections;

public class PlayerManager : MonoBehaviour
{
    void Start()
    {
        //You can access a static variable by using the class name
        //and the dot operator.
        int x = Player0.playerCount;
    }



}

public class Player0 : MonoBehaviour
{
    //Static variables are shared across all instances
    //of a class. 
    public static int playerCount = 0;

    void Start()
    {
        //Increment the static variable to know how many
        //objects of this class have been created.
        playerCount++;
    }
}
