using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    // Start is called before the first frame update
    public List<Transform> enemies = new List<Transform>();
    private void Awake() {
        if (instance != null && instance != this)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
        }
    }
    void Start()
    {
        GameObject[] candidates = GameObject.FindGameObjectsWithTag("enemy");
        for ( int i = 1 ; i < candidates.Length ; ++i )
        {
            enemies.Add(candidates[i].transform);
        }   
    }

    // Update is called once per frame
    void Update()
    {
    }
}
