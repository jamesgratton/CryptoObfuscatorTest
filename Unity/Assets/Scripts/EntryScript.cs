using UnityEngine;

public class EntryScript : MonoBehaviour 
{
  public void Start () 
  {
    var test = new A.CO_SimpleClassLibrary_MainClass();

    var message = test.CO_GetString();    

    Debug.Log("Obfuscated: " + message);
  }
}
