using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpriteRenderer : MonoBehaviour
{
    private int SortOrder = 0;
    private Renderer rr;
    public float PosSet = 0;



    void Start()
    {
        rr = GetComponent<Renderer>();
    }


    void LateUpdate()
    {
        rr.sortingOrder = (int)(SortOrder - transform.position.y + PosSet);
    }
}
