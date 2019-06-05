using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleCollapse : MonoBehaviour
{
    public GameObject CollapseResult;

    void Start()
    {
        Collapse();
    }

    public void Collapse()
    {
        Instantiate(CollapseResult, transform.position, transform.rotation);
        Destroy(this.gameObject);
    }
}
