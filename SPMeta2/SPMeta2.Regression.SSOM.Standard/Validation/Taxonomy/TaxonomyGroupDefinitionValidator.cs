﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.SharePoint.Taxonomy;
using SPMeta2.Definitions;
using SPMeta2.Definitions.Base;
using SPMeta2.Definitions.Fields;
using SPMeta2.SSOM.ModelHosts;
using SPMeta2.SSOM.Standard.ModelHandlers.Taxonomy;
using SPMeta2.SSOM.Standard.ModelHosts;
using SPMeta2.Standard.Definitions.Taxonomy;
using SPMeta2.Utils;
using SPMeta2.Containers.Assertion;

namespace SPMeta2.Regression.SSOM.Standard.Validation.Taxonomy
{
    public class TaxonomyGroupDefinitionValidator : TaxonomyGroupModelHandler
    {
        public override void DeployModel(object modelHost, DefinitionBase model)
        {
            var termStoreModelHost = modelHost.WithAssertAndCast<TermStoreModelHost>("modelHost", value => value.RequireNotNull());
            var definition = model.WithAssertAndCast<TaxonomyTermGroupDefinition>("model", value => value.RequireNotNull());

            var spObject = FindGroup(termStoreModelHost, definition);

            var assert = ServiceFactory.AssertService
                           .NewAssert(definition, spObject)
                                 .ShouldNotBeNull(spObject);

            if (definition.IsSiteCollectionGroup)
            {
                assert.ShouldBeEqual((p, s, d) =>
                {
                    var srcProp = s.GetExpressionValue(m => m.Name);
                    var group = FindSiteCollectionGroup(termStoreModelHost, definition);

                    var isValid = group.IsSiteCollectionGroup;

                    return new PropertyValidationResult
                    {
                        Tag = p.Tag,
                        Src = srcProp,
                        Dst = null,
                        IsValid = isValid
                    };
                });
            }
            //else if (definition.IsSystemGroup)
            //{
            //    assert.ShouldBeEqual((p, s, d) =>
            //    {
            //        var srcProp = s.GetExpressionValue(m => m.Name);
            //        var group = FindSystemGroup(termStoreModelHost, definition);

            //        var isValid = group.IsSystemGroup;

            //        return new PropertyValidationResult
            //        {
            //            Tag = p.Tag,
            //            Src = srcProp,
            //            Dst = null,
            //            IsValid = isValid
            //        };
            //    });
            //}
            else
            {
                assert.ShouldBeEqual(m => m.Name, o => o.Name);
            }

            if (definition.Id.HasValue)
            {
                assert.ShouldBeEqual(m => m.Id, o => o.Id);
            }
            else
            {
                assert.SkipProperty(m => m.Id, "Id is null. Skipping property.");
            }
        }
    }
}
