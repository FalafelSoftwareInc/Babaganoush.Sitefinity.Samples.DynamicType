using Babaganoush.Sitefinity.WebApi.Api.Abstracts;
using Babaganoush.Sitefinity.Samples.DynamicType.Data;
using Babaganoush.Sitefinity.Samples.DynamicType.Models;

namespace Babaganoush.Sitefinity.Samples.DynamicType.Api
{
    public class SpeakersController : BaseDynamicController<SpeakerModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SpeakersController" /> class.
        /// </summary>
        public SpeakersController()
            : base(FooFooManager.Speakers)
        {

        }
    }
}
