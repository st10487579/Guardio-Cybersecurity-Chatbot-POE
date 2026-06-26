using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GuardioChatbot.Services
{
    public static class ActivityLogger
    {
        private static List<string> activities =
            new List<string>();

        public static void Log(string action)
        {
            activities.Add(
                $"[{DateTime.Now:HH:mm:ss}] {action}");
        }

        public static List<string> GetRecentActivities()
        {
            return activities
                .Skip(Math.Max(0, activities.Count - 10))
                .ToList();
        }

        public static List<string> GetAllActivities()
        {
            return activities;
        }
    }
}