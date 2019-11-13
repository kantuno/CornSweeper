using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MountainGenerator : MonoBehaviour
{
    public int layers;
    public GameObject mountainBlock;

    void Start()
    {
        GameObject currentLayer = GenerateLayer((int)transform.position.y, transform.position, (int)GetComponent<MeshCollider>().bounds.size.x, (int)GetComponent<MeshCollider>().bounds.size.z, (int)Random.Range(10,20));

        for (int i = 1; i < layers; i++)
        {
            int height = (int)Random.Range((currentLayer.transform.localScale.y - currentLayer.transform.localScale.y / 2), (currentLayer.transform.localScale.y - currentLayer.transform.localScale.y / 4));
            int sizeX = (int)Random.Range((currentLayer.transform.localScale.x - currentLayer.transform.localScale.x / 4), (currentLayer.transform.localScale.x - currentLayer.transform.localScale.x / 8));
            int sizeZ = (int)Random.Range((currentLayer.transform.localScale.z - currentLayer.transform.localScale.z / 4), (currentLayer.transform.localScale.z - currentLayer.transform.localScale.z / 8));

            currentLayer = GenerateLayer((int)(currentLayer.transform.position.y + (currentLayer.transform.localScale.y / 2)), currentLayer.transform.position, sizeX, sizeZ, height);
        }
    }

    GameObject GenerateLayer(int y, Vector3 center, int sizeX, int sizeZ, int height)
    {
        GameObject layer = Instantiate(mountainBlock, new Vector3(center.x, center.y + (height/2), center.z), Quaternion.identity);
        layer.transform.localScale = new Vector3((float)sizeX, (float)height, (float)sizeZ);
        layer.transform.parent = gameObject.transform;
        return layer;
    }
}
