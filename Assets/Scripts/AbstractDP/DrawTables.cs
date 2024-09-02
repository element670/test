using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DrawTables : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _tables;
    public void SaveDBandTable()
    {
        _tables.text = CreatingTables.TABLE;
    }
    
}
