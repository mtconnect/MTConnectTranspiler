﻿using MtconnectTranspiler.Contracts;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi.UML
{
    /// <summary>
    /// <inheritdoc cref="MtconnectTranspiler.Xmi.PackagedElement" /> where <c>xmi:type='uml:DataType'</c>
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.XmiStructure.PACKAGED_ELEMENT, Namespace = "")]
    public class UmlDataType : PackagedElement
    {
        /// <inheritdoc cref="MtconnectTranspiler.Xmi.XmiElement.Type"/>
        public override string Type => XmlHelper.UmlStructure.DataType;

        /// <summary>
        /// <c>isAbstract</c> attribute
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.isAbstract, Namespace = "")]
        private bool _isAbstract { get; set; }
        /// <inheritdoc cref="_isAbstract"/>
        public bool IsAbstract => _isAbstract;

        /// <summary>
        /// <c>visibility</c> attribute
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.visibility, Namespace = "")]
        private string _visibility { get; set; } = "public";
        /// <inheritdoc cref="_visibility"/>
        public string Visibility => _visibility;

        /// <summary>
        /// Collection of <inheritdoc cref="UmlComment"/>
        /// </summary>
        [XmlElement(ElementName = XmlHelper.XmiStructure.OWNED_COMMENT, Namespace = "")]
        public UmlComment[]? Comments { get; set; }

        /// <summary>
        /// Collection of <inheritdoc cref="UmlGeneralization"/>
        /// </summary>
        [XmlElement(ElementName = XmlHelper.XmiStructure.GENERALIZATION, Namespace = "")]
        public UmlGeneralization[]? Generalization { get; set; }
    }
}