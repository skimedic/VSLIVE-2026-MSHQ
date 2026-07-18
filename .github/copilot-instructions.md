# Copilot Instructions

## Project Guidelines
- Entity Framework C# coding standard for collection navigation properties: ALWAYS use ICollection<T> (not IEnumerable<T>) for collection navigation properties and ALWAYS initialize them to new List<T>(). This is specified in the csharp.instructions.md file under "Entity Framework Guidance".
- For EF Core models in this repo, use [MaxLength] instead of [StringLength] for maximum length attributes, per csharp.instructions.md.
- In this repo, do not initialize properties (including string properties) unless explicitly instructed; follow csharp.instructions.md.

## Razor Pages Guidelines
- For this Razor Pages lab, only page handlers that call data services should be converted to async; the Makes Create OnGet handler should remain synchronous because it does not call a data service.

## Prompt File Guidelines
- When fixing wording in prompt files, preserve full instructional sentences and only adjust the target phrase.
- When correcting repeated-word typos like 'the the', keep the full surrounding sentence intact instead of replacing with a fragment.