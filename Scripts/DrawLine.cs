using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DrawLine : MonoBehaviour
{
    private LineRenderer lr = null;
    public List<Vector3> points = null;

    // Start is called before the first frame update
    void Start()
    {
        lr = gameObject.AddComponent<LineRenderer>();
        lr.positionCount = 0;
        lr.startColor = Color.white;
        lr.endColor = Color.black;
        lr.startWidth = 0.1f;
        lr.useWorldSpace = true;
       

        points = new List<Vector3>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            if (lr != null)
                lr.positionCount = 0;
            if (points != null)
                points.Clear();
        }

        if (Input.GetMouseButton(1))
        {
            Vector3 worldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            worldPos.z = 0f;

            if(points.Contains(worldPos) ==  false)
            {
                points.Add(worldPos);
                lr.positionCount = points.Count;
                lr.SetPosition(lr.positionCount - 1, worldPos);
            }
        }

    }
   
}
