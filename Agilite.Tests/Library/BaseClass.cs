using System;
using Agilite.Models;

namespace Agilite.Tests.Library {
    public class BaseClass {
        protected readonly Agilite Agilite;
        protected string Key;
        protected readonly string GroupName;
        protected string RecordId;

        protected BaseClass() {
            Agilite = new Agilite(new AgiliteConfig {
                ApiKey = Constants.ApiKey,
                ApiServerUrl = Constants.ApiServerUrl
            });

            Key = Key ?? Guid.NewGuid().ToString();
            GroupName = GroupName ?? Guid.NewGuid().ToString();
        }
    }
}
