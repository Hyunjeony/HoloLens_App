using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AniEvent : MonoBehaviour
{
    // 뚜껑이 날아간 후 사라지게 만드는 코드

    public GameObject SojuCap;

    public void SojuCapDestory()
    {
        Destroy(SojuCap);
    }

}
