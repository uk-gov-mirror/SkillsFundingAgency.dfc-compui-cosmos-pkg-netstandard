﻿using DFC.Compui.Cosmos.Attributes;
using DFC.Compui.Cosmos.Contracts;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DFC.Compui.Cosmos.Models
{
    public class ContentPageModel : DocumentModel, IContentPageModel
    {
        [Required]
        [JsonProperty(Order = -10)]
        public override string? PartitionKey { get; set; } = "unknown-value";

        [Required]
        [LowerCase]
        [UrlPath]
        [JsonProperty(Order = -10)]
        public string? CanonicalName { get; set; }

        [UrlPath]
        [LowerCase]
        [JsonProperty(Order = -10)]
        public IList<string>? AlternativeNames { get; set; }

        [Obsolete("May be removed once Service Bus and Message Function app removed from solution")]
        [JsonProperty(Order = -10)]
        public long SequenceNumber { get; set; }

        [Required]
        [JsonProperty(Order = -10)]
        public Guid? Version { get; set; }

        [Required]
        [Display(Name = "Breadcrumb Title")]
        public string? BreadcrumbTitle { get; set; }

        [Display(Name = "Include In SiteMap")]
        public bool IncludeInSitemap { get; set; }

        [Required]
        [UrlPath]
        public Uri? Url { get; set; }

        public MetaTagsModel MetaTags { get; set; } = new MetaTagsModel();

        [Required]
        public string? Content { get; set; }

        [Required]
        [Display(Name = "Last Reviewed")]
        public DateTime LastReviewed { get; set; }
    }
}
