using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public GameManager gameManager; //�߰�


    public float speed = 10f;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(0, speed, 0);
    }

    // Update is called once per frame
    void Update()
    {

        if (gameManager.isGameOver == true)
        {
            return;
        }
        /* 1��
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(0, 0, 1);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-1, 0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(0, 0, -1);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(1, 0, 0);
        }
        */







        /* 2��
         * 
        - InputAxis��� - Addforce()- �������
        float inputX = Input.GetAxis("Horizontal");

        float inputZ = Input.GetAxis("Vertical");


        rb.AddForce(inputX * speed, 0, inputZ * speed);

        */





        /*
        - ��������
        - Rigidbody�� velocity���� �� �ٲ��ֱ� (�߷� ���� �ȵ�)
        */

        float inputX = Input.GetAxis("Horizontal");

        float inputZ = Input.GetAxis("Vertical");

        float fallSpeed = rb.velocity.y; //y�� ���� ���� ( �� �̾�� ) 

        Vector3 velocity = new Vector3(inputX, 0, inputZ);
        velocity = velocity * speed;

        velocity.y = fallSpeed; //�Է¿� ���� �Ǿ��� y�� ������ �����Ǿ��� y������ 

        rb.velocity = velocity;

        /*
        �ӵ� �������� ���� �������ִ� ���.
        �Է��� ����� �� = �߷��� ��������
        �Է��� ������ �������� x,z������ �̵��һ� y�ప�� 0���� �����ȴ�.
        
        �Է� ���ϴ� ���� �� = Ȯ �������°� �ƴ� �̻��ϰ� ���� õõ�� �������� ����� ����� �ȴ�.
        ����, �߷°��ӵ��� �޾� �ӵ��� �������ٰ� �ٷ� �̳� playerRigidbody.velocity = Vector3(0,0,0)���� �������.
        �׷��� �������� ���� �������� ���� �ϸ� ���� õõ�� �������� ����� �Ǵ°�.

        ��������� �ʿ��Ѱ�
        ���� y�� �ӵ��� ����������� �Ѵ�.


        ��, Rigidbody.velocity= Vector3(inputX * speed, falldown * speed, inputZ*speed)�� ����.
        */
    }

}
