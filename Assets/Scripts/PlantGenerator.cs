using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantGenerator : MonoBehaviour
{
    public GameObject plant;
    public int density;
    void Start()
    {
        Vector3 center = transform.position;
        int xSize = (int)GetComponent<MeshCollider>().bounds.size.x;
        int zSize = (int)GetComponent<MeshCollider>().bounds.size.z;
        for (int x = (int)center.x - (xSize/2); x < (int)center.x + (xSize / 2); x += density)
        {
            for(int z = (int)center.z - (zSize / 2); z < (int)center.z + (zSize / 2); z += density)
            {
                GameObject newPlant = Instantiate(plant, new Vector3((float)x, center.y, (float)z), Quaternion.identity);
                newPlant.transform.parent = gameObject.transform;
            }
        }
    }
}
