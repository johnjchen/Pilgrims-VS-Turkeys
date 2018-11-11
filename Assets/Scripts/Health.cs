using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    // Current Health
    [SerializeField]
    int cur = 5;

    public void damage(int n)
    {
        cur -= n;

        if (cur <= 0)
            Object.Destroy(gameObject);
    }
}
