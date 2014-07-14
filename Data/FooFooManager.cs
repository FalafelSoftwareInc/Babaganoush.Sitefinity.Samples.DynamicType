using Babaganoush.Sitefinity.Samples.DynamicType.Content.Managers;

namespace Babaganoush.Sitefinity.Samples.DynamicType.Data
{
    public class FooFooManager
    {
        public static SpeakersManager Speakers { get { return SpeakersManager.Instance; } }
    }
}
