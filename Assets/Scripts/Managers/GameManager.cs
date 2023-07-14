using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static GameManager instance;

    [SerializeField] private int day = 0;
    public int Day { get { return day; } set { day = value; } }

    private void Awake()
    {
        instance = this;
    }
}
