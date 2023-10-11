using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class EnemyDragon : MonoBehaviour
{
    [Header("Set in Inspector")]
    public GameObject dragonEggPrefab;
    public GameObject dragonEgg_Prefab;
    public float speed = 1f;
    public float timeBetweenEggDrops = 1f;
    public float timeBetweenEgg_Drops = 5f;
    public float leftRightDistance = 10f;
    public float chanceDirections = 0.1f;
    void Start()
    {
        Invoke("DropEgg", 2f);
        Invoke("Drop_Egg", 10f);// 1
    }
    void DropEgg() // Хорошие Яйца
    {
        Vector3 myVector = new
        Vector3(0.0f, 5.0f, 0.0f);
        GameObject egg =
        Instantiate<GameObject>(dragonEggPrefab);
        egg.transform.position =
        transform.position + myVector;
        Invoke("DropEgg", timeBetweenEggDrops);
    }
    void Drop_Egg() // Плохие яйца
    {
        Vector3 myVector = new
        Vector3(0.0f, 5.0f, 0.0f);
        GameObject egg1 =
        Instantiate<GameObject>(dragonEgg_Prefab);
        egg1.transform.position =
        transform.position + myVector;
        Invoke("Drop_Egg", timeBetweenEgg_Drops);
    }

    void Update()
    {
        Vector3 pos = transform.position; //1
        pos.x += speed * Time.deltaTime; //2
        transform.position = pos; //3
        if (pos.x < -leftRightDistance) //1
        {
            speed = Mathf.Abs(speed);
        }
        else if (pos.x > leftRightDistance) //2
        {
            speed = -Mathf.Abs(speed);
        }

    }
    private void FixedUpdate()
    {
        if (Random.value < chanceDirections)
        {
            speed *= -1;
        }
    }


}

