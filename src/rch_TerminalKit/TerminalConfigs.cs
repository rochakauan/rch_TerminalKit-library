namespace rch_TerminalKit
{
    /// <summary>
    /// Contains global configuration settings for <see cref="ConsoleUtils"/>.
    /// These settings can be changed at runtime to affect terminal behavior.
    /// </summary>
    public static class TerminalConfig
    {
        /// <summary>
        /// The default text color used for messages.
        /// </summary>
        public static ConsoleColor DefaultMessageColor { get; set; } = ConsoleColor.White;

        /// <summary>
        /// The default text color used for prompts.
        /// </summary>
        public static ConsoleColor DefaultPromptColor { get; set; } = ConsoleColor.DarkYellow;

        /// <summary>
        /// The default text color used for pause messages.
        /// </summary>
        public static ConsoleColor DefaultPauseColor { get; set; } = ConsoleColor.DarkGray;

        /// <summary>
        /// The default text color used for termination messages.
        /// </summary>
        public static ConsoleColor DefaultKillColor { get; set; } = ConsoleColor.DarkRed;

        /// <summary>
        /// Determines whether to clear the console before displaying any message.
        /// </summary>
        public static bool EnableClearBeforeMessages { get; set; } = false;

        /// <summary>
        /// The default delay in milliseconds before terminating the program.
        /// </summary>
        public static int DefaultKillDelay { get; set; } = 900;

        /// <summary>
        /// Skips program pauses when set to true. Useful for automated testing.
        /// </summary>
        public static bool SkipPause { get; set; } = false;

        /// <summary>
        /// Skips program termination when set to true. Useful for debugging.
        /// </summary>
        public static bool SkipKill { get; set; } = false;

        /// <summary>
        /// The symbol displayed in prompts before reading user input.
        /// </summary>
        public static string ShowPromptSymbol { get; set; } = TerminalDefaults.PromptSymbol;

        /// <summary>
        ///  Optional: method to reset all defaults back to original values
        /// </summary>
        public static void ResetDefaults()
        {
            DefaultMessageColor = ConsoleColor.White;
            DefaultPromptColor = ConsoleColor.DarkYellow;
            DefaultPauseColor = ConsoleColor.DarkGray;
            DefaultKillColor = ConsoleColor.DarkRed;
            DefaultKillDelay = 900;
            EnableClearBeforeMessages = false;
            SkipPause = false;
            SkipKill = false;
            ShowPromptSymbol = TerminalDefaults.PromptSymbol;
        }
    }
}
