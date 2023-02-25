using MemoryPack;
using MessagePack;
using System;
using System.Collections.Generic;

namespace NewDatasourceTest
{
    [MemoryPackable]
    [MessagePackObject(keyAsPropertyName: true)]
    public partial class Yubin
    {
        public string KokyoCd { get; set; } = null!;
        public string Yubin5 { get; set; } = null!;
        public string Yubin7 { get; set; } = null!;
        public string? TodofukenKana { get; set; }
        public string? CityKana { get; set; }
        public string? TyoKana { get; set; }
        public string? Todofuken { get; set; }
        public string? City { get; set; }
        public string? Tyo { get; set; }
        public string? Flg1 { get; set; }
        public string? Flg2 { get; set; }
        public string? Flg3 { get; set; }
        public string? Flg4 { get; set; }
        public string? UpdFlg { get; set; }
        public string? Upd { get; set; }
    }
}
