namespace AbTestMaster.Services
{
    internal class Constants
    {
        internal const string AB_TEST_MASTER_SESSION = "AB_SESSION";
        internal const string AB_TEST_MASTER_COOKIE = "AB_COOKIE";

        internal const string ACTION = "action";
        internal const string CONTROLLER = "controller";
        internal const string AREA = "area";

        internal const string SPLIT_GROUP = "GROUP";
        internal const string SPLIT_NAME = "NAME";
        internal const string SPLIT_SEQUENCE = "SEQUENCE";
        internal const string SPLIT_VIEWS_SEQUENCE_TRAIL = "SEQUENCE_TRAIL";
        internal const string SPLIT_GOAL = "GOAL";

        internal const string DATE_TIME = "DATE_TIME";
        internal const string SPLIT_GOALS_FILE_PATH = @"\App_Data\AB_TEST_MASTER_SplitGoals.csv";
        internal const string SPLIT_VIEWS_FILE_PATH = @"\App_Data\AB_TEST_MASTER_SplitViews.csv";
    }
}
