﻿using SPMeta2.Attributes;
using SPMeta2.Attributes.Regression;
using System;

namespace SPMeta2.Definitions
{
    /// <summary>
    /// Allows to define and deploy SharePoint content type.
    /// </summary>
    /// 
    [SPObjectTypeAttribute(SPObjectModelType.SSOM, "Microsoft.SharePoint.SPContentType", "Microsoft.SharePoint")]
    [SPObjectTypeAttribute(SPObjectModelType.CSOM, "Microsoft.SharePoint.Client.ContentType", "Microsoft.SharePoint.Client")]

    [ParentHostAttribute(typeof(SiteDefinition))]
    [RootHostAttribute(typeof(SiteDefinition))]

    [Serializable]

    public class ContentTypeDefinition : DefinitionBase
    {
        #region properties

        /// <summary>
        /// ID of the target content type. 
        /// Final content type id is calculated based on ParentContentTypeId, IdNumberValue or Id properties with ContentTypeDefinitionSyntax.GetContentTypeId() method.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// IdNumberValue of the target content type. 
        /// Final content type id is calculated based on ParentContentTypeId, IdNumberValue or Id properties with ContentTypeDefinitionSyntax.GetContentTypeId() method.
        /// </summary>
        public string IdNumberValue { get; set; }

        /// <summary>
        /// Name of the target content type.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Description if the target content type.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Group of the target content type.
        /// </summary>
        public string Group { get; set; }

        /// <summary>
        /// Parent content type id. BuiltInContentTypeId class could be used to utilize out of the box content type ids.
        /// </summary>
        public string ParentContentTypeId { get; set; }

        #endregion

        #region methods

        public override string ToString()
        {
            return string.Format("Name:[{0}] Id:[{1}] IdNumberValue:[{2}]", Name, Id, IdNumberValue);
        }

        #endregion
    }
}