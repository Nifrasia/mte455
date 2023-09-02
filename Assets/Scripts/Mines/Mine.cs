using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mine : MonoBehaviour
{
    [SerializeField] protected int hp;
    public int HP { get { return hp; } set { hp = value; } }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Deplete(int n)
    {
        hp -= n;
        if (hp <= 0)
            Destroy(gameObject);
    }
}
