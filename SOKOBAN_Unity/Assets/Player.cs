using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public GameManager gameManager; //추가


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
        /* 1번
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







        /* 2번
         * 
        - InputAxis사용 - Addforce()- 관성사용
        float inputX = Input.GetAxis("Horizontal");

        float inputZ = Input.GetAxis("Vertical");


        rb.AddForce(inputX * speed, 0, inputZ * speed);

        */





        /*
        - 관성삭제
        - Rigidbody의 velocity변수 값 바꿔주기 (중력 적용 안됨)
        */

        float inputX = Input.GetAxis("Horizontal");

        float inputZ = Input.GetAxis("Vertical");

        float fallSpeed = rb.velocity.y; //y의 값을 보존 ( 쭉 이어간다 ) 

        Vector3 velocity = new Vector3(inputX, 0, inputZ);
        velocity = velocity * speed;

        velocity.y = fallSpeed; //입력에 결정 되었던 y는 기존에 보존되었던 y값으로 

        rb.velocity = velocity;

        /*
        속도 변수값을 직접 지정해주는 방법.
        입력을 계속할 때 = 중력을 받지않음
        입력이 들어오는 순간마다 x,z축으로 이동할뿐 y축값은 0으로 유지된다.
        
        입력 안하는 중일 때 = 확 떨어지는게 아닌 이상하게 아주 천천히 떨어지는 요상한 모양이 된다.
        따라서, 중력가속도를 받아 속도가 떨어졌다가 바로 이내 playerRigidbody.velocity = Vector3(0,0,0)으로 덮어씌워짐.
        그래서 떨어지다 말다 떨어지다 말다 하며 아주 천천히 떨어지는 모양이 되는것.

        결론적으로 필요한것
        원래 y의 속도를 보존시켜줘야 한다.


        즉, Rigidbody.velocity= Vector3(inputX * speed, falldown * speed, inputZ*speed)와 같다.
        */
    }

}
