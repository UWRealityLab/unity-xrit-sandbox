using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Helper component to delay colliders on grabbed objects when thrown to prevent bad collisions
public class ColliderDelay : MonoBehaviour
{
    public float delayTime;
    public Collider col;

    public void disableCollider()
    {
        col.enabled = false;
    }

    public void enableCollider()
    {
        StartCoroutine(delayedEnable());
    }

    private IEnumerator delayedEnable()
    {
        yield return new WaitForSeconds(delayTime);
        col.enabled = true;
    }
}

