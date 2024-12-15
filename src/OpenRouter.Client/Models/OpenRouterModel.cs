namespace OpenRouter.Client.Models;


public class OpenRouterModel
{
    public string? Id { get; set; } // "id": "meta-llama/llama-3.2-11b-vision-instruct",
    public string? Name { get; set; } // "name": "Meta: Llama 3.2 11B Vision Instruct (free)",
    public ulong? Created { get; set; } // "created": 1727222400,
    public string? Description { get; set; } // "description": "Llama 3.2 11B Vision is a multimodal model with 11 billion parameters",
    public int? ContextLength { get; set; } // "context_length": 131072,
    public Architecture? Architecture { get; set; } // "architecture"
    public Pricing? Pricing { get; set; } // "pricing"
    public TopProvider? TopProvider { get; set; } // "top_provider"
    public string? PerRequestLimits { get; set; } // "per_request_limits": null
}


public class Architecture
{
    public string? Modality { get; set; } // "modality": "text+image->text",
    public string? Tokenizer { get; set; } // "tokenizer": "Llama3",
    public string? InstructType { get; set; } // "instruct_type": "llama3"
}


public class Pricing
{
    public double? Prompt { get; set; } // "prompt": "0",
    public double? Completion { get; set; } // "completion": "0",
    public double? Image { get; set; } // "image": "0",
    public double? Request { get; set; } // "request": "0"
}


public class TopProvider
{
    public int? ContextLength { get; set; } // "context_length": 8192,
    public int? MaxCompletionTokens { get; set; } // "max_completion_tokens": 4096,
    public bool? IsModerated { get; set; } // "is_moderated": false
}
