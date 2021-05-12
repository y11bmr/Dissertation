﻿using Microsoft.AspNetCore.Razor.TagHelpers;

// AMC - a simple tag helper to display content based on condition
namespace PPS.Web.TagHelpers
{
    [HtmlTargetElement(Attributes = "asp-condition")]
    public class ConditionTagHelper : TagHelper
    {
        [HtmlAttributeName("asp-condition")]
        public bool Condition { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (!Condition)
            {
                output.SuppressOutput();
            }
        }
    }
}

