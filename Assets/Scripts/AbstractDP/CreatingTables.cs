using System.Collections.Generic;
using System.Numerics;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Quaternion = UnityEngine.Quaternion;
using Vector3 = UnityEngine.Vector3;

public class CreatingTables : MonoBehaviour
{
    public static string DATABASE = "";
    public static string TABLE = "";
    [SerializeField] private Toggle _addTable;
    [SerializeField] private GameObject _addTablePanel;

    [SerializeField] private Toggle _saveButton;
    [SerializeField] private Toggle _cancelButton;

    [SerializeField] private TMP_InputField _databaseName;
    [SerializeField] private TMP_InputField _tableName;

    [SerializeField] private Toggle _addColumnButton;
    [SerializeField] private GameObject _addColumnPanel;

    [SerializeField] private DrawTables _drawTables;

    [SerializeField] private GameObject _tableContent;
    [SerializeField] private TextMeshProUGUI _tableNamePrefab;

    [SerializeField] private GameObject _tablePrefab;

    [SerializeField] private GameObject _prefabPos;
    
    private List<TextMeshProUGUI> _addedTablesName = new List<TextMeshProUGUI>();
    private void Start()
    {
        _addTable.onValueChanged.AddListener((check => { _addTablePanel.SetActive(true); }));
        _saveButton.onValueChanged.AddListener((check =>
        {
            
            if (_databaseName.text == "" && _tableName.text == "")
            {
                _addTablePanel.SetActive(true);
            }
            else if(_databaseName.text != "" && _tableName.text!="")
            {
                _addTablePanel.SetActive(false);
                DATABASE = _databaseName.text;
                TABLE = _tableName.text;
                
                _drawTables.SaveDBandTable();
                _tableNamePrefab.text = TABLE; 
                
                var newTablePanel = Instantiate(_tableNamePrefab, _tableContent.transform, true);
                newTablePanel.transform.localScale = Vector3.one;
                _addedTablesName.Add(newTablePanel);

                var newTable = Instantiate(_tablePrefab, _prefabPos.transform, true);
                newTable.transform.localScale = Vector3.one;
                
                if(_databaseName.text != null)
                    _databaseName.gameObject.SetActive(false);
                _tableName.text = "";
                
                
            }
        }));
        
        _cancelButton.onValueChanged.AddListener((check =>
        {
            _addTablePanel.SetActive(false);
        }));
        
        _addColumnButton.onValueChanged.AddListener((check =>
        {
            _addColumnPanel.SetActive(true);
        }));
    }
}