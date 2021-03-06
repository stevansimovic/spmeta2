using System;
using SPMeta2.CSOM.ModelHandlers;
using SPMeta2.CSOM.ModelHosts;
using SPMeta2.Definitions.Base;
using SPMeta2.Enumerations;
using SPMeta2.Standard.Definitions.Webparts;
using SPMeta2.Utils;

namespace SPMeta2.CSOM.Standard.ModelHandlers.Webparts
{
    public class AdvancedSearchBoxModelHandler : WebPartModelHandler
    {
        #region constructors

        public AdvancedSearchBoxModelHandler()
        {
            ShouldUseWebPartStoreKeyForWikiPage = true;
        }

        #endregion

        #region properties

        public override Type TargetType
        {
            get { return typeof(AdvancedSearchBoxDefinition); }
        }

        #endregion

        #region methods

        protected override string GetWebpartXmlDefinition(ListItemModelHost listItemModelHost, WebPartDefinitionBase webPartModel)
        {
            var typedModel = webPartModel.WithAssertAndCast<AdvancedSearchBoxDefinition>("model", value => value.RequireNotNull());
            var wpXml = WebpartXmlExtensions
                .LoadWebpartXmlDocument(BuiltInWebPartTemplates.AdvancedSearchBox);

            if (!string.IsNullOrEmpty(typedModel.AndQueryTextBoxLabelText))
                wpXml.SetOrUpdateAdvancedSearchBoxWebPartProperty("AndQueryTextBoxLabelText", typedModel.AndQueryTextBoxLabelText);

            if (!string.IsNullOrEmpty(typedModel.DisplayGroup))
                wpXml.SetOrUpdateAdvancedSearchBoxWebPartProperty("DisplayGroup", typedModel.DisplayGroup);

            if (!string.IsNullOrEmpty(typedModel.LanguagesLabelText))
                wpXml.SetOrUpdateAdvancedSearchBoxWebPartProperty("LanguagesLabelText", typedModel.LanguagesLabelText);

            if (!string.IsNullOrEmpty(typedModel.NotQueryTextBoxLabelText))
                wpXml.SetOrUpdateAdvancedSearchBoxWebPartProperty("NotQueryTextBoxLabelText", typedModel.NotQueryTextBoxLabelText);

            if (!string.IsNullOrEmpty(typedModel.OrQueryTextBoxLabelText))
                wpXml.SetOrUpdateAdvancedSearchBoxWebPartProperty("OrQueryTextBoxLabelText", typedModel.OrQueryTextBoxLabelText);

            if (!string.IsNullOrEmpty(typedModel.PhraseQueryTextBoxLabelText))
                wpXml.SetOrUpdateAdvancedSearchBoxWebPartProperty("PhraseQueryTextBoxLabelText", typedModel.PhraseQueryTextBoxLabelText);

            if (!string.IsNullOrEmpty(typedModel.AdvancedSearchBoxProperties))
                wpXml.SetOrUpdateAdvancedSearchBoxWebPartProperty("Properties", typedModel.AdvancedSearchBoxProperties);

            if (!string.IsNullOrEmpty(typedModel.PropertiesSectionLabelText))
                wpXml.SetOrUpdateAdvancedSearchBoxWebPartProperty("PropertiesSectionLabelText", typedModel.PropertiesSectionLabelText);

            if (!string.IsNullOrEmpty(typedModel.ResultTypeLabelText))
                wpXml.SetOrUpdateAdvancedSearchBoxWebPartProperty("ResultTypeLabelText", typedModel.ResultTypeLabelText);

            if (!string.IsNullOrEmpty(typedModel.ScopeLabelText))
                wpXml.SetOrUpdateAdvancedSearchBoxWebPartProperty("ScopeLabelText", typedModel.ScopeLabelText);

            if (!string.IsNullOrEmpty(typedModel.ScopeSectionLabelText))
                wpXml.SetOrUpdateAdvancedSearchBoxWebPartProperty("ScopeSectionLabelText", typedModel.ScopeSectionLabelText);

            if (!string.IsNullOrEmpty(typedModel.SearchResultPageURL))
                wpXml.SetOrUpdateAdvancedSearchBoxWebPartProperty("SearchResultPageURL", typedModel.SearchResultPageURL);

            if (typedModel.ShowAndQueryTextBox.HasValue)
                wpXml.SetOrUpdateAdvancedSearchBoxWebPartProperty("ShowAndQueryTextBox", typedModel.ShowAndQueryTextBox.Value.ToString().ToLower());

            if (typedModel.ShowLanguageOptions.HasValue)
                wpXml.SetOrUpdateAdvancedSearchBoxWebPartProperty("ShowLanguageOptions", typedModel.ShowLanguageOptions.Value.ToString().ToLower());

            if (typedModel.ShowNotQueryTextBox.HasValue)
                wpXml.SetOrUpdateAdvancedSearchBoxWebPartProperty("ShowNotQueryTextBox", typedModel.ShowNotQueryTextBox.Value.ToString().ToLower());

            if (typedModel.ShowOrQueryTextBox.HasValue)
                wpXml.SetOrUpdateAdvancedSearchBoxWebPartProperty("ShowOrQueryTextBox", typedModel.ShowOrQueryTextBox.Value.ToString().ToLower());

            if (typedModel.ShowPhraseQueryTextBox.HasValue)
                wpXml.SetOrUpdateAdvancedSearchBoxWebPartProperty("ShowPhraseQueryTextBox", typedModel.ShowPhraseQueryTextBox.Value.ToString().ToLower());

            if (typedModel.ShowPropertiesSection.HasValue)
                wpXml.SetOrUpdateAdvancedSearchBoxWebPartProperty("ShowPropertiesSection", typedModel.ShowPropertiesSection.Value.ToString().ToLower());

            if (typedModel.ShowResultTypePicker.HasValue)
                wpXml.SetOrUpdateAdvancedSearchBoxWebPartProperty("ShowResultTypePicker", typedModel.ShowResultTypePicker.Value.ToString().ToLower());

            if (typedModel.ShowScopes.HasValue)
                wpXml.SetOrUpdateAdvancedSearchBoxWebPartProperty("ShowScopes", typedModel.ShowScopes.Value.ToString().ToLower());

            if (!string.IsNullOrEmpty(typedModel.TextQuerySectionLabelText))
                wpXml.SetOrUpdateAdvancedSearchBoxWebPartProperty("TextQuerySectionLabelText", typedModel.TextQuerySectionLabelText);

            return wpXml.ToString();
        }

        #endregion
    }
}
