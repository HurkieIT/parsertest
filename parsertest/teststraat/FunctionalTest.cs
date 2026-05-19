using Newtonsoft.Json;

public static class JsonParserService
{
    public static DiscordExport? DeserializeDiscordExport(string rawJson)
    {
        return JsonConvert.DeserializeObject<DiscordExport>(rawJson);
    }

    public static bool HasMessages(DiscordExport? export)
    {
        return export != null && export.Messages.Count > 0;
    }

    public static string GetAuthorName(DiscordMessage message)
    {
        return message.Author?.Nickname
               ?? message.Author?.Name
               ?? "Onbekende auteur";
    }

    public static string GetContent(DiscordMessage message)
    {
        return string.IsNullOrWhiteSpace(message.Content)
            ? "[Geen tekst]"
            : message.Content;
    }
}