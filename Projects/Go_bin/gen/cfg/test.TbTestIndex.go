
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg

import "luban_examples/go_bin/bright/serialization"

type TestTbTestIndex struct {
    _dataMap map[int32]*TestTestIndex
    _dataList []*TestTestIndex
}

func NewTestTbTestIndex(_buf *serialization.ByteBuf) (*TestTbTestIndex, error) {
	if size, err := _buf.ReadSize() ; err != nil {
		return nil, err
	} else {
		_dataList := make([]*TestTestIndex, 0, size)
		dataMap := make(map[int32]*TestTestIndex)

		for i := 0 ; i < size ; i++ {
			if _v, err2 := DeserializeTestTestIndex(_buf); err2 != nil {
				return nil, err2
			} else {
				_dataList = append(_dataList, _v)
				dataMap[_v.Id] = _v
			}
		}
		return &TestTbTestIndex{_dataList:_dataList, _dataMap:dataMap}, nil
	}
}

func (table *TestTbTestIndex) GetDataMap() map[int32]*TestTestIndex {
    return table._dataMap
}

func (table *TestTbTestIndex) GetDataList() []*TestTestIndex {
    return table._dataList
}

func (table *TestTbTestIndex) Get(key int32) *TestTestIndex {
    return table._dataMap[key]
}
