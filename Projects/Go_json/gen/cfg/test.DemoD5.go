//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg

import "errors"

type TestDemoD5 struct {
    X1 int32
    Time *TestDateTimeRange
}

const TypeId_TestDemoD5 = -2138341744

func (*TestDemoD5) GetTypeId() int32 {
    return -2138341744
}

func (_v *TestDemoD5)Deserialize(_buf map[string]interface{}) (err error) {
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["x1"].(float64); !_ok_ { err = errors.New("x1 error"); return }; _v.X1 = int32(_tempNum_) }
    { var _ok_ bool; var _x_ map[string]interface{}; if _x_, _ok_ = _buf["time"].(map[string]interface{}); !_ok_ { err = errors.New("time error"); return }; if _v.Time, err = DeserializeTestDateTimeRange(_x_); err != nil { return } }
    return
}

func DeserializeTestDemoD5(_buf map[string]interface{}) (*TestDemoD5, error) {
    v := &TestDemoD5{}
    if err := v.Deserialize(_buf); err == nil {
        return v, nil
    } else {
        return nil, err
    }
}