﻿using System;
using Microsoft.SharePoint.Client;
using SPMeta2.CSOM.ModelHandlers.Base;
using SPMeta2.Definitions.Base;
using SPMeta2.Definitions.DisplayTemplates;
using SPMeta2.Enumerations;
using SPMeta2.Utils;

namespace SPMeta2.CSOM.ModelHandlers.DisplayTemplates
{
    public class ItemDisplayTemplateModelHandler : TemplateModelHandlerBase
    {
        public override string FileExtension
        {
            get { return "html"; }
            set
            {

            }
        }

        protected override void MapProperties(object modelHost, ListItem item, TemplateDefinitionBase definition)
        {
            var typedDefinition = definition.WithAssertAndCast<ItemDisplayTemplateDefinition>("model", value => value.RequireNotNull());

            item[BuiltInInternalFieldNames.ContentTypeId] = "0x0101002039C03B61C64EC4A04F5361F38510660300500DA5E";
            //item["DisplayTemplateLevel"] = "Item";


            if (!string.IsNullOrEmpty(typedDefinition.ManagedPropertyMappings))
                item["ManagedPropertyMapping"] = typedDefinition.ManagedPropertyMappings;
        }

        public override Type TargetType
        {
            get { return typeof(ItemDisplayTemplateDefinition); }
        }
    }
}
