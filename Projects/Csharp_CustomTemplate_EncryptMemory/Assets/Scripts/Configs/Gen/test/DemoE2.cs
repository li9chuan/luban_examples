
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using Newtonsoft.Json;
using Scripts;







namespace cfg.test
{
    [Serializable]
    public partial class DemoE2 : AConfig
    {
        [JsonProperty("y1")]
        private int? _y1 { get; set; }
        [JsonIgnore]
        public EncryptInt y1 { get; private set; } = new();

        public bool  y2 { get; set; }


        public override void EndInit() 
        {
            y1 = _y1;
        }

        public override string ToString() => JsonConvert.SerializeObject(this);
    }
}