using UnityEngine;

public class ListViewUIController : MonoBehaviour
{
    [SerializeField]
    private GameObject _listItemPrefab;
    [SerializeField]
    private Transform _itemContainer;

    public void AddNewItem()
    {
        Instantiate(_listItemPrefab, _itemContainer);
    }
}
