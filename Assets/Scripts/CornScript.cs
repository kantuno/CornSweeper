using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CornScript : MonoBehaviour
{
    public bool isDead;
    public Material livingMaterial;
    public Material deadMaterial;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void Water()
    {
        if (isDead)
        {
            isDead = false;
            GetComponent<Renderer>().material = livingMaterial;
        }
    }
}
