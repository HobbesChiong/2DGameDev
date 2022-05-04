using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collidable : MonoBehaviour
{
    public ContactFilter2D filter;
    private BoxCollider2D boxCollider;
    private Collider2D[] hits = new Collider2D[10]; // Data of what exactly you hit during that frame (10 for now)

    protected virtual void Start() 
    {
        boxCollider = GetComponent<BoxCollider2D>();
    }

    protected virtual void Update() 
    {
        // Collision
        boxCollider.OverlapCollider(filter, hits);

        // Iterate through all the objects you hit
        for (int i = 0; i < hits.Length; i++) {
            if (hits[i] == null) continue;

            // Action on collision
            OnCollide(hits[i]);

            // Clean up array
            hits[i] = null;
        }
    }

    // Virtual method for actions on collision
    protected virtual void OnCollide(Collider2D coll)
    {
        // Print what's been collided onto Log (Default)
        Debug.Log(coll.name);
    }
}
