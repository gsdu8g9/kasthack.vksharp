﻿using System;
using System.Collections.Generic;
using System.Xml;
using VKSharp.Core.Entities;
using VKSharp.Core.Interfaces;

namespace VKSharp.Core.EntityParsers {
    public class PrivacyParser:IVKEntityParser<Privacy> {
        private static readonly Lazy<PrivacyParser> Lazy = new Lazy<PrivacyParser>( () => new PrivacyParser() );
        public static PrivacyParser Instanse {
            get {
                return Lazy.Value;
            }
        }

        private PrivacyParser() {}

        public void FillFromXml(IEnumerable<XmlNode> nodes, ref Privacy entity) {
            throw new NotImplementedException();
        }

        public Privacy ParseFromXml(XmlNode node) {
            throw new NotImplementedException();
        }

        public Privacy[] ParseAllFromXml(IEnumerable<XmlNode> nodes) {
            throw new NotImplementedException();
        }

        public Privacy ParseFromXmlFragments(IEnumerable<XmlNode> nodes) {
            throw new NotImplementedException();
        }

        public void UpdateFromFragment(XmlNode node, ref Privacy entity) {
            throw new NotImplementedException();
        }

    }
}
