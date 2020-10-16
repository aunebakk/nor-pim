using System;

namespace SolutionNorSolutionPim.BusinessLogicLayer {
    internal class Program {

        /// <summary>
        /// Execute all scripts, echo outcome to console
        /// </summary>
        private static void Main(string[] args) {
            string returnMessage = string.Empty;

            try {
                DatabaseManager databaseManager = new DatabaseManager("NorSolutionPim", toRemote: false);

                returnMessage =
                    databaseManager.ExecuteScriptsBetween(
                        databaseManager.minimumVersion,
                        databaseManager.maximumVersion,
                        breakOnCreationCheckmark: true
                        );

            } catch (System.Exception ex) {
                returnMessage = ExtractException(ex);
            }

            Console.WriteLine(returnMessage);

            if (returnMessage.IndexOf("Exception") > 0) {
                Console.ReadKey();
            }
        }

        /// <summary>
        /// Extract Exception information as string
        /// </summary>
        /// <returns>String with error information</returns>
        private static string ExtractException(Exception ex) {
            try {
                string error = string.Empty;

                Exception realerror = ex;
                do {
                    error += realerror?.Message + "\r\n" + "\r\n";
                    realerror = realerror.InnerException;
                } while (realerror != null);

                return error;
            } catch (Exception ex2) {
                return "Failed to extract exception;" + ex2.Message;
            }
        }
    }

}
