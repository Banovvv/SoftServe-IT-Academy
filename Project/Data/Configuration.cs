namespace SoftServe_IT_Academy.Project.Data
{
    internal static class Configuration
    {
        internal static string GetConnectionString()
        {
            // Change 'SportHub' for a different database name
            return @"Server=.\SQLEXPRESS;Database=SportHub;Integrated Security=true;";
        }
    }
}
