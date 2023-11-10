using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    // static 이 지속되면 메모리 많이 잡아먹음
    private static DataManager instance = null;

    public static DataManager Instance
    {
        get
        {
            if(null == instance)
            {
                return null;
            }
            return instance;
        }
    }
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            // 씬이 전환되어도 유지
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }


    public void Save()
    {
        //저장 기능
        Debug.Log("저장 완료!!");
    }
}
