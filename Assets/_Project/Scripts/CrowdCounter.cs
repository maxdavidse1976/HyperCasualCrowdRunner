using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CrowdCounter : MonoBehaviour
{
    [Header("Elements")] 
    [SerializeField] TextMeshPro _crowdCounterText;
    [SerializeField] Transform _runnersParent;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _crowdCounterText.text = _runnersParent.childCount.ToString();
    }
}
