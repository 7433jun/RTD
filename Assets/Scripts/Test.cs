using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField] GameObject mapAnchor;


    void Start()
    {

        CreateMap();
    }

    public void CreateMap()
    {
        int[,] mapNode = new int[10, 5];

        //��� ����Ʈ ����
        List<Vector2>[] Node = new List<Vector2>[5];

        //��� ����Ʈ �Ҵ�
        for ( int i = 0;i< 5; i++)
        {
            Node[i] = new List<Vector2>();
        }

        //��� ����
        for(int i = 0; i < 5; i++)
        {
            Vector2 tempV = default;

            for (int j = 1; j <= 10; j++)
            {
                if (j == 1)
                {
                    tempV = new Vector2(1, Random.Range(0, 5));
                }
                else
                {
                    int y = (int)tempV.y + Random.Range(-1, 2);

                    if (y > 4) y = 4;
                    if (y < 0) y = 0;

                    tempV = new Vector2(j, y);
                }

                Node[i].Add(tempV);
            }
        }

        List<Line> MyPath = new List<Line>();

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                Line tempL = new Line(Node[i][j], Node[i][j + 1]);

                if(!MyPath.Contains(tempL))
                {
                    MyPath.Add(tempL);
                }
            }
        }

        foreach(var e in MyPath)
        {
            DrawLine(e);
        }

        //for(int i = 0; i < 5; i++)
        //{
        //    Debug.Log($"{i}��°");
        //    foreach(var e in path[i])
        //    {
        //        Debug.Log(e);
        //    }
        //}
    }

    public void DrawLine(Line line)
    {
        // ���ο� ���� ������Ʈ ����
        GameObject lineObject = new GameObject("Line");

        lineObject.transform.SetParent(mapAnchor.transform);

        // LineRenderer ������Ʈ �߰�
        LineRenderer lineRenderer = lineObject.AddComponent<LineRenderer>();

        // ���� �Ӽ� ����
        lineRenderer.startColor = Color.black;
        lineRenderer.endColor = Color.black;
        lineRenderer.startWidth = 0.1f;
        lineRenderer.endWidth = 0.1f;

        // �������� ���� ����
        lineRenderer.positionCount = 2;
        lineRenderer.SetPosition(0, new Vector3(line.start.x, line.start.y, 0f));
        lineRenderer.SetPosition(1, new Vector3(line.end.x, line.end.y, 0f));
    }
}

public class Line
{
    public Vector2 start;
    public Vector2 end;

    public Line(Vector2 v1, Vector2 v2)
    {
        start = v1;
        end = v2;
    }
}

