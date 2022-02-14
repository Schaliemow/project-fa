using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motion : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private GameObject _Obstacle;
    void FixedUpdate()
    {
        _Obstacle.transform.Translate(0, _speed * Time.deltaTime, 0);
        if (_Obstacle.transform.position.y > 14.0f)
            Destroy(_Obstacle);
    }
}
