using GitHub.Services.WebApi;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace GitHub.DistributedTask.WebApi
{
    public class Runner
    {
        /// <summary>
        /// Name of the agent
        /// </summary>
        [JsonProperty("name")]
        public string Name
        {
            get;
            internal set;
        }

    }
}
