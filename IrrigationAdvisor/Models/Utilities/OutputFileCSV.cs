using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.IO;
using System.Text;
using System.Windows.Forms;

using IrrigationAdvisor.Models.Management;
using NLog;

namespace IrrigationAdvisor.Models.Utilities
{
    /// <summary>
    /// Create: 2014-12-26
    /// Author: rodouy 
    /// Description: 
    ///     This class is for exit with CSV format to be readed by Excel.
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
    ///     - folderName String
    ///     - fileName String
    ///     - fileHeader Sting
    ///     - fileFooter String
    /// 
    /// Methods:
    ///     - OutputFileCSV()           -- constructor
    ///     - OutputFileCSV(FileName)   -- consturctor with parameters
    ///     - AddTitle(pData)           -- method to set the titles of all the fields
    ///     - AddMessage(pData)         -- method to set the line of fields
    ///     - WriteFile()               -- method to write the file
    /// 
    /// </summary>
    public class OutputFileCSV
    {

        #region Consts

        private const String FOLDER_ROOT = "C:\\";
        private const String FOLDER_NAME = "ExitCSV\\";
        private const String FILE_NAME = "LOGcsv";
        private const String FILE_EXTENTION = ".csv";
        
        #endregion

        #region Fields

        private String folderName;
        private String folderRoot;
        private String filePath;
        private String fileName;
        private String fileHeader;
        private String fileFooter;
        private List<Title> fileTitles;
        private long totalTitles;
        private List<Management.Message> fileMessages;
        private long totalLines;
        private String dataSplit;

        private static Logger logger = LogManager.GetCurrentClassLogger();

        #endregion

        #region Properties

        public String FolderRoot
        {
            get { return folderRoot; }
            set { folderRoot = value; }
        }

        public String FolderName
        {
            get { return folderName; }
            set { folderName = value; }
        }

        public String FilePath
        {
            get { return filePath; }            
        }

        public String FileName
        {
            get { return fileName; }
            set 
            {
                String lFileName = value;
                if (String.IsNullOrEmpty(lFileName))
                {
                    lFileName = FILE_NAME;
                }
                fileName = lFileName; 
            }
        }

        public String FileHeader
        {
            get { return fileHeader; }
            set
            {
                String lFileHeader = value;
                if (String.IsNullOrEmpty(lFileHeader))
                {
                    lFileHeader = "NO Header" + DataSplit;
                }
                else
                {
                    if(!lFileHeader.EndsWith(DataSplit))
                        lFileHeader += DataSplit;
                }
                fileHeader = lFileHeader;
            }
        }

        public String FileFooter
        {
            get { return fileFooter; }
            set
            {
                String lFileFooter = value;
                if (String.IsNullOrEmpty(lFileFooter))
                {
                    lFileFooter = "NO Footer" + DataSplit;
                }
                else
                {
                    if(!lFileFooter.EndsWith(DataSplit))
                        lFileFooter += DataSplit;
                }
                fileFooter = lFileFooter;
            }
        }

        public List<Title> FileTitles
        {
            get { return fileTitles; }
            set
            {
                List<Title> lFileTitles = value;
                Title lTitle;
                if (lFileTitles == null)
                {
                    throw new ArgumentNullException();
                }
                if (lFileTitles.Count < 1)
                {
                    lTitle = new Title();
                    lTitle.Name = "NO Titles" + DataSplit;
                    lFileTitles.Add(lTitle);
                    this.TotalTitles = 1;
                }
                else
                {
                    lTitle = lFileTitles.First<Title>();
                    if(lTitle == null)
                    {
                        throw new ArgumentNullException();
                    }
                    if(lFileTitles.Count < 1)
                    {
                        lTitle.Name = ("NO Titles" + DataSplit);
                        lFileTitles.Add(lTitle);
                        this.TotalTitles = 1;
                    }     
                }
                                
                fileTitles = lFileTitles;
                this.TotalTitles = lFileTitles.Count();
            }
        }

        public long TotalTitles
        {
            get { return totalTitles; }
            set { totalTitles = value; }
        }

