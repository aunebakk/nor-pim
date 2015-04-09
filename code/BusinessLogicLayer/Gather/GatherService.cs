using System;
using System.Diagnostics;
using System.IO;
using System.ServiceModel;
using norpim.DataAccessLayer;

namespace norpim.BusinessLogicLayer {

    [ServiceContract()]
    public interface IGatherService {
        [OperationContract()]
        void Start(Guid userId);
    }

    /// <domain>Gather</domain>
    /// <namespace>norpim.BusinessLogicLayer.Other</namespace>
    public class GatherService : IGatherService {

        public void Start(Guid userId) {
            Stream stream = null;
            StreamReader streamReader = null;

            try { 
                // read file
                stream = File.Open(@"C:\Development\norpim\data\gather\JavaScripArrayComplete.txt", FileMode.Open);
                streamReader = new StreamReader(stream, System.Text.Encoding.UTF7); 

                // read the whole file
                string line = streamReader.ReadToEnd();

                // split it into child segments
                string splitOn = "\"text\":";
                string[] segments = line.Split(new string[] {splitOn}, StringSplitOptions.None);
                string parentNumber = string.Empty;
                string previousParentNumber = string.Empty;
                int position = 0;

                foreach (string segment in segments) { 

                    if (segment == "[{")
                        continue;

                    string elementText = getElement(splitOn + segment, "text");
                    string elementNumber = getElement(segment, "number").Trim();
                    string elementId = getElement(segment, "id");   // not used
                    string elementProd = getElement(segment, "prod");   // not used
                    string elementChildren = getElement(segment, "children"); // used... somewhat

                    Debug.WriteLine(parentNumber.Trim() + "/" + elementNumber + ":" + elementText.Trim());

                    // get this into the a category structure
                    
                    // does code exist
                    var category = new CrudeProductCategoryData();
                    category.GetByProductCategoryCode(  elementNumber
                                                        );  

                    if (category.ProductCategoryId != Guid.Empty) { 
                        // found it, check for changes
                    } else {
                        // not found

                        // find parent
                        var categoryParent = new CrudeProductCategoryData();
                        categoryParent.GetByProductCategoryCode(parentNumber);

                        // add it
                        var c = category; {
                            c.ProductCategoryId = Guid.NewGuid();
                            
                            // resolve parent
                            if (categoryParent.ProductCategoryId != Guid.Empty)
                                c.ProductCategoryParentId = categoryParent.ProductCategoryId;
                            else
                                c.ProductCategoryParentId = c.ProductCategoryId;    // first level points back to itself as parent

                            c.ProductCategoryCode = elementNumber.Trim();
                            c.ProductCategoryName = elementText;

                            position++; // this is lame, but sufficient for now
                            c.ProductCategoryPosition = position; 

                            c.StateRcd = StateRef.Created;
                            
                            c.UserId = userId;
                            c.DateTime = DateTime.UtcNow;
                            c.Insert();
                        }
                    }

                    if (elementChildren == "[{") {
                        previousParentNumber = parentNumber;
                        parentNumber = elementNumber;
                    } else if (segment.Contains("}]}]},{")) {
                        previousParentNumber = string.Empty;
                        parentNumber = string.Empty;
                    } else if (segment.Contains("}]},{")) {
                        parentNumber = previousParentNumber;
                        previousParentNumber = string.Empty;
                    }
                }

            } catch {
                throw;
            } finally {
                // close StreamWriter & Stream
                if (streamReader != null) streamReader.Close();
                if (stream != null) stream.Close();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="javaArrayPart"></param>
        /// <param name="elementName"></param>
        /// <returns>the value ( 0 if int ), or empty string</returns>
        private string getElement(  string javaArrayPart,
                                    string elementName
                                    ) {
            string javaElement = "\"" + elementName + "\":";
            int elementStart = javaArrayPart.IndexOf(javaElement);
            
            // check for end of array 
            if (javaArrayPart.Length <= elementStart + javaElement.Length)
                return string.Empty;

            string afterElement = javaArrayPart.Substring(elementStart + javaElement.Length);

            // afterElement is string, zero or empty
            if (afterElement[0] == '"')
                return afterElement.Substring(1, afterElement.IndexOf("\",")-1);

            if (afterElement[0] == '0')
                return "0";

            return afterElement;
        }
    }
}
