using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class collectible : MonoBehaviour
{
    public string collectableName;
    public string description;
    public GameObject player;

    public abstract void Use(); 
}
