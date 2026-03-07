using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace NZWalksV2.API.Models.Domain
{
    public class Region
    {
        public Guid Id {get; set;}
        public string Code {get; set;}
    }
}