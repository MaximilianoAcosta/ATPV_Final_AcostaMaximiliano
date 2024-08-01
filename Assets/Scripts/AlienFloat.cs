using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienFloat : MonoBehaviour
{
    [SerializeField] float amp;
    [SerializeField] float speed;
    Vector3 initPos;
    private void Start()
    {
        initPos = transform.position;
    }
    void Update()
    {
        transform.position = new Vector3(initPos.x, Mathf.Sin(Time.time* speed) * amp+ initPos.y, initPos.z);
    }
}
