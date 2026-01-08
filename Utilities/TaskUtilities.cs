namespace CapuchinModManager.Utilities
{
    public static class TaskUtilities
    {
        public static void ReportCurrentTask(string taskName, int step, int startingStep, int totalSteps)
        {
            var percentage = (step * 100) / totalSteps;
            Main.Instance.TaskLabelText = $"{taskName} ({percentage}%)";
            Main.Instance.TaskProgressBar(step, startingStep, totalSteps);
        }

        public static void ReportCurrentTask(string taskName, int step, int totalSteps) =>
            ReportCurrentTask(taskName, step, 0, totalSteps);
    }
}
