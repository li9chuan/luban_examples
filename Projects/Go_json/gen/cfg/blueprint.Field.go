//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg

import "errors"

type BlueprintField struct {
    Name string
    Type string
    Desc string
}

const TypeId_BlueprintField = 1694158271

func (*BlueprintField) GetTypeId() int32 {
    return 1694158271
}

func (_v *BlueprintField)Deserialize(_buf map[string]interface{}) (err error) {
    { var _ok_ bool; if _v.Name, _ok_ = _buf["name"].(string); !_ok_ { err = errors.New("name error"); return } }
    { var _ok_ bool; if _v.Type, _ok_ = _buf["type"].(string); !_ok_ { err = errors.New("type error"); return } }
    { var _ok_ bool; if _v.Desc, _ok_ = _buf["desc"].(string); !_ok_ { err = errors.New("desc error"); return } }
    return
}

func DeserializeBlueprintField(_buf map[string]interface{}) (*BlueprintField, error) {
    v := &BlueprintField{}
    if err := v.Deserialize(_buf); err == nil {
        return v, nil
    } else {
        return nil, err
    }
}