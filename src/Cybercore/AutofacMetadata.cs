using System;
using System.Collections.Generic;
using Cybercore.Configuration;

namespace Cybercore
{
    public class CoinFamilyAttribute : Attribute
    {
        public CoinFamilyAttribute(IDictionary<string, object> values)
        {
            if(values.ContainsKey(nameof(SupportedFamilies)))
                SupportedFamilies = (CoinFamily[]) values[nameof(SupportedFamilies)];
        }

        public CoinFamilyAttribute(params CoinFamily[] supportedFamilies)
        {
            SupportedFamilies = supportedFamilies;
        }

        public CoinFamily[] SupportedFamilies { get; }
    }
}