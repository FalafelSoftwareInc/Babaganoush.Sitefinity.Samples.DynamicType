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

        /// <summary>
        /// Query if this user is authenticated. This will apply across all web services.
        /// </summary>
        ///
        /// <returns>
        /// true if authenticated, false if not.
        /// </returns>
        //public override bool IsAuthenticated()
        //{
        //    return SecurityManager.IsBackendUser();
        //}
    }
}
