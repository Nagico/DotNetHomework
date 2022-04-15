using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebSpider
{
    public class WebPage : IEquatable<WebPage?>
    {
        public Uri Uri { get; set; }
        public bool IsFinish { get; set; }
        public bool IsSuccess { get; set; }
        public int Depth { get; set; }
        public string Msg { get; set; }

        public WebPage(Uri uri, int depth)
        {
            Uri = uri;
            IsFinish = false;
            IsSuccess = false;
            Depth = depth;
            Msg = "Pending...";
        }

        public override string? ToString()
        {
            return $"{Depth}: {Uri}";
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as WebPage);
        }

        public bool Equals(WebPage? other)
        {
            return other != null &&
                   EqualityComparer<Uri>.Default.Equals(Uri, other.Uri);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Uri);
        }
    }
}
