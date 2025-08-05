using UnityEngine;

public class NameChanger : MonoBehaviour
{
    public void NameChange(string s)
    {

       NameManeger.Instance.Name = s;


    }
}
