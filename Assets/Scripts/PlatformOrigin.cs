using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlatformOrigin : MonoBehaviour
{

    [SerializeField] GameObject origin;
    Vector3 position;

    void Start()
    {
        position = gameObject.transform.position;
    }

    public void CreateNewPlatform()
    {

        //gameObject.transform.position = new Vector2(gameObject.transform.position.x, Random.Range(-4, 0));
    #if DEBUG
        Instantiate(AssetDatabase.LoadAssetAtPath<GameObject>("Assets/Resources/Prefabs/Platform.prefab"), new Vector3(position.x, position.y, position.z), Quaternion.identity);
    #else
        Instantiate(Resources.Load<GameObject>("Prefabs/Platform"), new Vector3(position.x, position.y, position.z), Quaternion.identity);
    #endif
    }


}
