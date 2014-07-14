using Babaganoush.Sitefinity.Extensions;
using Babaganoush.Sitefinity.Models;
using System.Collections.Generic;
using Telerik.Sitefinity.DynamicModules.Model;
using Telerik.Sitefinity.Model;
using Telerik.Sitefinity.RelatedData;

namespace Babaganoush.Sitefinity.Samples.DynamicType.Models
{
    public class SpeakerModel : DynamicModel
    {
        public string Email { get; set; }
        public string Bio { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Company { get; set; }
        public string Position { get; set; }
        public string Twitter { get; set; }
        public string Website { get; set; }
        public ImageModel Photo { get; set; }
        public List<TaxonModel> Categories { get; set; }
        public List<TaxonModel> Tags { get; set; }

        /// <summary>
        /// Gets the name of the dynamic type.
        /// </summary>
        /// <value>
        /// The name of the dynamic type.
        /// </value>
        public override string MappedType 
        {
            get
            {
                return "Telerik.Sitefinity.DynamicTypes.Model.Speakers.Speaker";
            }
        }

        public SpeakerModel()
            : base()
        {
            Categories = new List<TaxonModel>();
            Tags = new List<TaxonModel>();
        }

        public SpeakerModel(DynamicContent sfContent)
            : base(sfContent)
        {
            if (sfContent != null)
            {
                //SET CUSTOM PROPERTIES
                if (sfContent.DoesFieldExist("Email"))
                    Email = sfContent.GetValue<Lstring>("Email").Value;

                if (sfContent.DoesFieldExist("Bio"))
                    Bio = sfContent.GetValue<Lstring>("Bio").Value;

                if (sfContent.DoesFieldExist("FirstName"))
                    FirstName = sfContent.GetValue<Lstring>("FirstName").Value;

                if (sfContent.DoesFieldExist("LastName"))
                    LastName = sfContent.GetValue<Lstring>("LastName").Value;

                if (sfContent.DoesFieldExist("Company"))
                    Company = sfContent.GetValue<Lstring>("Company").Value;

                if (sfContent.DoesFieldExist("Position"))
                    Position = sfContent.GetValue<Lstring>("Position").Value;

                if (sfContent.DoesFieldExist("Twitter"))
                    Twitter = sfContent.GetValue<Lstring>("Twitter").Value;

                if (sfContent.DoesFieldExist("Website"))
                    Website = sfContent.GetValue<Lstring>("Website").Value;

                if (sfContent.DoesFieldExist("Photo"))
                    Photo = sfContent.GetImage("Photo");

                Categories = sfContent.GetTaxa("Category");

                Tags = sfContent.GetTaxa("Tags");
            }
        }

        public override DynamicContent ToSitefinityModel()
        {
            //GET CONTRUCTED CONTENT FROM BASE
            var sfContent = base.ToSitefinityModel();

            //POPULATE MORE FIELDS IF APPLICABLE
            if (sfContent != null)
            {
                //MERGE CUSTOM PROPERTIES
                sfContent.TrySetValue("Email", Email);
                sfContent.TrySetValue("Bio", Bio);
                sfContent.TrySetValue("FirstName", FirstName);
                sfContent.TrySetValue("LastName", LastName);
                sfContent.TrySetValue("Company", Company);
                sfContent.TrySetValue("Position", Position);
                sfContent.TrySetValue("Twitter", Twitter);
                sfContent.TrySetValue("Website", Website);
                sfContent.SetRelation("Photo", Photo);
                sfContent.SetTaxa("Category", Categories);
                sfContent.SetTaxa("Tags", Tags);
            }

            //RETURN SITEFINITY MODEL
            return sfContent;
        }
    }
}
