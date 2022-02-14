using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    [SerializeField] private float _grouping;
    [SerializeField] private GameObject _Obstacle;
    [SerializeField] private Transform _Gates;
    IEnumerator Spawn()
    {
        Vector3 _birthplace = _Gates.position + new Vector3(Random.Range(-5.5f, 5.5f), 0, 0);
        Instantiate(_Obstacle, _birthplace, Quaternion.identity);
        yield return new WaitForSeconds(_grouping);
        Spawning();
    }
       
    void Start()
    {
        StartCoroutine(Spawn());
    }

    void Spawning()
    {
        StartCoroutine(Spawn());
    }
}
