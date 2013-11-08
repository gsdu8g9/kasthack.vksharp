﻿using VKSharp.Core.EntityParsers;
using VKSharp.Core.Enums;
using VKSharp.Core.Interfaces;

namespace VKSharp.Core.Entities {
    public class Privacy:IVKEntity<Privacy> {
        public PrivacyType PrivacyType { get; set; }
        public uint[] Lists { get; set; }
        public uint[] ExceptLists { get; set; }
        public uint[] Users { get; set; }
        public uint[] ExceptUsers { get; set; }
        public IVKEntityParser<Privacy> GetParser() {
            return PrivacyParser.Instanse;
        }
    }
}