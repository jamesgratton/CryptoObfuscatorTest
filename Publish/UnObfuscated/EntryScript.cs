using UnityEngine;

public class EntryScript : MonoBehaviour 
{
  public void Start () 
  {
    var test = new SimpleClassLibrary.MainClass();

    var message = test.GetString();    

    Debug.Log("UnObfuscated: " + message);
  }
}
