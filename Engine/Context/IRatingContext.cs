using Engine.Core;
using Engine.Core.Interfaces;
using Engine.Core.Model;
using Engine.Core.Raters;

namespace Engine.Context
{
    public interface IRatingContext : ILogger
    {
        string LoadPolicyFromFile();
        string LoadPolicyFromURI(string uri);

        Policy GetPolicyFromJsonString(string policyJson);
        Policy GetPolicyFromXmlString(string policyXml);

        Rater CreateRaterForPolicy(Policy policy, IRatingContext context);

        RatingEngine Engine { get; set; }
    }
}
