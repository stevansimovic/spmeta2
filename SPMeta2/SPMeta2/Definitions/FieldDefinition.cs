﻿using SPMeta2.Attributes;
using SPMeta2.Attributes.Regression;
using System;

namespace SPMeta2.Definitions
{
    /// <summary>
    /// Allows to define and deploy SharePoint field.
    /// </summary>
    [SPObjectTypeAttribute(SPObjectModelType.SSOM, "Microsoft.SharePoint.SPField", "Microsoft.SharePoint")]
    [SPObjectTypeAttribute(SPObjectModelType.CSOM, "Microsoft.SharePoint.Client.Field", "Microsoft.SharePoint.Client")]

    [ParentHostAttribute(typeof(SiteDefinition))]
    [RootHostAttribute(typeof(SiteDefinition))]

    [Serializable]
    public class FieldDefinition : DefinitionBase
    {
        #region constructors

        public FieldDefinition()
        {
            // it needs to be string.Empty to avoid challenges with null VS string.Empty test cases for strings
            Description = string.Empty;
        }

        #endregion

        #region properties

        /// <summary>
        /// Internal name of the target field.
        /// </summary>
        public string InternalName { get; set; }

        /// <summary>
        /// Title of the target field.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Description of the target field.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Group of the target field.
        /// </summary>
        public string Group { get; set; }

        /// <summary>
        /// ID of the target field.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Type of the target field.
        /// BuiltInFieldTypes class can be used to utilize out of the box SharePoint fields.
        /// </summary>
        public string FieldType { get; set; }

        /// <summary>
        /// Required flag for the target field.
        /// </summary>
        public bool Required { get; set; }

        #endregion

        #region methods

        public override string ToString()
        {
            return string.Format("InternalName:[{0}] Id:[{1}] Title:[{2}]", InternalName, Id, Title);
        }

        #endregion
    }
}