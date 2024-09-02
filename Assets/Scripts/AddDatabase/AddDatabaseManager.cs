using System;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
public class AddDatabaseManager : MonoBehaviour, Test
{
    public static string _databaseName = "";
    private AppManager _appManager;
    
    public void Save()
    {
        _appManager.KeepChanges(this);
    }
}
