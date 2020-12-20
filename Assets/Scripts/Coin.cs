using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : Collectable 
{ 
    private void Start() 
    { 
        collectableName = "Coin"; 
        description = "Increase Score By 10"; 
    } 
    
    override public void Use() 
    { 
        player.GetComponent<playerManager>().ChangeScore(10); 
        Destroy(this.gameObject); // Cleans Up No Longer Useful Object 
    } 
}
