using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxSpawner : MonoBehaviour
{
    //Spawn Boxes to spawn multiple boxes.
    public GameObject box_Prefab;

    public void Start(){
     
    }
    public void SpawnBox(){
        GameObject box_Obj = Instantiate(box_Prefab);
        Vector3  temp = transform.position;
        temp.z = 0f;
        box_Obj.transform.position = temp;
    }

    
    
    
    
}
