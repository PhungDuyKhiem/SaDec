﻿using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace Sadec.Sample.Localization
{
    public static class SampleLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(SampleConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(SampleLocalizationConfigurer).GetAssembly(),
                        "Sadec.Sample.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
