using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{

    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("Ya hit me ya wanker!");
        GetComponent<MeshRenderer>().material.color = Color.cyan;
    }
}
