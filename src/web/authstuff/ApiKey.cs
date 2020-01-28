using System;
using System.Collections.Generic;

namespace TestUploadFileWebApi.authstuff
{
    public class ApiKey
    {
        public ApiKey(int id, string owner, string key, DateTime created, IList<string> roles)
        {
            Id = id;
            Owner = owner ?? throw new ArgumentNullException(nameof(owner));
            Key = key ?? throw new ArgumentNullException(nameof(key));
            Created = created;
            Roles = roles ?? throw new ArgumentNullException(nameof(roles));
        }

        public int Id { get; }
        public string Owner { get; }
        public string Key { get; }
        public DateTime Created { get; }
        public IList<string> Roles { get; }
    }
}