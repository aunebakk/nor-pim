using System;

namespace SolutionNorSolutionPim.BusinessLogicLayer {
    class Program {
        static void Main(string[] args) {
            string returnMessage = string.Empty;

            try {
                DatabaseManager databaseManager = new DatabaseManager("NorSolutionPim", toRemote: false);

                returnMessage = 
                    databaseManager.ExecuteScriptsBetween(
                        databaseManager.minimumVersion,
                        databaseManager.maximumVersion
                        );

            } catch (System.Exception ex) {
                returnMessage = ExtractException(ex);
            }

            Console.WriteLine(returnMessage);

            if (returnMessage.IndexOf("Exception") > 0)
                Console.ReadKey();
        }

        private static string ExtractException(Exception ex) {
            try {
                return (ex?.Message + "\r\n" + "\r\n"
                + ex.InnerException?.Message + "\r\n" + "\r\n"
                + ex.InnerException?.InnerException?.Message + "\r\n" + "\r\n"
                + ex.InnerException?.InnerException?.InnerException?.Message + "\r\n" + "\r\n"
                + ex.InnerException?.InnerException?.InnerException?.InnerException?.Message + "\r\n" + "\r\n"
                );

            } catch (Exception ex2) {
                return "Failed to extract exception;" + ex2.Message;
            }
        }

    }
}
