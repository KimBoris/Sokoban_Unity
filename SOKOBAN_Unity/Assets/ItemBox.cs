using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour
{
    public bool isOveraped = false; //Itembox�� EndPoint �پ��ִٸ� true

    private Renderer itemBoxRen; //�� ItemBox�� �پ��ִ� Renderer ������Ʈ�� ������ ����

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

    private void OnTriggerEnter(Collider other) //Trigger�� ���� ������Ʈ (other)�� �浹�� 
    {
        if (other.tag == "EndPoint") //�浹�� �� ������Ʈ�� �±װ� "EndPoint" �Ͻ� 
        {
            isOveraped = true;
            itemBoxRen.material.color = touchColor; //ItemBox�� ������ Red�� �ٲ��ش�. 
            Debug.Log("���� ����Ʈ�� ����!");
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
