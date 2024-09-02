using UnityEngine;
using UnityEngine.UI;

public class TabsController : MonoBehaviour
{
    [SerializeField] private GameObject _addTablePanel;
    [SerializeField] private Toggle _fileTab;
    [SerializeField] private Toggle _viewsTab;
    [SerializeField] private Toggle _tableTab;
    [SerializeField] private Toggle _addTable;
    private IDatabase db = new DataBase();
    
    [SerializeField] private FilesTab _filesTab;
    [SerializeField] private ViewsTab _viewTab;
    [SerializeField] private TableTab _tablesTab;
    
    private void Awake()
    {
        db.Connect();
        // _fileTab.onValueChanged.AddListener((arg => ShowTab(_filesTab, db)));
        // _viewsTab.onValueChanged.AddListener((arg => ShowTab(_viewTab, db )));
        // _tableTab.onValueChanged.AddListener((arg => ShowTab(_tablesTab, db)));
        
       // _fileTab.onValueChanged.AddListener((arg0 => print(_fileTab.isOn)));
       
       _fileTab.onValueChanged.AddListener((check =>
       {
           ShowTab(_filesTab, db, _filesTab.gameObject, _fileTab.isOn);
       })); 
       
       _viewsTab.onValueChanged.AddListener((check =>
       {
           ShowTab(_viewTab, db, _viewTab.gameObject, _viewsTab.isOn);
       } ));
       
       _tableTab.onValueChanged.AddListener((check =>
       {
           ShowTab(_tablesTab, db, _tablesTab.gameObject, _tableTab.isOn);
       } ));
       // _addTable.onValueChanged.AddListener((click =>
       // {
       //     _addTablePanel.SetActive(click);
       // }));
    }

    private void ShowTab(ITab tab, IDatabase db, GameObject gameObject, bool flag)
    {
        tab.ShowContent(db);
        gameObject.SetActive(flag);
        
    }
    private void OnDestroy()
    {
        db.Close();
    }
}