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

        //Debug.Log("용사의 이름은 ?");
        //Debug.Log(playerName);
        //Debug.Log("용사의 레벨은?");
        //Debug.Log(level);
        //Debug.Log("용사의 힘은?");
        //Debug.Log(strength);
        //Debug.Log("용사는 만렙인가?");
        //Debug.Log(isFullLevel);

        //2.그룹형 변수
        string[] monsters = { "윤기도", "천사교통", "천사택시" };

        Debug.Log("맵에 존재하는 몬스터");
        Debug.Log(monsters[0]);
        Debug.Log(monsters[1]);
        Debug.Log(monsters[2]);
    }  
}
