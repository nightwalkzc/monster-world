using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float moveSpeed;

    private bool isMove;

    private Vector2 input;

    private Animator animator;

    private void Awake()  //Awake函数作用？
    {
        animator = GetComponent<Animator>();
    }

    private void Update() 
    {
        if(!isMove)
        {
            input.x = Input.GetAxisRaw("Horizontal");
            input.y = Input.GetAxisRaw("Vertical");

            //禁止对角线移动（去掉对角线力矩）
            if(input.x != 0) input.y = 0;

            if(input != Vector2.zero)
            {
                animator.SetFloat("MoveX", input.x);
                animator.SetFloat("MoveY", input.y);

                var targetPos = transform.position;
                targetPos.x += input.x;
                targetPos.y += input.y;

                StartCoroutine(Move(targetPos));
            }

            
        }

        animator.SetBool("IsMove", isMove);
    }

    // 将玩家从当前位置移动到目标位置
    IEnumerator Move(Vector3 targetPos)  // 代码例程
    {

        isMove = true;

        while((targetPos - transform.position).sqrMagnitude > Mathf.Epsilon) //判断：目标位置与当前位置的差值存在微小差别
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPos, moveSpeed*Time.deltaTime);
            yield return null;  //yield是什么东西？
        }
        transform.position = targetPos;

        isMove = false;

    }
}
