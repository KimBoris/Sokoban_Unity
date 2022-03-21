using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour
{
    public bool isOveraped = false; //Itembox가 EndPoint 붙어있다면 true

    private Renderer itemBoxRen; //이 ItemBox에 붙어있는 Renderer 컴포넌트를 참조할 변수

    private Color originColor;
    public Color touchColor;


    void Start()
    {
        itemBoxRen = GetComponent<Renderer>();
        originColor = itemBoxRen.material.color;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other) //Trigger를 가진 오브젝트 (other)와 충돌시 
    {
        if (other.tag == "EndPoint") //충돌한 그 오브젝트의 태그가 "EndPoint" 일시 
        {
            isOveraped = true;
            itemBoxRen.material.color = touchColor; //ItemBox의 색깔을 Red로 바꿔준다. 
            Debug.Log("엔드 포인트에 도달!");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "EndPoint")
        {
            isOveraped = false;
            itemBoxRen.material.color = originColor;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "EndPoint")
        {
            isOveraped = true;
            itemBoxRen.material.color = touchColor;
                ;
        }
    }
}
