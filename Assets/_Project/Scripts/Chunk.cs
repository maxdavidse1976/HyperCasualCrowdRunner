using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Chunk : MonoBehaviour
{
    [Header("Settings")] 
    [SerializeField] Vector3 _size;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public float GetLength()
    {
        return _size.z;
    }
    public void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireCube(transform.position, _size);
    }
}
