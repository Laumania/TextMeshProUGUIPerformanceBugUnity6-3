using UnityEngine;

public class ListViewUIController : MonoBehaviour
{
    [SerializeField]
    private GameObject _listItemPrefab;
    [SerializeField]
    private Transform _itemContainer;

    public void Populate()
    {
        Debug.Log("BEGIN POPULATE");
        for (int i = 0; i < 300; i++)
        {
            Instantiate(_listItemPrefab, _itemContainer);
        }
        Debug.Log("FINISH POPULATE");
    }
}
