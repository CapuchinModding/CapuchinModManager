namespace CapuchinModManager.Utilities
{
    public static class TaskUtilities
    {
        public static void ReportCurrentTask(string taskName, int step, int startingStep, int totalSteps)
        {
            var percentage = (step * 100) / totalSteps;
            Main.Instance.taskLabel.Text = $"{taskName} ({percentage}%)";

            Main.Instance.taskProgress.Maximum = totalSteps;
            Main.Instance.taskProgress.Minimum = startingStep;
            Main.Instance.taskProgress.Step = step;
        }

        public static void ReportCurrentTask(string taskName, int step, int totalSteps) =>
            ReportCurrentTask(taskName, step, 0, totalSteps);
    }
}
