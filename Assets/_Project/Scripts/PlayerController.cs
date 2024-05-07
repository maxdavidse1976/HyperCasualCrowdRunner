using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Elements")] 
    [SerializeField] CrowdSystem _crowdSystem;
    
    [Header("Settings")] 
    [SerializeField] float _moveSpeed;
    [SerializeField] float _roadWidth;

    [Header("Control")] 
    [SerializeField] float _slideSpeed;

    Vector3 _clickedScreenPosition;
    Vector3 _clickedPlayerPosition;

    void Update()
    {
        MoveForward();
        ManageControl();
    }

    void ManageControl()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _clickedScreenPosition = Input.mousePosition;
            _clickedPlayerPosition = transform.position;
        }
        else if (Input.GetMouseButton(0))
        {
            float xScreenDifference = Input.mousePosition.x - _clickedScreenPosition.x;
            xScreenDifference = xScreenDifference / Screen.width;
            xScreenDifference = xScreenDifference * _slideSpeed;

            Vector3 position = transform.position;
            position.x = _clickedPlayerPosition.x + xScreenDifference;
            position.x = Mathf.Clamp(position.x, -_roadWidth / 2 + _crowdSystem.GetCrowdRadius(), _roadWidth / 2 - _crowdSystem.GetCrowdRadius());
            transform.position = position;
        }
    }

    void MoveForward()
    {
        transform.position += Vector3.forward * _moveSpeed * Time.deltaTime;
    }
}
