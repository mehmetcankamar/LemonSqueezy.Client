using System.Text.Json.Serialization;

namespace LemonSqueezy.Client.Models.Abstractions
{
    public class ApiResponse<TData>
    {
        [JsonPropertyName("data")]
        public TData Data { get; set; } = default!;
    }

    public class ApiResponseList<TData>
    {
        [JsonPropertyName("data")]
        public TData[] Data { get; set; } = default!;

        [JsonPropertyName("meta")]
        public Meta Meta { get; set; } = default!;

        [JsonPropertyName("links")]
        public Links Links { get; set; } = default!;
    }

    public class Links
    {
        [JsonPropertyName("first")]
        public string? First { get; set; }

        [JsonPropertyName("last")]
        public string? Last { get; set; }

        [JsonPropertyName("prev")]
        public string? Prev { get; set; }

        [JsonPropertyName("next")]
        public string? Next { get; set; }
    }

    public class Meta
    {
        [JsonPropertyName("page")]
        public Page Page { get; set; } = default!;
    }

    public class Page
    {
        [JsonPropertyName("currentPage")]
        public int CurrentPage { get; set; }

        [JsonPropertyName("from")]
        public int From { get; set; }

        [JsonPropertyName("lastPage")]
        public int LastPage { get; set; }

        [JsonPropertyName("perPage")]
        public int PerPage { get; set; }

        [JsonPropertyName("to")]
        public int To { get; set; }

        [JsonPropertyName("total")]
        public int Total { get; set; }
    }
}
