using System.Activities.Presentation.Metadata;
using System.ComponentModel;


namespace Handl.Handl.Activities.Design
{

    public class DesignerMetadata : IRegisterMetadata
    {

        public void Register()

        {

            AttributeTableBuilder attributeTableBuilder = new AttributeTableBuilder();
            attributeTableBuilder.AddCustomAttributes(typeof(Handl), new DesignerAttribute(typeof(HandlDesigner)));
            MetadataStore.AddAttributeTable(attributeTableBuilder.CreateTable());

        }

    }

}
