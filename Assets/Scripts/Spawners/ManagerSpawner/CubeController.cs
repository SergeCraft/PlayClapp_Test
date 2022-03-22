using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{

    public IEnumerator actualMove;

    void Update()
    {
        transform.Rotate(Random.rotation.eulerAngles * Time.deltaTime * 0.15f);
    }

    public void MoveTo(Vector3 pos, float movespeed) 
    {
        actualMove = DoMove(pos, movespeed);
        StartCoroutine(actualMove);
    }

    private IEnumerator DoMove (Vector3 pos, float movespeed)
    {
        while (transform.position != pos)
        {
            transform.position = Vector3.MoveTowards(transform.position, pos, movespeed * Time.deltaTime);

            yield return new WaitForFixedUpdate();
        }

        Destroy(transform.gameObject);
    }
}
