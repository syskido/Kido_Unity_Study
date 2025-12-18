using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello Unity!");

        //1.변수
        int level = 5;
        float strength = 15.5f;
        string playerName = "검사";
        bool isFullLevel = false;        

        //2.그룹형 변수
        //string[] monsters = { "윤기도", "천사교통", "천사택시" };
        //int[] monsterLevel = new int[3];
        //monsterLevel[0] = 1;
        //monsterLevel[1] = 6;
        //monsterLevel[2] = 20;

        //Debug.Log("맵에 존재하는 몬스터의 레벨");
        //Debug.Log(monsterLevel[0]);
        //Debug.Log(monsterLevel[1]);
        //Debug.Log(monsterLevel[2]);

        List<string> items = new List<string>();
        items.Add("생명물약30");
        items.Add("마나물약30");

        Debug.Log("가지고 있는 아이템");
        Debug.Log(items[0]);
        Debug.Log(items[1]);
    }  
}
