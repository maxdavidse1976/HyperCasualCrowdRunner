using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChunkManager : MonoBehaviour
{
    [Header("Elements")] 
    [SerializeField] Chunk[] _chunksPrefabs;
    
    // Start is called before the first frame update
    void Start()
    {
        Vector3 chunkPosition = new Vector3(0, -4.1f, 0);
        for (int i = 0; i < 5; i++)
        {
            Chunk chunkToCreate = _chunksPrefabs[Random.Range(0, _chunksPrefabs.Length)];
            if (i > 0) chunkPosition.z += chunkToCreate.GetLength() / 2;
            Chunk chunkInstance = Instantiate(chunkToCreate, chunkPosition, Quaternion.identity, transform);
            chunkPosition.z += chunkInstance.GetLength() / 2;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
