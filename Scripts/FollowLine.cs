using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowLine : MonoBehaviour
{
    private Canvas can;
    private DrawLine dl;
    private float speed = 1;
    int index = 0;
    public GameObject go;

    // Use this for initialization
    void Awake()
    {
        can = GetComponent<Canvas>();
        dl = GetComponent<DrawLine>();
    }
    // Update is called once per frame
    void Update()
    {
            go.transform.position = Vector3.MoveTowards(transform.position, dl.points[index], speed * Time.deltaTime);
            if (go.transform.position == dl.points[index])
            {
                index++;
            }
    }
}
