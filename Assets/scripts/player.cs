using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player : MonoBehaviour
{
    public Text textPlayer;
    public int levelPlayer;
   
    
    void Update()
    {
        textPlayer.text = levelPlayer.ToString();  
    }
}
