public class WebhookDeleter {
    public static void DeleteWebhook(string webhookUrl) {
        using (var client = new HttpClient()) {
            var request = new HttpRequestMessage(HttpMethod.Delete, webhookUrl);

            var response = client.SendAsync(request).Result;

            if (response.IsSuccessStatusCode) {
                Console.WriteLine("Webhook successfully deleted.");
            } else {
                Console.WriteLine("Failed to delete webhook.");
            }
        }
    }

    public static void Main(string[] args) {
        Console.Write("Enter the webhook URL to delete: ");
        string webhookUrl = Console.ReadLine();
        Console.Write("\n");
        DeleteWebhook(webhookUrl);
        Console.WriteLine("\nPress any Key to exit...");
        Console.ReadKey();
    }
}
