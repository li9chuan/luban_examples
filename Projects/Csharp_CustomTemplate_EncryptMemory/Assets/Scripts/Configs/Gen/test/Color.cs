
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
    public partial class Color : AConfig
    {
        [JsonProperty("r")]
        private float _r { get; set; }
        [JsonIgnore]
        public EncryptFloat r { get; private set; } = new();

        [JsonProperty("g")]
        private float _g { get; set; }
        [JsonIgnore]
        public EncryptFloat g { get; private set; } = new();

        [JsonProperty("b")]
        private float _b { get; set; }
        [JsonIgnore]
        public EncryptFloat b { get; private set; } = new();

        [JsonProperty("a")]
        private float _a { get; set; }
        [JsonIgnore]
        public EncryptFloat a { get; private set; } = new();


        public override void EndInit() 
        {
            r = _r;
            g = _g;
            b = _b;
            a = _a;
        }

        public override string ToString() => JsonConvert.SerializeObject(this);
    }
}