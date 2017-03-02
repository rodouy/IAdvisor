using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.IO;
using System.Text;
using System.Windows.Forms;
using NLog;

namespace IrrigationAdvisor.Models.Utilities
{
    /// <summary>
    /// Create: 2014-10-26
    /// Author: rodouy 
    /// Description: 
    ///     Class to write a log file defined by constants
    ///     FOLDER_NAME = "C:\\TextLog\\"
    ///     FILE_EXTENTION = ".txt"
    ///     FILE_NAME = "LogTextFile"
    ///     
    /// References:
    ///     list of classes this class use
    ///     
    /// Dependencies:
    ///     list of classes is referenced by this class
    /// 
    /// TODO: OK
    ///     UnitTest
    ///     
    /// -----------------------------------------------------------------
    /// Fields of Class:
    ///     - fileName String
    ///     - filePath String
    /// 
    /// Methods:
    ///     - TextFileLogger()      -- constructor
    ///     - WriteLogFile(FileName, MethodName, Message, Time)     -- method to write the log file
    ///     - ReadLogFile()         -- method to read the log file, return string
    /// 
    /// </summary>
    public class TextFileLogger
    {

        #region Consts
        private const String FOLDER_NAME = "C:\\TextLog\\";
        private const String FILE_EXTENTION = ".txt";
        private const String FILE_NAME = "LogTextFile";
        
        #endregion

        #region Fields
        private String fileName;
        private String filePath;

        private static Logger logger = LogManager.GetCurrentClassLogger();

        #endregion

        #region Properties
        public String FileName
        {
            get { return fileName; }
            set { fileName = value; }
        }

        public String FilePath
        {
            get { return filePath; }
            set { filePath = value; }
        }


        private static String ConfigFilePath
        {
            get 
            {
                String lFilePath = "";
                lFilePath = Application.UserAppDataPath + FILE_NAME + FILE_EXTENTION;
                lFilePath = Environment.ExpandEnvironmentVariables(FOLDER_NAME + FILE_NAME + FILE_EXTENTION);
                return  lFilePath;
            }
        }

        private String GetFilePath()
        { 
            String lFilePath = "";
            if (String.IsNullOrEmpty(this.FileName))
            {
                lFilePath = Environment.ExpandEnvironmentVariables(FOLDER_NAME + FILE_NAME + FILE_EXTENTION);
            }
            else
            {
                lFilePath = Environment.ExpandEnvironmentVariables(FOLDER_NAME + this.FileName + FILE_EXTENTION);
            }
            return  lFilePath;
        }

        #endregion

        #region Construction
        public TextFileLogger()
        {
            if (!Directory.Exists(FOLDER_NAME))
            {
                Directory.CreateDirectory(FOLDER_NAME);
            }

            if (File.Exists(ConfigFilePath))
            {
                
                File.Delete(ConfigFilePath);
            }

            if (!String.IsNullOrEmpty(this.FilePath) && File.Exists(this.FilePath))
            {
                File.Delete(this.FilePath);
            }
        }

        #endregion

        #region Private Helpers
        #endregion

        #region Public Methods

        /// <summary>
        /// Write a log file, with some information:
        ///  - method name
        ///  - a message
        ///  - time
        /// </summary>
        /// <param name="pFileName"></param>
        /// <param name="pMethodName"></param>
        /// <param name="pMessage"></param>
        /// <param name="pTime"></param>
        public void WriteLogFile (String pFileName, String pMethodName, String pMessage, String pTime)
        {
            //String FolderPath = Environment.ExpandEnvironmentVariables("C:\\TextLog\\LogFile.txt");
            FileStream fs = null;
            if (String.IsNullOrEmpty(pFileName))
            {
                this.FileName = ConfigFilePath;
            }
            else
            {
                this.FileName = pFileName; 
                this.FilePath = GetFilePath();
            }
            if (!String.IsNullOrEmpty(this.FileName))
            {
                if (!File.Exists(this.FilePath))
                {
                    using (fs = File.Create(this.FilePath))
                    {
                        //fs.Close();
                    }
                }
                else
                {
                    File.Delete(this.FilePath);
                }
            }
            try
            {
                if (String.IsNullOrEmpty(pTime))
                    pTime = System.DateTime.Now.ToString();
                if (!string.IsNullOrEmpty(pMessage))
                {
                    using (FileStream lFile = new FileStream(this.FilePath, FileMode.OpenOrCreate, FileAccess.Write))
                    {
                        lFile.Close();
                        StreamWriter lStreamWriter = new StreamWriter(this.FilePath, true);
                        lStreamWriter.WriteLine((((pTime + " - ") + this.FileName + " - ") + pMethodName + " - ") + pMessage + "\r\n");
                        lStreamWriter.WriteLine("---------------------------------------- ");
                        lStreamWriter.Close();
                    }

                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message + "\n" + ex.StackTrace);
                throw;
            }
        }

        /// <summary>
        /// Return a String with all the lines in the file log.
        /// </summary>
        /// <returns></returns>
        public String ReadLogFile()
        {
            //String FolderPath = Environment.ExpandEnvironmentVariables("C:\\User\\LogFile.txt");
            String lReadLog = "";
            if (String.IsNullOrEmpty(this.FileName))
            {
                this.FileName = ConfigFilePath;
            }
            
            if (File.Exists(this.FilePath))
            {
                try
                {
                    using (FileStream lFile = new FileStream(this.FilePath, FileMode.Open, FileAccess.Read))
                    {
                        lFile.Close();
                        StreamReader lStreamReader = new StreamReader(this.FilePath, true);
                        lReadLog = lStreamReader.ReadToEnd();
                        lStreamReader.Close();
                    }
                }
                catch (Exception ex)
                {
                    logger.Error(ex, "Exception in TextFileLogger.ReadLogFile " + "\n" + ex.Message + "\n" + ex.StackTrace);
                    throw ex;
                }
            }
            return lReadLog;              
        }
        #endregion

        #region Overrides
        #endregion

    }
}