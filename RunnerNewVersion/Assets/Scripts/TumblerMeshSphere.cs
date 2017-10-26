using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TumblerMeshSphere : MonoBehaviour {

    private void OnTriggerExit(Collider other)
    {
        if (other.name == "Cube") GetComponent<MeshRenderer>().enabled = false;
        if (other.name == "Cube1") GetComponent<MeshRenderer>().enabled = true;
    }

}
