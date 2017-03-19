﻿namespace BlogSystem.Web.Infrastructure
{
    using Ganss.XSS;

    public class HtmlSanitizerAdapter : ISanitizer
    {
        public string Sanitize(string html)
        {
            var sanitizer = new HtmlSanitizer();

            return sanitizer.Sanitize(html);
        }
    }
}