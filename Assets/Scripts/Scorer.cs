using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    private int hits = 0;

    private void OnCollisionEnter(Collision other)
    {
        hits++;

        Debug.Log("You've bumped into the walls " + hits + " times.");

    }
}
