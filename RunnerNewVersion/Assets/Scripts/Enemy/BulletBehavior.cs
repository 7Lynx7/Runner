using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour {

    public bool IsFirst, IsMove;
    public GameObject Stolb;

    private void Start()
    {
        if (gameObject.name != "Bullet")
        IsFirst = false;
    }

    void Update () {
        if (IsFirst == false && IsMove)
        transform.Translate(Vector3.up * 4 * Time.deltaTime);
    }
    public int time;
    public int TimeToDestroy;
    private void FixedUpdate()
    {
        if (IsFirst == false && IsMove)
        {
            time++;
            if (time >= TimeToDestroy)
            {
                Destroy(gameObject);
            }
        }
      
    }
 
}
