using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventScriptGlass : MonoBehaviour
{
    public GameObject Cylinder;
    public AudioClip DrinkingSound;
    public AudioClip Drinking1Sound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 키보드 테스트
        if (Input.GetKeyDown(KeyCode.Alpha2)) // 리플레이 음성
        {
            Cheers();
        }
    }

    private void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.name == "CollSoju") 
        {
            AudioSource.PlayClipAtPoint(DrinkingSound as AudioClip, Camera.main.transform.position);
            Cylinder.GetComponent<Animation>().Play("Drinking");    // Glass에 술 채우기
        }
    }

    public void Cheers()
    {
        Cylinder.GetComponent<Animation>().Play("Drinking 1"); // Glass에 술 비우기
        AudioSource.PlayClipAtPoint(Drinking1Sound as AudioClip, Camera.main.transform.position);
    }
}
