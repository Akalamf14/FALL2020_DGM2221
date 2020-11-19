using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransparentBehaviour : MonoBehaviour
{
    public Material newMaterial;
    public Material defaultMaterial;
    private MeshRenderer meshR;
    
    void Start()
    {
        meshR = GetComponent<MeshRenderer>();
        meshR.material = defaultMaterial;
        
    }
    
    private void OnTriggerEnter(Collider other)
    {
        meshR.material = newMaterial;
    
    }
    
    private void OnTriggerExit(Collider other)
    {
        meshR.material = defaultMaterial;
    }

}