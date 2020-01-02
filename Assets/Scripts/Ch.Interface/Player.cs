using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int gold = 1000;

    public int hp = 50;

    private void OnTriggerEnter(Collider other)
    {
        ////인터페이스를 사용하지 않으면 매번 아래와 같이 물어봐야한다 아이템이 100개면 100개 질문을 하여야한다.
        //GoldItem goldItem = other.GetComponent<GoldItem>();

        //if(goldItem != null)
        //{
        //    goldItem.Use();
        //}

        //HealthKitItem healthKitItem = other.GetComponent<HealthKitItem>();

        //if(healthKitItem != null)
        //{
        //    healthKitItem.Use();
        //}

        //인터페이스에 의하여 어떠한 메서드가 강제되기 때문에 유형에 상관없이 인터페이스의 가상함수를 재정의해서 갖고 있음.
        IItem item = other.GetComponent<IItem>();
        
        if(item != null)
        {
            item.Use();
        }
    }
}
