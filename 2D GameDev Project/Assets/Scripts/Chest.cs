using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Chest inherits from Collectable, which also inherits from Collidable
// If sprite is given the chest script, it inherits code from Collectable and Collidable
public class Chest : Collectable 
{
    public Sprite emptyChest;
    public int pesoAmount = 5;

    protected override void OnCollect()
    {
        if (!collected)
        {
            collected = true;
            GetComponent<SpriteRenderer>().sprite = emptyChest;
            Debug.Log("Grant" + pesoAmount + "pesos!");

        }
    }

}