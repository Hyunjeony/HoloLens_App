using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventScript : MonoBehaviour
{
    public GameObject SojuCapObj;
    public AudioClip CapSound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Ű���� �׽�Ʈ
        if(Input.GetKeyDown(KeyCode.Alpha0)) // ���÷��� ����
        {
            ReplayScene();
        }
        // Ű���� �׽�Ʈ
        if (Input.GetKeyDown(KeyCode.Alpha1)) // ���÷��� ����
        {
            OpenSoju();
        }
    }

    public void ReplayScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("BeerGame");
    }

    public void OpenSoju()
    {
        AudioSource.PlayClipAtPoint(CapSound as AudioClip, Camera.main.transform.position);
        SojuCapObj.GetComponent<Animation>().Play("OpenCap");
    }
}
