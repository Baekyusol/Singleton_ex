using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    // static �� ���ӵǸ� �޸� ���� ��Ƹ���
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
            // ���� ��ȯ�Ǿ ����
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }


    public void Save()
    {
        //���� ���
        Debug.Log("���� �Ϸ�!!");
    }
}
