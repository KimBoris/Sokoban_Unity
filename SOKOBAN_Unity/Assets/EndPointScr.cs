using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndPointScr : MonoBehaviour
{

    void Start()
    {

    }

    void Update()
    {
        transform.Rotate(60 * Time.deltaTime, 60 * Time.deltaTime, 60 * Time.deltaTime);
        //1�ʿ� 60���� ���ư�.
    }
}
