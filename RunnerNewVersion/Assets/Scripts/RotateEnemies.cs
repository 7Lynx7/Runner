using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateEnemies : MonoBehaviour {

    public AnimationCurve SpeedRotate;
    public bool Rotate = false;
    public float time, TimeToRatate;
    public Transform Transform;

    private void Start()
    {
        Transform = gameObject.transform;
    }
    void FixedUpdate ()
    {
		if (Rotate)
        {
            time += Time.deltaTime;
            TimeToRatate += Time.deltaTime;
            if (TimeToRatate > 0.015)
            {
                TimeToRatate = 0f;
                Transform.Rotate(SpeedRotate.Evaluate(time), 0f, 0f);
            }
        }
	}
}