using System.Activities.Presentation.Metadata;
using System.ComponentModel;


namespace Handl.UiPath.Activities.Design
{

    public class DesignerMetadata : IRegisterMetadata
    {

        public void Register()

        {

            AttributeTableBuilder attributeTableBuilder = new AttributeTableBuilder();
            attributeTableBuilder.AddCustomAttributes(typeof(Handl.UiPath.Activities.Docr), new DesignerAttribute(typeof(HandlDesigner)));
            MetadataStore.AddAttributeTable(attributeTableBuilder.CreateTable());

        }

    }

}
