//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg

type ItemTbItem struct {
    _dataMap map[int32]*ItemItem
    _dataList []*ItemItem
}

func NewItemTbItem(_buf []map[string]interface{}) (*ItemTbItem, error) {
	_dataList := make([]*ItemItem, 0, len(_buf))
	dataMap := make(map[int32]*ItemItem)
	for _, _ele_ := range _buf {
		if _v, err2 := DeserializeItemItem(_ele_); err2 != nil {
			return nil, err2
		} else {
			_dataList = append(_dataList, _v)
			dataMap[_v.Id] = _v
		}
	}
	return &ItemTbItem{_dataList:_dataList, _dataMap:dataMap}, nil
}

func (table *ItemTbItem) GetDataMap() map[int32]*ItemItem {
    return table._dataMap
}

func (table *ItemTbItem) GetDataList() []*ItemItem {
    return table._dataList
}

func (table *ItemTbItem) Get(key int32) *ItemItem {
    return table._dataMap[key]
}


