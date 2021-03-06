using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script1 : MonoBehaviour
{
    public float omega;
    public float amp;
    public float alpha;
    public float k = 0.4f;
    public float speed = 0f;
    public float mass = 0f;
    public float stPlace = 0f;
    // Start is called before the first frame update
    void Start()
    {
        omega = Mathf.Sqrt(mass / k);
        if (speed > 0)
            alpha = Mathf.Atan(stPlace * k / speed);
        else
            alpha = stPlace;
        amp = Mathf.Sqrt(stPlace * stPlace + (speed * speed / k * k));
        transform.position = new Vector3(Mathf.Sin(alpha) * amp, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Convert.ToSingle(Math.Sin(Time.time * omega + alpha)) * amp, 0, 0);

    }
}
