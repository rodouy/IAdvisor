using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IrrigationAdvisor.Models.Utilities;
using IrrigationAdvisor.Models.Management;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace IrrigationAdvisor.Tests.Models.Utilities
{
    [TestClass]
    public class OutputFileCSVTest
    {
        [TestMethod]
        public void WriteFileTest()
        {
            String lCompareTextFromFile;
            String lCompareText;

            String lFileName = "CSVTestFile";
            String lFilePath;
            String lFolderName;
            String lDataSplit;

            List<Title> lTitles;
            List<Message> lMessages;

            String lMethod;
            String lDescription;
            String lTime;

            OutputFileCSV lOutputFile;

            String lDate = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString();
            String lFile_Extention = ".csv";

            //Create the titles and messages to put into the file
            lTitles = new List<Title>();
            lTitles.Add(new Title(1, 0, false, "Number", "Number digit", "Nr"));
            lTitles.Add(new Title(2, 0, false, "Name", "Number name", "Na"));

            lMessages = new List<Message>();

            //MessageId, TitleId, LineId, CropIrrigationWeatherId, Daily, Data
            lMessages.Add(new Message(1, 1, 1, 0, false, "1"));
            lMessages.Add(new Message(2, 2, 1, 0, false, "Uno"));

            lMessages.Add(new Message(3, 1, 2, 0, false, "2"));
            lMessages.Add(new Message(4, 2, 2, 0, false, "Dos"));

            lMessages.Add(new Message(5, 1, 3, 0, false, "3"));
            lMessages.Add(new Message(6, 2, 3, 0, false, "Tres"));

            

            //Information about the file output
            lMethod = "WriteFileTest";
            lDescription = "Do the unit Test for this class";
            lTime = System.DateTime.Now.ToString();

            //create the file
            lOutputFile = new OutputFileCSV(lFileName);
            lFolderName = lOutputFile.FolderName;
            lFilePath = lOutputFile.FilePath;
            lDataSplit = lOutputFile.DataSplit;

            //Output of file information
            lOutputFile.FileHeader = "File Header information";
            lOutputFile.FileTitles = lTitles;
            lOutputFile.FileMessages = lMessages;
            lOutputFile.FileFooter = "File Footer information";


            lOutputFile.WriteFile(lMethod, lDescription, lTime);


            lCompareText = ((((lTime + " - ") + lFileName + lDate + lFile_Extention + " - ") + lMethod + " - ") + lDescription + lDataSplit);
            lCompareText += "\r\n";
            lCompareText += lOutputFile.FileHeader;
            lCompareText += "\r\n";
            lCompareText += lOutputFile.GetTitles();
            lCompareText += "\r\n";
            for (int i = 0; i < lOutputFile.FileMessages.Count; i++)
            {
                lCompareText += lOutputFile.GetLineOfMessages(i);
                lCompareText += "\r\n";
            }
            lCompareText += lOutputFile.FileFooter;
            lCompareText += "\r\n";
            lCompareText += "---------------------------------------- " + lDataSplit;
            lCompareText += "\r\n";

            lCompareTextFromFile = lOutputFile.ReadFile();
            try
            {
                MatchCollection words1 = Regex.Matches(lCompareText, @"\b(\w+)\b");
                MatchCollection words2 = Regex.Matches(lCompareTextFromFile, @"\b(\w+)\b");

                var hs1 = new HashSet<string>(words1.Cast<Match>().Select(m => m.Value));
                var hs2 = new HashSet<string>(words2.Cast<Match>().Select(m => m.Value));

                // Optionaly you can use a custom comparer for the words.
                // var hs2 = new HashSet<string>(words2.Cast<Match>().Select(m => m.Value), new MyComparer());

                // h2 contains after this operation only 'very' and 'Joe'
                hs2.ExceptWith(hs1); 

                if(String.Equals(lCompareText, lCompareTextFromFile))
                {
                    Assert.AreEqual(lCompareText, lCompareTextFromFile, true);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in OutputFileCSVTest.WriteFileTest " + ex.Message);
                //TODO manage and log the exception WriteFileTest
                throw ;
            }
            
        }
    }
}
