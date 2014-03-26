using System;
using System.IO;
using UnityEngine;

public class EntryScript : MonoBehaviour 
{
  public void Start () 
  {
    var test = new A.CO_SimpleClassLibrary_MainClass();

    var consoleOut = new StringWriter();
    Console.SetOut(consoleOut);

    try
    {
      var message = test.CO_GetString();    
      Debug.Log("Obfuscated: " + message);
    }
    catch (Exception e)
    {
      Debug.LogError(e);
      Debug.LogWarning(consoleOut.ToString());
    }
  }
}
