using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    [SerializeField] float DestroyTime = 0.2f;
    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, DestroyTime);
    }
}
