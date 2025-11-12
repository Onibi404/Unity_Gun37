using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstakleMove : MonoBehaviour
{
    [SerializeField] private Transform _point1;
    [SerializeField] private Transform _point2;
    [SerializeField] private Vector3 _dir;
    [SerializeField] private float _speed;

    void Start()
    {
        _dir = Vector3.back;
    }
    void Update()
    {
        if (_point2.position.z > transform.position.z)
        {
            _dir = Vector3.forward;
        }
        if (_point1.position.z < transform.position.z)
        {
            _dir = Vector3.back;
        }
        transform.Translate(_dir * Time.deltaTime * _speed);
    
    }
}
