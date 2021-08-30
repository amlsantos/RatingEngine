﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Policies;

namespace Engine.Serializer
{
    public class JsonPolicySerializer
    {
        public Policy GetPolicyFromJsonString(string jsonString)
        {
            return JsonConvert.DeserializeObject<Policy>(jsonString, new StringEnumConverter());
        }
    }
}