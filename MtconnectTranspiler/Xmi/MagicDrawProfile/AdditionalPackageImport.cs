﻿using MtconnectTranspiler.Contracts;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi.MagicDrawProfile
{
    /// <summary>
    /// <c>&lt;MagicDraw_Profile:additionalPackageImport /&gt;</c> element
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.MagicDrawProfileStructure.ADDITIONAL_PACKAGE_IMPORT, Namespace = XmlHelper.MagicDraw_ProfileNamespace)]
    public class AdditionalPackageImport : ProfileElement
    {
        /// <summary>
        /// <c>base_PackageImport</c> attribute
        /// </summary>
        /// <remarks>Foreign key to the <see cref="XmiElement.Id"/> of the object this applies to.</remarks>
        [XmlAttribute(AttributeName = XmlHelper.MagicDrawProfileStructure.basePackageImport, Namespace = "")]
        public string? BasePackageImport { get; set; }

        /// <summary>
        /// <c>treatAsAuxiliaryInOwningProject</c> attribute
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.MagicDrawProfileStructure.treatAsAuxiliaryInOwningProject, Namespace = "")]
        public string? TreatAsAuxiliaryInOwningProject { get; set; }
    }
}