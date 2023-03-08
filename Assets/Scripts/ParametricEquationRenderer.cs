using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParametricEquationRenderer : MonoBehaviour
{
    [SerializeField]
    //  This component handles a line rendering given
    //  a set of positions (3D points).
    private LineRenderer lineRenderer;

    [SerializeField]
    private float a;

    [SerializeField]
    private float b;

    [SerializeField]
    private float c;

    [SerializeField]
    private float d;

    [SerializeField]
    private float minParameter;

    [SerializeField]
    private float maxParameter;

    [SerializeField]
    private int step;

    private float x;
    private float y;

    void Start()
    {
        Vector3[] points = new Vector3[step];
        int j = 0;
        for (int i = 0; i < step; i++)
        {
            x = Mathf.Cos(2.0f*Mathf.PI*((a*(j+1.0f)+b)));
            y = Mathf.Sin(2.0f*Mathf.PI*((c*(j+1.0f)+d)));
            points[j] = new Vector3(x, y, 0);
            j++;
        }
        //  Before setting a line renderer positions, the position
        //  count must be set first.
        lineRenderer.positionCount = 21;

        //  This statement sets a line renderer positions.
        //  Old positions are overridden.
        lineRenderer.SetPositions(points);
    }
}