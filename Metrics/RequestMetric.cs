namespace MetricsApp.Metrics;

public record class RequestMetric(string Path, string Method, int? StatusCode, 
    long ElapsedMilliseconds, DateTime Utc);


