using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeManager : MonoBehaviour, ISpawnerController
{
    private float _moveDistance = 5.0f;
    private float _movespeed = 1.0f;
    private float _spawnDelay = 1.0f;
    private float _lastSpawnTime = 0.0f;

    [SerializeField]
    public GameObject particle;


    // Update is called once per frame
    void Update()
    {
        TrySpawn();
    }


    public void SetMoveDistance(string value)
    {
        _moveDistance = float.Parse(value.Replace('.', ','));
    }

    public void SetMoveSpeed(string value)
    {
        _movespeed = float.Parse(value.Replace('.', ','));
    }

    public void SetSpawnDelay(string value)
    {
        _spawnDelay = float.Parse(value.Replace('.', ','));
    }

    private void TrySpawn()
    {
        if (Time.time - _lastSpawnTime < _spawnDelay) return;
        if (particle == null)
        {
            Debug.LogError("Particle not defined!");
            return;
        };
        GameObject newParticle = GameObject.Instantiate(particle, transform.position, transform.rotation);
        newParticle.GetComponent<CubeController>().MoveTo(
            new Vector3(
                transform.position.x,
                _moveDistance,
               transform.position.z),
            _movespeed);
        _lastSpawnTime = Time.time;
    }
}
