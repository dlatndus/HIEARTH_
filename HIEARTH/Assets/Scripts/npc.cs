using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npc : MonoBehaviour {

    public static int[] npcNum = { 0, 0, 0, 0 };
    public static bool ischatdone = true;

    //npc
    public GameObject npcK_;
    public GameObject npcW_;
    public GameObject npcT_;
    public GameObject npcS_;


    //��ȭâ
    public GameObject npc_1;
    public GameObject npc_2;
    public GameObject npc_3;
    public GameObject npc_4;

    //����Ű ����
    public GameObject move;
    private void Update()
    {
        if (ischatdone == true)
        {

            npc_1.SetActive(false);
            move.SetActive(true);


        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        

        if (collision.transform.tag == "npcK")
        {
            ischatdone = false;


            //�ϴ� npc��ȭ �����߳� ���߳� Ȯ��
            if (npcNum[0] == 0)
            {
                npc_1.SetActive(true);
                npcK_.GetComponent<BoxCollider2D>().enabled = false; //������ ���� �ְ� ������Ʈ ��Ȱ��ȭ
                move.SetActive(false);
                npcNum[0] = 1;
                

                


            }

            
                
        }

        

        if (collision.transform.tag == "npcW")
        {
            //Debug.Log("npc");

            //�ϴ� npc��ȭ �����߳� ���߳� Ȯ��
            if (npcNum[1] == 0)
            {
                npc_2.SetActive(true);

                if (Input.GetTouch(0).phase == TouchPhase.Ended)
                {

                }

                npcW_.GetComponent<BoxCollider2D>().enabled = false; //������ ���� �ְ� ������Ʈ ��Ȱ��ȭ
                npcNum[1] = 1;
            }

        }

        if (collision.transform.tag == "npcT")
        {
            //Debug.Log("npc");

            //�ϴ� npc��ȭ �����߳� ���߳� Ȯ��
            if (npcNum[2] == 0)
            {
                npc_3.SetActive(true);

                if (Input.GetTouch(0).phase == TouchPhase.Ended)
                {

                }

                npcT_.GetComponent<BoxCollider2D>().enabled = false; //������ ���� �ְ� ������Ʈ ��Ȱ��ȭ
                npcNum[2] = 1;
            }

        }

        if (collision.transform.tag == "npcS")
        {
            //Debug.Log("npc");

            //�ϴ� npc��ȭ �����߳� ���߳� Ȯ��
            if (npcNum[3] == 0)
            {
                npc_4.SetActive(true);

                if (Input.GetTouch(0).phase == TouchPhase.Ended)
                {

                }

                npcS_.GetComponent<BoxCollider2D>().enabled = false; //������ ���� �ְ� ������Ʈ ��Ȱ��ȭ
                npcNum[3] = 1;
            }

        }
    }
}
