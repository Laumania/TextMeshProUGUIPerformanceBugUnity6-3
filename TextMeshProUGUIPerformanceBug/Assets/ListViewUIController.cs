using UnityEngine;

public class ListViewUIController : MonoBehaviour
{
    [SerializeField]
    private GameObject _listItemPrefab;
    [SerializeField]
    private Transform _itemContainer;

    public void Populate()
    {
        for (int i = 0; i < 300; i++)
        {
            Instantiate(_listItemPrefab, _itemContainer);
        }
    }
}
