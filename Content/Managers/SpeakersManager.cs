using Babaganoush.Sitefinity.Content.Managers.Abstracts;
using Babaganoush.Sitefinity.Samples.DynamicType.Models;
using Telerik.Sitefinity.DynamicModules.Model;

namespace Babaganoush.Sitefinity.Samples.DynamicType.Content.Managers
{
    public class SpeakersManager : DynamicModuleManager<SpeakersManager, SpeakerModel>
    {
        /// <summary>
        /// Creates the Baba instance from the Sitefinity object.
        /// </summary>
        /// <param name="sfContent">Content of the sf.</param>
        /// <returns></returns>
        protected override SpeakerModel CreateInstance(DynamicContent sfContent)
        {
            return new SpeakerModel(sfContent);
        }
    }
}
