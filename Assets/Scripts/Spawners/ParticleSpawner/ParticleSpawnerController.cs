
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSpawnerController : MonoBehaviour, ISpawnerController
{
    public void SetMoveDistance(string value)
    {
       transform.GetComponentInChildren<BoxCollider>()
            .transform.gameObject.transform.position = new Vector3 (0, float.Parse(value.Replace('.', ',')), 0);
    }

    public void SetMoveSpeed(string value)
    {
        GetComponent<ParticleSystem>().startSpeed = float.Parse(value.Replace('.', ','));
    }

    public void SetSpawnDelay(string value)
    {
        GetComponent<ParticleSystem>().emissionRate = 1 / float.Parse(value.Replace('.', ',')); 

    }
}
