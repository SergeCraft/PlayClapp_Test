using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISpawnerController
{
    void SetMoveDistance(string value);
    void SetMoveSpeed(string value);
    void SetSpawnDelay(string value);

}
