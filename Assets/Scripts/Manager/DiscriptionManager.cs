using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DiscriptionManager : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {

        // EventSystem의 모든 raycast를 받아서 첫번째 항목 출력 ui든 아니든 상관없음
        if (Input.GetMouseButtonDown(0))
        {
            PointerEventData eventDataCurrentPosition = new PointerEventData(EventSystem.current);

            eventDataCurrentPosition.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);

            List<RaycastResult> results = new List<RaycastResult>();

            EventSystem.current.RaycastAll(eventDataCurrentPosition, results);

            Debug.Log(results[0].gameObject.name);

        }
    }
}
