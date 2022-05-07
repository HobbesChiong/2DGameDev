using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : Collidable
{
    // Logic
    protected bool collected;

    protected override void OnCollide(Collider2D coll)
    {
        if (coll.name == "Person_1") 
            OnCollect();

    }

    // This could be used in Chest by doing "base.Oncollect();" but I just used "collected = true" instead
    protected virtual void OnCollect()
    {
        collected = true;
    }
}
