using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class chat_Manger : MonoBehaviour
{
    private static int touchNum = 0;
    

    string[] npcChat_K =
    {
        "�̹���....�ʾ�� ������ �� ���� \n���� ���� ������ ���ߵ��� ��!",
        "��....���� �ϴ� �༮���ݾ�?",
        "�׷� ���ݾ�.....����....Ȥ��.....������ �� �ֿ��ٷ�....? ����\n����...�˴ٽ��� �ھ˶��......������ �ݱ⿡��......",
        "���� �����.... ������ �� �־�?",
        "����....�ΰ����� ���� ������ ������ \n�� ģ������ ���� ������ ���Ⱦ�....",
        "�ʴ� �׷� ��� �ƴ� �� ���� ����",
        ""
    };

    [SerializeField] public Text npcText;

    private void Start()
    {

        npcText.text = npcChat_K[0];
        //touchNum++;
    }

    public void OnTouchedK()
    {
         
        if (touchNum == 1)
        {
            npcText.text = npcChat_K[1];
            touchNum++;
        }

        else if (touchNum == 2)
        {
            npcText.text = npcChat_K[2];
            touchNum++;
        }

        else if (touchNum == 3)
        {
            npcText.text = npcChat_K[3];
            touchNum++;
        }

        else if (touchNum == 4)
        {
            npcText.text = npcChat_K[4];
            touchNum++;
        }

        else if (touchNum == 5)
        {
            npcText.text = npcChat_K[5];
            touchNum++;
        }

        else if (touchNum == 6)
        {
            touchNum++;
        }


    }
            
    void Update()
    {

        if (npcChat_K.Length == touchNum)
        {

            npc.ischatdone = true;

        }

    }


}
