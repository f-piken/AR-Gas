using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class splash : MonoBehaviour
{
    public float delay = 3.3f;

    void Start()
    {
        StartCoroutine(DestroyAfterDelay());
    }

    IEnumerator DestroyAfterDelay()
    {
        yield return new WaitForSeconds(delay);
        Destroy(gameObject);
    }
}
