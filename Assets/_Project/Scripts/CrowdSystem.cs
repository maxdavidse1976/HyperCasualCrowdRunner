using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrowdSystem : MonoBehaviour
{
    [Header("Settings")] 
    [SerializeField] float _goldenAngle;
    [SerializeField] float _radius;

    [Header("Elements")] 
    [SerializeField] Transform _runnersParent;
    void Update()
    {
        PlaceRunners();
    }

    void PlaceRunners()
    {
        for (int i = 0; i < _runnersParent.childCount; i++)
        {
            Vector3 childLocalPosition = GetRunnerLocalPosition(i);
            _runnersParent.GetChild(i).localPosition = childLocalPosition;
        }

    }

    Vector3 GetRunnerLocalPosition(int runnerIndex)
    {
        float x = _radius * Mathf.Sqrt(runnerIndex) * Mathf.Cos(Mathf.Deg2Rad * runnerIndex * _goldenAngle);
        float z = _radius * Mathf.Sqrt(runnerIndex) * Mathf.Sin(Mathf.Deg2Rad * runnerIndex * _goldenAngle);

        return new Vector3(x, 0, z);
    }
}
