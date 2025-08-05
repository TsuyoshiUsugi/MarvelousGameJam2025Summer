using UnityEngine;

public class NameChanger : MonoBehaviour
{
    public void NameChange(string s)
    {
        if (s == string.Empty)
            s = "NoName";
        NameManeger.Instance.Name = s;


    }
}
