//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg

import "errors"

type AiDecorator struct {
    Id int32
    NodeName string
    FlowAbortMode int32
}

const TypeId_AiDecorator = 2017109461

func (*AiDecorator) GetTypeId() int32 {
    return 2017109461
}

func (_v *AiDecorator)Deserialize(_buf map[string]interface{}) (err error) {
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["id"].(float64); !_ok_ { err = errors.New("id error"); return }; _v.Id = int32(_tempNum_) }
    { var _ok_ bool; if _v.NodeName, _ok_ = _buf["node_name"].(string); !_ok_ { err = errors.New("node_name error"); return } }
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["flow_abort_mode"].(float64); !_ok_ { err = errors.New("flow_abort_mode error"); return }; _v.FlowAbortMode = int32(_tempNum_) }
    return
}

func DeserializeAiDecorator(_buf map[string]interface{}) (interface{}, error) {
    var id string
    var _ok_ bool
    if id, _ok_ = _buf["$type"].(string) ; !_ok_ {
        return nil, errors.New("type id missing")
    }
    switch id {
        case "UeLoop": _v := &AiUeLoop{}; if err := _v.Deserialize(_buf); err != nil { return nil, errors.New("ai.UeLoop") } else { return _v, nil }
        case "UeCooldown": _v := &AiUeCooldown{}; if err := _v.Deserialize(_buf); err != nil { return nil, errors.New("ai.UeCooldown") } else { return _v, nil }
        case "UeTimeLimit": _v := &AiUeTimeLimit{}; if err := _v.Deserialize(_buf); err != nil { return nil, errors.New("ai.UeTimeLimit") } else { return _v, nil }
        case "UeBlackboard": _v := &AiUeBlackboard{}; if err := _v.Deserialize(_buf); err != nil { return nil, errors.New("ai.UeBlackboard") } else { return _v, nil }
        case "UeForceSuccess": _v := &AiUeForceSuccess{}; if err := _v.Deserialize(_buf); err != nil { return nil, errors.New("ai.UeForceSuccess") } else { return _v, nil }
        case "IsAtLocation": _v := &AiIsAtLocation{}; if err := _v.Deserialize(_buf); err != nil { return nil, errors.New("ai.IsAtLocation") } else { return _v, nil }
        case "DistanceLessThan": _v := &AiDistanceLessThan{}; if err := _v.Deserialize(_buf); err != nil { return nil, errors.New("ai.DistanceLessThan") } else { return _v, nil }
        default: return nil, errors.New("unknown type id")
    }
}