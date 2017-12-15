using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesUlyot : MonoBehaviour {
    public GameObject RotateEnemies;
    public GameObject Enemy2, Enemy1Clone, Enemy2Clone, Clone1, Clone2;
    public bool Rotate, MiniTimer;
    public float miniTimer;
	// Use this for initialization
	void Start () {
		
	}
	public void Uliot()
    {
        MiniTimer = true;
        gameObject.GetComponent<MeshRenderer>().enabled = false;
        Enemy2.GetComponent<MeshRenderer>().enabled = false;
        Clone1 = Instantiate(Enemy1Clone,gameObject.transform.position, gameObject.transform.rotation, RotateEnemies.transform);
        Clone2 = Instantiate(Enemy2Clone, Enemy2.transform.position, Enemy2.transform.rotation, RotateEnemies.transform);
        RotateEnemies.GetComponent<RotateEnemies>().Rotate = true;
        gameObject.GetComponent<EnemyBehavior>().enabled = false;
        gameObject.GetComponent<Enemy1Behavior2>().enabled = false;
        Enemy2.GetComponent<Enemy2Behavior>().enabled = false;
        gameObject.GetComponent<Rigidbody>().velocity = new Vector3();
        Enemy2.GetComponent<Rigidbody>().velocity = new Vector3();
    }
    public void Priliot()
    {
        gameObject.GetComponent<MeshRenderer>().enabled = true;
        Enemy2.GetComponent<MeshRenderer>().enabled = true;
        Destroy(Clone1);
        Destroy(Clone2);
        RotateEnemies.GetComponent<RotateEnemies>().Rotate = false;
        Rotate = false;
        gameObject.GetComponent<EnemyBehavior>().enabled = true;
        gameObject.GetComponent<Enemy1Behavior2>().enabled = true;
        Enemy2.GetComponent<Enemy2Behavior>().enabled = true;
        RotateEnemies.GetComponent<RotateEnemies>().time = 0f;
        Clone1 = Enemy1Clone;
        Clone2 = Enemy2Clone;
    }
	// Update is called once per frame
	void Update () {
        if (MiniTimer)
        {
            miniTimer += Time.deltaTime;
        }
        if (miniTimer > 0.1)
        {
            Rotate = true;
            miniTimer = 0;
            MiniTimer = false;
        }


        if (Rotate)
            if (Clone1.transform.position.z > transform.position.z - 0.05 && Clone1.transform.position.y > transform.position.y - 0.05) Priliot();
    }
    //private void OnTriggerEnter(Collider other)
    //{
    //    if (Rotate)
    //        if () Priliot();
    //}
}
