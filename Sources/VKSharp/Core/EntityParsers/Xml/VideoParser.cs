﻿using System;
using System.Collections.Generic;
using System.Xml;
using VKSharp.Core.Entities;
using VKSharp.Core.Interfaces;
using VKSharp.Data.Executors;

namespace VKSharp.Core.EntityParsers.Xml {
    public class VideoParser : IXmlVKEntityParser<Video> {
        public IExecutor Executor { get; set; }
        private static readonly Lazy<VideoParser> Lazy = new Lazy<VideoParser>( () => new VideoParser() );
        public static VideoParser Instanse {
            get {
                return Lazy.Value;
            }
        }

        private VideoParser() {}

        public void FillFromXml(IEnumerable<XmlNode> nodes, ref Video entity) {
            throw new NotImplementedException();
        }

        public Video ParseFromXml(XmlNode node) {
            throw new NotImplementedException();
        }

        public Video[] ParseAllFromXml(IEnumerable<XmlNode> nodes) {
            throw new NotImplementedException();
        }

        public Video ParseFromXmlFragments(IEnumerable<XmlNode> nodes) {
            throw new NotImplementedException();
        }

        public void UpdateFromFragment(XmlNode node, ref Video entity) {
            throw new NotImplementedException();
        }
    }
}