        public List<Management.Message> FileMessages
        {
            get { return fileMessages; }
            set
            {
                List<Management.Message> lFileMessages = value;
                Management.Message lMessage;
                if (lFileMessages == null)
                {
                    throw new ArgumentNullException();
                }
                if (lFileMessages.Count < 1)
                {
                    lMessage = new Management.Message();
                    lMessage.Data = ("NO Data" + DataSplit);
                    lFileMessages.Add(lMessage);
                    TotalLines = 1;
                }
                else
                {
                    lMessage = lFileMessages.First<Management.Message>();
                    if (lMessage == null)
                    {
                        throw new ArgumentNullException();
                    }
                    if (lFileMessages.Count < 1)
                    {
                        lMessage.Data = ("NO Data" + DataSplit);
                        lFileMessages.Add(lMessage);
                        TotalLines = 1;
                    }
                }
                fileMessages = lFileMessages;
                this.TotalLines = GetTotalLines(lFileMessages);
            }
        }

        public long TotalLines
        {
            get { return totalLines; }
            set { totalLines = value; }
        }

        public String DataSplit
        {
            get { return dataSplit; }
            set 
            {
                String lDataSplit = value;
                if(String.IsNullOrEmpty(lDataSplit))
                    lDataSplit = ";";
                dataSplit = lDataSplit; 
            }
        }

        private static String ConfigFilePath
        {
            get 
            {
                String lDate = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString();
                String lFilePath = "";
                lFilePath = Application.UserAppDataPath + FILE_NAME + FILE_EXTENTION;
                lFilePath = Environment.ExpandEnvironmentVariables(FOLDER_ROOT + FOLDER_NAME + FILE_NAME + lDate + FILE_EXTENTION);
                return  lFilePath;
            }
        }

        #endregion

        #region Construction

        /// <summary>
        /// Constructor 
        /// </summary>
        public OutputFileCSV()
        {
            String lDate = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString();
            this.FolderRoot = FOLDER_ROOT;
            this.FolderName = FOLDER_ROOT + FOLDER_NAME;

            if (!Directory.Exists(this.FolderName))
            {
                Directory.CreateDirectory(this.FolderName);
            }

            if (File.Exists(ConfigFilePath))
            {
                
                File.Delete(ConfigFilePath);
            }
            this.fileName = FILE_NAME + lDate + FILE_EXTENTION;
            this.filePath = ConfigFilePath;
            this.dataSplit = ";";

            this.TotalTitles = 0;
            this.TotalLines = 0;
        }

        /// <summary>
        /// Constructor with File Name parameter
        /// </summary>
        /// <param name="pFileName"></param>
        public OutputFileCSV(String pFileName)
        {
            String lDate = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString();
            this.FolderRoot = FOLDER_ROOT;
            this.FolderName = FOLDER_ROOT + FOLDER_NAME;
            this.FileName = pFileName + lDate + FILE_EXTENTION;
            this.filePath = this.FolderName + this.FileName;
            this.dataSplit = ";";

            if (!Directory.Exists(this.FolderName))
            {
                Directory.CreateDirectory(this.FolderName);
            }

            if (File.Exists(this.FilePath))
            {
                File.Delete(this.FilePath);
            }

            this.TotalTitles = 0;
            this.TotalLines = 0;
        }
        
        #endregion

        #region Private Helpers
        
        /// <summary>
        /// Add Data Split to a List of Strings
        /// </summary>
        /// <param name="pData"></param>
        private List<String> AddDataSplit(List<String> pData)
        {
            List<String> lReturn = pData;
            for (int i = 0; i < pData.Count; i++)
            {
                if (!pData[i].EndsWith(DataSplit))
                {
                    pData[i] += DataSplit;
                }
            }
            lReturn = pData;
            return lReturn;
        }

        /// <summary>
        /// Return a String with all the items of a Lists of String concatenated
        /// </summary>
        /// <param name="pData"></param>
        /// <returns></returns>
        private String GetAllData(List<String> pData)
        {
            String lReturn = "";
            for (int i = 0; i < pData.Count; i++)
            {
                lReturn += pData[i];
            }
            return lReturn;
        }
        
        /// <summary>
        /// Return the total Lines searchig in Messages
        /// </summary>
        /// <returns></returns>
        private long GetTotalLines(List<Management.Message> lMessageList)
        {
            long lTotalLines = 0;
            long lLine = 0;
            foreach (var item in lMessageList)
            {
                if (!String.IsNullOrEmpty(item.Data))
                {
                    if (lLine < item.LineId)
                    {
                        lTotalLines += 1;
                    }
                }
            }
            return lTotalLines;
        }

        /// <summary>
        /// Add empty Messages (one for eache line) for new Titles column
        /// </summary>
        /// <param name="pTitleId"></param>
        private void AddEmptyMessageForNewTitle(long pTitleId)
        {
            Management.Message lNewMessage;
            List<Management.Message> lMessagesList = new List<Management.Message>();
            IEnumerable<Management.Message> lMessagesListOrderByCIWTitleLine = 
                (from m in this.FileMessages
                     orderby m.CropIrrigationWeatherId, m.TitleId, m.LineId
                select m);
                
            long lLine = 0;
            long lCropIrrigationWeatherId = 0;
            bool lDaily = false;
            long lMessageId = this.FileMessages.Count();
            bool lExistMessage = false;

            foreach (var item in lMessagesListOrderByCIWTitleLine)
            {
                if(lLine + 1 == item.LineId)
                {
                    lCropIrrigationWeatherId = item.CropIrrigationWeatherId;
                    lDaily = item.Daily;
                    if(item.TitleId == pTitleId)
                    {
                        lExistMessage = true;
                    }
                    lMessagesList.Add(item);
                }
                else
                {
                    if (lExistMessage == false) 
                    {
                        lNewMessage = new Management.Message();
                        lNewMessage.MessageId = lMessageId;
                        lNewMessage.TitleId = pTitleId;
                        lNewMessage.LineId = lLine;
                        lNewMessage.CropIrrigationWeatherId = lCropIrrigationWeatherId;
                        lNewMessage.Daily = lDaily;
                        lNewMessage.Data = "";
                        lMessagesList.Add(lNewMessage);
                        lMessageId += 1;
                    }
                    lLine = item.LineId;
                }
            }
            this.FileMessages = lMessagesList;
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Add all Title
        /// 
        /// PreCondition 
        ///     Parameter has data
        /// </summary>
        /// <param name="pData"></param>
        /// <param name="pCropIrrigationWeatherId"></param>
        /// <param name="pDaily"></param>
        public void AddAllTitles(List<String> pData, long pCropIrrigationWeatherId,
                                bool pDaily)
        {
            if (pData != null)
            {
                if (pData.Count > 0 || pData.Any())
                {
                    this.FileTitles = new List<Title>();
                    foreach (var item in pData)
                    {
                        this.FileTitles.Add(new Title(this.FileTitles.Count, 
                            pCropIrrigationWeatherId, pDaily, item));
                    }
                    this.TotalTitles = this.FileTitles.Count();
                }
            }
        }

        /// <summary>
        /// Add a Title to fileTitles
        /// </summary>
        /// <param name="pData"></param>
        public void AddTitle(String pData, long pCropIrrigationWeatherId,
                                bool pDaily)
        {
            long lTitleId = this.FileTitles.Count();
            if (!String.IsNullOrEmpty(pData))
            {
                this.FileTitles.Add(new Title(lTitleId, 
                    pCropIrrigationWeatherId, pDaily, pData));
                this.TotalTitles += 1;
                AddEmptyMessageForNewTitle(lTitleId);
            }
        }

        /// <summary>
        /// Get all the Titles name in a string that contains all the items of the List of titles.
        /// </summary>
        /// <returns></returns>
        public String GetTitles()
        {
            List<String> lTitlesNames = new List<String>();
            foreach (var item in this.FileTitles)
            {
                String lTitleName = item.Name;
                lTitlesNames.Add(lTitleName);
            }
            return GetAllData(AddDataSplit(lTitlesNames));
        }

        /// <summary>
        /// Add a new Message
        /// 
        /// PreCondition
        ///     Has data
        ///     Has LineId, CropIrrigationWeatherId, TitleId
        /// </summary>
        /// <param name="pData"></param>
        public void AddMessage(Management.Message pData)
        {
            if (pData != null)
            {
                if(!String.IsNullOrEmpty(pData.Data))
                {
                    this.FileMessages.Add(pData);
                }
            }
        }

        /// <summary>
        /// Return the index Message from Messages in a string 
        /// 
        /// PreCondition
        ///     index >= 0
        ///     FileMessages has data
        /// </summary>
        /// <param name="pIndex"></param>
        /// <returns></returns>
        public String GetLineOfMessages(int pLineIndex)
        {
            String lReturn = "";
            List<String> lMessageList = new List<String>();
            if (pLineIndex < 0)
            {
                pLineIndex = 0;
            }
            if (this.FileMessages.Count > 0)
            {
                foreach (var item in this.FileMessages)
                {
                    if(item.LineId == pLineIndex)
                    {
                        lMessageList.Add(item.Data);
                    }
                }
                lReturn = GetAllData(AddDataSplit(lMessageList));
            }
            return lReturn;
        }

        /// <summary>
        /// Write the File
        /// </summary>
        /// <param name="pMethodName"></param>
        /// <param name="pDescription"></param>
        /// <param name="pTime"></param>
        public void WriteFile (String pMethodName, String pDescription, String pTime)
        {
            //String FolderPath = Environment.ExpandEnvironmentVariables("C:\\TextLog\\LogFile.txt");
            FileStream fs = null;
            if (!File.Exists(this.FilePath))
            {
                using (fs = File.Create(this.FilePath))
                {
                    // Do not close because we want to write on it
                    //fs.Close();
                }
            }
            else
            {
                File.Delete(this.FilePath);
            }
            try
            {
                if (String.IsNullOrEmpty(pTime))
                {
                    pTime = System.DateTime.Now.ToString();
                }
                if (this.FileTitles != null && this.FileTitles.Count > 0)
                {
                    using (FileStream lFile = new FileStream(this.FilePath, FileMode.OpenOrCreate, FileAccess.Write))
                    {
                        lFile.Close();
                        StreamWriter lStreamWriter = new StreamWriter(this.FilePath, true);
                        lStreamWriter.WriteLine((((pTime + " - ") + this.FileName + " - ") + pMethodName + " - ") + pDescription + DataSplit);
                        lStreamWriter.WriteLine(this.FileHeader);
                        lStreamWriter.WriteLine(this.GetTitles());
                        for (int i = 0; i < this.TotalLines; i++)
			            {
                            lStreamWriter.WriteLine(this.GetLineOfMessages(i));
			 			}
                        lStreamWriter.WriteLine(this.FileFooter);
                        lStreamWriter.WriteLine("---------------------------------------- " + DataSplit);
                        lStreamWriter.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message + "\n" + ex.StackTrace);
                Console.WriteLine("Exception in OutputFileCSV.WriteFile " + ex.Message);
                throw ;
            }
        }

        /// <summary>
        /// Read the file
        /// </summary>
        /// <returns></returns>
        public String ReadFile()
        {
            //String FolderPath = Environment.ExpandEnvironmentVariables("C:\\User\\LogFile.txt");
            String lReadLog = "";
            if (File.Exists(FilePath))
            {
                try
                {
                    using (FileStream lFile = new FileStream(FilePath, FileMode.Open, FileAccess.Read))
                    {
                        lFile.Close();
                        StreamReader lStreamReader = new StreamReader(FilePath, true);
                        lReadLog = lStreamReader.ReadToEnd();
                        lStreamReader.Close();
                    }
                }
                catch (Exception ex)
                {
                    logger.Error(ex, ex.Message + "\n" + ex.StackTrace);
                    throw;
                }
            }
            return lReadLog;              
        }
        
        #endregion

        #region Overrides
        #endregion

    }
}
       